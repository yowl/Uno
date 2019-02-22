using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Uno;
using Uno.Diagnostics.Eventing;
using Uno.Threading;
using Windows.Foundation;

namespace Windows.UI.Core
{
	public class UIAsyncOperation : IDisposable, IAsyncAction
	{
		private FastTaskCompletionSource<object> _tcs;
		private CancellationTokenSource _cts;
		private AsyncActionCompletedHandler _completedHandler;
		private bool _isCompleted;

		/// <summary>
		/// Creates a <see cref="UIAsyncOperation"/> using the provided handler.
		/// </summary>
		/// <param name="action">A handler/param>
		/// <param name="scheduleActivity">An ID that defines the activity being scheduled, used for tracing./param>
		internal UIAsyncOperation(DispatchedHandler action, EventActivity scheduleActivity)
		{
			Action = action;
			ScheduleEventActivity = scheduleActivity;
		}

		/// <summary>
		/// Provides a task the current operation
		/// </summary>
		/// <returns>A task representing the current operation</returns>
		public Task AsTask() => AsTask(CancellationToken.None);

		/// <summary>
		/// Provides a task the current operation
		/// </summary>
		/// <param name="ct">A cancellation token</param>
		/// <returns>A task representing the current operation</returns>
		public Task AsTask(CancellationToken ct)
		{
			ct.Register(() => { Cancel(); });

			return CompletionSource.Task;
		}

		public DispatchedHandler Action { get; }

		public bool IsCancelled { get; private set; }
		public bool IsCompleted { get => IsCancelled || _isCompleted; private set => _isCompleted = value; }

		public EventActivity ScheduleEventActivity { get; }

		internal CancellationToken Token
		{
			get
			{
				if (_cts == null)
				{
					_cts = new CancellationTokenSource();
				}

				return _cts.Token;
			}
		}

		public FastTaskCompletionSource<object> CompletionSource
		{
			get
			{
				if (_tcs == null)
				{
					_tcs = new FastTaskCompletionSource<object>();
				}

				return _tcs;
			}
		}

		public TaskAwaiter GetAwaiter()
		{
			return ((Task)CompletionSource.Task).GetAwaiter();
		}

		/// <summary>
		/// Sets the current operation as complete.
		/// </summary>
		internal void Complete()
		{
			if (_tcs != null && !_tcs.IsCompleted)
			{
				CompletionSource?.TrySetResult(null);
				IsCompleted = true;
				_completedHandler?.Invoke(this, Status);
			}
		}

		public void Cancel()
		{
			if (_tcs != null && !_tcs.IsCompleted)
			{
				CompletionSource?.TrySetCanceled();
				IsCancelled = true;

				_completedHandler?.Invoke(this, Status);
			}

			if (_cts != null && !_cts.IsCancellationRequested)
			{
				_cts.Cancel();
				_cts = null;
			}
		}

		internal void SetError(Exception ex)
		{
			if (_tcs != null && !_tcs.IsCompleted)
			{
				CompletionSource?.TrySetException(ex);
				IsCompleted = true;
				_completedHandler?.Invoke(this, Status);
			}
		}

		public void Dispose() => Cancel();

		Exception IAsyncInfo.ErrorCode => CompletionSource.Exception;

		[NotImplemented]
		uint IAsyncInfo.Id => 0;

		public AsyncStatus Status
		{
			get
			{
				switch (CompletionSource.Task.Status)
				{
					case TaskStatus.Canceled:
						return AsyncStatus.Canceled;

					case TaskStatus.RanToCompletion:
						return AsyncStatus.Completed;

					case TaskStatus.WaitingForActivation:
					case TaskStatus.WaitingToRun:
					case TaskStatus.WaitingForChildrenToComplete:
					case TaskStatus.Created:
					case TaskStatus.Running:
						return AsyncStatus.Started;

					default:
					case TaskStatus.Faulted:
						return AsyncStatus.Error;
				}
			}
		}

		AsyncActionCompletedHandler IAsyncAction.Completed
		{
			get => _completedHandler;
			set
			{
				_completedHandler = value;

				if (Status != AsyncStatus.Started)
				{
					_completedHandler?.Invoke(this, Status);
				}
			}
		}

		void IAsyncAction.GetResults()
			=> CompletionSource.Task.Wait();

		void IAsyncInfo.Cancel()
			=> Cancel();

		void IAsyncInfo.Close()
			=> Cancel();

		internal string GetDiagnosticsName()
			=> Action.Method.DeclaringType.FullName + "." + Action.Method.Name;
	}
}
