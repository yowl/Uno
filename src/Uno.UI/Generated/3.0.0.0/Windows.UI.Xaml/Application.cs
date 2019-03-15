#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Application 
	{
		// Skipping already declared property Resources
		// Skipping already declared property RequestedTheme
		// Skipping already declared property DebugSettings
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.ApplicationRequiresPointerMode RequiresPointerMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationRequiresPointerMode Application.RequiresPointerMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "ApplicationRequiresPointerMode Application.RequiresPointerMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.FocusVisualKind FocusVisualKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member FocusVisualKind Application.FocusVisualKind is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "FocusVisualKind Application.FocusVisualKind");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.ApplicationHighContrastAdjustment HighContrastAdjustment
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationHighContrastAdjustment Application.HighContrastAdjustment is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "ApplicationHighContrastAdjustment Application.HighContrastAdjustment");
			}
		}
		#endif
		// Skipping already declared property Current
		// Skipping already declared method Windows.UI.Xaml.Application.Application()
		// Forced skipping of method Windows.UI.Xaml.Application.Application()
		// Forced skipping of method Windows.UI.Xaml.Application.Resources.get
		// Forced skipping of method Windows.UI.Xaml.Application.Resources.set
		// Forced skipping of method Windows.UI.Xaml.Application.DebugSettings.get
		// Forced skipping of method Windows.UI.Xaml.Application.RequestedTheme.get
		// Forced skipping of method Windows.UI.Xaml.Application.RequestedTheme.set
		// Forced skipping of method Windows.UI.Xaml.Application.UnhandledException.add
		// Forced skipping of method Windows.UI.Xaml.Application.UnhandledException.remove
		// Forced skipping of method Windows.UI.Xaml.Application.Suspending.add
		// Forced skipping of method Windows.UI.Xaml.Application.Suspending.remove
		// Forced skipping of method Windows.UI.Xaml.Application.Resuming.add
		// Forced skipping of method Windows.UI.Xaml.Application.Resuming.remove
		// Skipping already declared method Windows.UI.Xaml.Application.Exit()
		// Forced skipping of method Windows.UI.Xaml.Application.FocusVisualKind.get
		// Forced skipping of method Windows.UI.Xaml.Application.FocusVisualKind.set
		// Forced skipping of method Windows.UI.Xaml.Application.RequiresPointerMode.get
		// Forced skipping of method Windows.UI.Xaml.Application.RequiresPointerMode.set
		// Forced skipping of method Windows.UI.Xaml.Application.LeavingBackground.add
		// Forced skipping of method Windows.UI.Xaml.Application.LeavingBackground.remove
		// Forced skipping of method Windows.UI.Xaml.Application.EnteredBackground.add
		// Forced skipping of method Windows.UI.Xaml.Application.EnteredBackground.remove
		// Forced skipping of method Windows.UI.Xaml.Application.HighContrastAdjustment.get
		// Forced skipping of method Windows.UI.Xaml.Application.HighContrastAdjustment.set
		// Skipping already declared method Windows.UI.Xaml.Application.OnActivated(Windows.ApplicationModel.Activation.IActivatedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Application.OnLaunched(Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnFileActivated( global::Windows.ApplicationModel.Activation.FileActivatedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "void Application.OnFileActivated(FileActivatedEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnSearchActivated( global::Windows.ApplicationModel.Activation.SearchActivatedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "void Application.OnSearchActivated(SearchActivatedEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnShareTargetActivated( global::Windows.ApplicationModel.Activation.ShareTargetActivatedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "void Application.OnShareTargetActivated(ShareTargetActivatedEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnFileOpenPickerActivated( global::Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "void Application.OnFileOpenPickerActivated(FileOpenPickerActivatedEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnFileSavePickerActivated( global::Windows.ApplicationModel.Activation.FileSavePickerActivatedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "void Application.OnFileSavePickerActivated(FileSavePickerActivatedEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnCachedFileUpdaterActivated( global::Windows.ApplicationModel.Activation.CachedFileUpdaterActivatedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "void Application.OnCachedFileUpdaterActivated(CachedFileUpdaterActivatedEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnBackgroundActivated( global::Windows.ApplicationModel.Activation.BackgroundActivatedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "void Application.OnBackgroundActivated(BackgroundActivatedEventArgs args)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Application.Current.get
		// Skipping already declared method Windows.UI.Xaml.Application.Start(Windows.UI.Xaml.ApplicationInitializationCallback)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void LoadComponent( object component,  global::System.Uri resourceLocator)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "void Application.LoadComponent(object component, Uri resourceLocator)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void LoadComponent( object component,  global::System.Uri resourceLocator,  global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation componentResourceLocation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "void Application.LoadComponent(object component, Uri resourceLocator, ComponentResourceLocation componentResourceLocation)");
		}
		#endif
		// Skipping already declared event Windows.UI.Xaml.Application.Resuming
		// Skipping already declared event Windows.UI.Xaml.Application.Suspending
		// Skipping already declared event Windows.UI.Xaml.Application.UnhandledException
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.EnteredBackgroundEventHandler EnteredBackground
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "event EnteredBackgroundEventHandler Application.EnteredBackground");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "event EnteredBackgroundEventHandler Application.EnteredBackground");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.LeavingBackgroundEventHandler LeavingBackground
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "event LeavingBackgroundEventHandler Application.LeavingBackground");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Application", "event LeavingBackgroundEventHandler Application.LeavingBackground");
			}
		}
		#endif
	}
}
