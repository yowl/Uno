#nullable enable

#if __WASM__
using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.ApplicationModel;
using Windows.Graphics.Display;
using Windows.UI.Core;
using Uno.Foundation;
using Uno.Extensions;
using Uno.Logging;
using System.Threading;
using Uno.UI;
using Uno.UI.Xaml;
using Uno;
using System.Web;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using Uno.Helpers;
using Microsoft.Extensions.Logging;
using Uno.Diagnostics.Eventing;
#if HAS_UNO_WINUI
using LaunchActivatedEventArgs = Microsoft.UI.Xaml.LaunchActivatedEventArgs;
#else
using LaunchActivatedEventArgs = Windows.ApplicationModel.Activation.LaunchActivatedEventArgs;
#endif

namespace Windows.UI.Xaml
{
	public partial class Application
	{
		private static bool _startInvoked = false;

		public Application()
		{
			if (!_startInvoked)
			{
				throw new InvalidOperationException("The application must be started using Application.Start first, e.g. Windows.UI.Xaml.Application.Start(_ => new App());");
			}

			Current = this;
			Package.SetEntryAssembly(this.GetType().Assembly);

			CoreDispatcher.Main.RunAsync(CoreDispatcherPriority.Normal, Initialize);
		}

		[Preserve]
		public static int DispatchSystemThemeChange()
		{
			Windows.UI.Xaml.Application.Current.OnSystemThemeChanged();
			return 0;
		}

		static partial void StartPartial(ApplicationInitializationCallback callback)
		{
			_startInvoked = true;

			var isHostedMode = !WebAssemblyRuntime.IsWebAssembly;
			var isLoadEventsEnabled = !FeatureConfiguration.FrameworkElement.WasmUseManagedLoadedUnloaded;
			WindowManagerInterop.Init(isHostedMode, isLoadEventsEnabled);
			Windows.Storage.ApplicationData.Init();

			SynchronizationContext.SetSynchronizationContext(
				new CoreDispatcherSynchronizationContext(CoreDispatcher.Main, CoreDispatcherPriority.Normal)
			);

			callback(new ApplicationInitializationCallbackParams());
		}

		partial void ObserveSystemThemeChanges()
		{
			WebAssemblyRuntime.InvokeJS("Windows.UI.Xaml.Application.observeSystemTheme()");
		}

		[DllImport("*")]
		private static unsafe extern int printf(byte* str, byte* unused);
		public struct TwoByteStr
		{
			public byte first;
			public byte second;
		}
		private static unsafe void PrintString(string s)
		{
			int length = s.Length;
			fixed (char* curChar = s)
			{
				for (int i = 0; i < length; i++)
				{
					CoreDispatcher.TwoByteStr curCharStr = new CoreDispatcher.TwoByteStr();
					curCharStr.first = (byte)(*(curChar + i));
					printf((byte*)&curCharStr, null);
				}
			}
		}
		public static void PrintLine(string s)
		{
			PrintString(s);
			PrintString("\n");
		}
		private void Initialize()
		{
			using (WritePhaseEventTrace(TraceProvider.LauchedStart, TraceProvider.LauchedStop))
			{
				// Force init
				Window.Current.ToString();

				var arguments = WebAssemblyRuntime.InvokeJS("Uno.UI.WindowManager.findLaunchArguments()");

				if (this.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
				{
					this.Log().Debug("Launch arguments: " + arguments);
				}
				InitializationCompleted();
				PrintLine("InitializationCompleted");
				if (!string.IsNullOrEmpty(arguments))
				{
					PrintLine("InitializationCompleted args " + arguments);

					if (ProtocolActivation.TryParseActivationUri(arguments, out var activationUri))
					{
						PrintLine("Initialize OnActivated ");
						OnActivated(new ProtocolActivatedEventArgs(activationUri, ApplicationExecutionState.NotRunning));
						PrintLine("Initialize OnActivated end ");
						return;
					}
				}
						PrintLine("Initialize OnLaunched ");
				OnLaunched(new LaunchActivatedEventArgs(ActivationKind.Launch, arguments));
			}
			PrintLine("Initialize end");

		}

		private ApplicationTheme GetDefaultSystemTheme()
		{
			var serializedTheme = WebAssemblyRuntime.InvokeJS("Windows.UI.Xaml.Application.getDefaultSystemTheme()");

			if (serializedTheme != null)
			{
				if (Enum.TryParse(serializedTheme, out ApplicationTheme theme))
				{
					if (this.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Information))
					{
						this.Log().Info("Setting OS preferred theme: " + theme);
					}
					return theme;
				}
				else
				{
					throw new InvalidOperationException($"{serializedTheme} theme is not a supported OS theme");
				}
			}
			//OS has no preference or API not implemented, use light as default
			if (this.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Information))
			{
				this.Log().Info("No preferred theme, using Light instead");
			}
			return ApplicationTheme.Light;
		}

		/// <summary>
		/// Dispatch method from Javascript
		/// </summary>
		internal static void DispatchSuspending()
		{
			Current?.OnSuspending();
		}

		partial void OnSuspendingPartial()
		{
			var completed = false;
			var operation = new SuspendingOperation(DateTime.Now.AddSeconds(0), () => completed = true);

			Suspending?.Invoke(this, new SuspendingEventArgs(operation));
			operation.EventRaiseCompleted();

			if (!completed && this.Log().IsEnabled(LogLevel.Warning))
			{
				this.Log().LogWarning($"This platform does not support asynchronous Suspending deferral. Code executed after the of the method called by Suspending may not get executed.");
			}
		}
	}
}
#endif
