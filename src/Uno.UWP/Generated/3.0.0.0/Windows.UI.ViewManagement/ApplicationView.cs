#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ViewManagement
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ApplicationView 
	{
		#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		public  string Title
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ApplicationView.Title is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationView", "string ApplicationView.Title");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsScreenCaptureEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ApplicationView.IsScreenCaptureEnabled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationView", "bool ApplicationView.IsScreenCaptureEnabled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AdjacentToLeftDisplayEdge
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ApplicationView.AdjacentToLeftDisplayEdge is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AdjacentToRightDisplayEdge
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ApplicationView.AdjacentToRightDisplayEdge is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property Id
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsFullScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ApplicationView.IsFullScreen is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsOnLockScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ApplicationView.IsOnLockScreen is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property Orientation
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool SuppressSystemOverlays
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ApplicationView.SuppressSystemOverlays is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationView", "bool ApplicationView.SuppressSystemOverlays");
			}
		}
		#endif
		// Skipping already declared property DesiredBoundsMode
		// Skipping already declared property VisibleBounds
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.ViewManagement.FullScreenSystemOverlayMode FullScreenSystemOverlayMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member FullScreenSystemOverlayMode ApplicationView.FullScreenSystemOverlayMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationView", "FullScreenSystemOverlayMode ApplicationView.FullScreenSystemOverlayMode");
			}
		}
		#endif
		// Skipping already declared property IsFullScreenMode
		// Skipping already declared property TitleBar
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.ViewManagement.ApplicationViewMode ViewMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationViewMode ApplicationView.ViewMode is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.ViewManagement.ApplicationViewState Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationViewState ApplicationView.Value is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool TerminateAppOnFinalViewClose
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ApplicationView.TerminateAppOnFinalViewClose is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationView", "bool ApplicationView.TerminateAppOnFinalViewClose");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.ViewManagement.ApplicationViewWindowingMode PreferredLaunchWindowingMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationViewWindowingMode ApplicationView.PreferredLaunchWindowingMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationView", "ApplicationViewWindowingMode ApplicationView.PreferredLaunchWindowingMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.Size PreferredLaunchViewSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Size ApplicationView.PreferredLaunchViewSize is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationView", "Size ApplicationView.PreferredLaunchViewSize");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.Orientation.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.AdjacentToLeftDisplayEdge.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.AdjacentToRightDisplayEdge.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.IsFullScreen.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.IsOnLockScreen.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.IsScreenCaptureEnabled.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.IsScreenCaptureEnabled.set
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.Title.set
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.Title.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.Id.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.Consolidated.add
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.Consolidated.remove
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.SuppressSystemOverlays.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.SuppressSystemOverlays.set
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.VisibleBounds.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.VisibleBoundsChanged.add
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.VisibleBoundsChanged.remove
		// Skipping already declared method Windows.UI.ViewManagement.ApplicationView.SetDesiredBoundsMode(Windows.UI.ViewManagement.ApplicationViewBoundsMode)
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.DesiredBoundsMode.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.TitleBar.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.FullScreenSystemOverlayMode.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.FullScreenSystemOverlayMode.set
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.IsFullScreenMode.get
		#if false || false || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool TryEnterFullScreenMode()
		{
			throw new global::System.NotImplementedException("The member bool ApplicationView.TryEnterFullScreenMode() is not implemented in Uno.");
		}
		#endif
		#if false || false || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ExitFullScreenMode()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationView", "void ApplicationView.ExitFullScreenMode()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ShowStandardSystemOverlays()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationView", "void ApplicationView.ShowStandardSystemOverlays()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool TryResizeView( global::Windows.Foundation.Size value)
		{
			throw new global::System.NotImplementedException("The member bool ApplicationView.TryResizeView(Size value) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetPreferredMinSize( global::Windows.Foundation.Size minSize)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationView", "void ApplicationView.SetPreferredMinSize(Size minSize)");
		}
		#endif
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.ViewMode.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsViewModeSupported( global::Windows.UI.ViewManagement.ApplicationViewMode viewMode)
		{
			throw new global::System.NotImplementedException("The member bool ApplicationView.IsViewModeSupported(ApplicationViewMode viewMode) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<bool> TryEnterViewModeAsync( global::Windows.UI.ViewManagement.ApplicationViewMode viewMode)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ApplicationView.TryEnterViewModeAsync(ApplicationViewMode viewMode) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<bool> TryEnterViewModeAsync( global::Windows.UI.ViewManagement.ApplicationViewMode viewMode,  global::Windows.UI.ViewManagement.ViewModePreferences viewModePreferences)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ApplicationView.TryEnterViewModeAsync(ApplicationViewMode viewMode, ViewModePreferences viewModePreferences) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<bool> TryConsolidateAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ApplicationView.TryConsolidateAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.PreferredLaunchWindowingMode.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.PreferredLaunchWindowingMode.set
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.PreferredLaunchViewSize.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.PreferredLaunchViewSize.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool TryUnsnapToFullscreen()
		{
			throw new global::System.NotImplementedException("The member bool ApplicationView.TryUnsnapToFullscreen() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static int GetApplicationViewIdForWindow( global::Windows.UI.Core.ICoreWindow window)
		{
			throw new global::System.NotImplementedException("The member int ApplicationView.GetApplicationViewIdForWindow(ICoreWindow window) is not implemented in Uno.");
		}
		#endif
		// Skipping already declared method Windows.UI.ViewManagement.ApplicationView.GetForCurrentView()
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.TerminateAppOnFinalViewClose.get
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.TerminateAppOnFinalViewClose.set
		// Forced skipping of method Windows.UI.ViewManagement.ApplicationView.Value.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool TryUnsnap()
		{
			throw new global::System.NotImplementedException("The member bool ApplicationView.TryUnsnap() is not implemented in Uno.");
		}
		#endif
		// Skipping already declared event Windows.UI.ViewManagement.ApplicationView.Consolidated
		// Skipping already declared event Windows.UI.ViewManagement.ApplicationView.VisibleBoundsChanged
	}
}
