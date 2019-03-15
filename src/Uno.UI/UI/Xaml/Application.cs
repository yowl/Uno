﻿using System;
using Uno;
using Uno.Diagnostics.Eventing;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml
{
	public partial class Application
	{
		private readonly static IEventProvider _trace = Tracing.Get(TraceProvider.Id);

		[Preserve]
		public static class TraceProvider
		{
			public readonly static Guid Id = new Guid(
				// {DEE07725-1CBF-4BF6-AC8A-960360CB3512}
				unchecked ((int)0xdee07725), 0x1cbf, 0x4bf6, new byte[] { 0xac, 0x8a, 0x96, 0x3, 0x60, 0xcb, 0x35, 0x12 }
			);

			public const int LauchedStart = 1;
			public const int LauchedStop = 2;
		}


		public static Application Current { get; private set; }

		public DebugSettings DebugSettings { get; } = new DebugSettings();

		public ApplicationTheme RequestedTheme { get; set; }

		public ResourceDictionary Resources { get; } = new ResourceDictionary();

#pragma warning disable CS0067 // The event is never used
		public event EventHandler<object> Resuming;
#pragma warning restore CS0067 // The event is never used

#pragma warning disable CS0067 // The event is never used
		public event SuspendingEventHandler Suspending;
#pragma warning restore CS0067 // The event is never used

		public event UnhandledExceptionEventHandler UnhandledException;

		[NotImplemented]
		public void Exit()
		{

		}

		public static void Start(global::Windows.UI.Xaml.ApplicationInitializationCallback callback)
		{
			StartPartial(callback);
		}

		static partial void StartPartial(ApplicationInitializationCallback callback);

		protected internal virtual void OnActivated(IActivatedEventArgs args) { }

		protected internal virtual void OnLaunched(LaunchActivatedEventArgs args) { }

		internal void RaiseRecoverableUnhandledException(Exception e) => UnhandledException?.Invoke(this, new UnhandledExceptionEventArgs(e, false));

		private IDisposable WritePhaseEventTrace(int startEventId, int stopEventId)
		{
			if (_trace.IsEnabled)
			{
				return _trace.WriteEventActivity(
					startEventId,
					stopEventId,
					new object[] { }
				);
			}
			else
			{
				return null;
			}
		}

		internal void OnResuming()
		{
			ApplicationModel.Core.CoreApplication.RaiseResuming();

			OnResumingPartial();
		}

		partial void OnResumingPartial();

		internal void OnSuspending()
		{
			ApplicationModel.Core.CoreApplication.RaiseSuspending(new ApplicationModel.SuspendingEventArgs(new ApplicationModel.SuspendingOperation(DateTime.Now.AddSeconds(30))));

			OnSuspendingPartial();
		}

		partial void OnSuspendingPartial();

		protected virtual void OnWindowCreated(global::Windows.UI.Xaml.WindowCreatedEventArgs args)
		{
		}

		internal void RaiseWindowCreated(Window window)
		{
			OnWindowCreated(new WindowCreatedEventArgs(window));
		}
	}
}
