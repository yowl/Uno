﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Uno.Foundation;
using Uno.Foundation.Interop;

namespace Windows.UI.Core
{
	public sealed partial class CoreDispatcher
	{
		readonly bool ThreadingSupported = false;// CoreRT cannot read env. Environment.GetEnvironmentVariable("UNO_BOOTSTRAP_MONO_RUNTIME_CONFIGURATION").StartsWith("threads", StringComparison.OrdinalIgnoreCase);
		private Timer _backgroundWakeupTimer;

		/// <summary>
		/// Method invoked from 
		/// </summary>
		private static int DispatcherCallback()
		{
			Main.DispatchItems();
			return 0; // Required by bind_static_method (void is not supported)
		}

		/// <summary>
		/// Provide a action that will delegate the dispatch of CoreDispatcher work
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Action<Action> DispatchOverride;

		partial void Initialize()
		{
			if (ThreadingSupported)
			{
				if(Thread.CurrentThread.ManagedThreadId != 1)
				{
					throw new InvalidOperationException($"CoreDispatcher must be initialized on the main Javascript thread");
				}

				_backgroundWakeupTimer = new Timer(_ => Main.DispatchItems());
				_backgroundWakeupTimer.Change(0, 50);
			}
		}

		// Always reschedule, otherwise we may end up in live-lock.
		public static bool HasThreadAccessOverride { get; set; } = false;

		private bool GetHasThreadAccess()
		{
			if (ThreadingSupported)
			{
				return Thread.CurrentThread.ManagedThreadId == 1;
			}
			else
			{
				return HasThreadAccessOverride;
			}
		}

		public static CoreDispatcher Main { get; } = new CoreDispatcher();

		partial void EnqueueNative()
		{
			if (DispatchOverride == null)
			{
				if (!ThreadingSupported)
				{
					WebAssemblyRuntime.InvokeJSUnmarshalled("CoreDispatcher:WakeUp", IntPtr.Zero);
				}
				else
				{
					// The _backgroundWakeupTimer will do the dispatching.
				}
			}
			else
			{
				DispatchOverride(() => DispatchItems());
			}
		}
	}
}
