#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ISemanticZoomInformation 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsActiveView
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsZoomedInView
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Xaml.Controls.SemanticZoom SemanticZoomOwner
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ISemanticZoomInformation.SemanticZoomOwner.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ISemanticZoomInformation.SemanticZoomOwner.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ISemanticZoomInformation.IsActiveView.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ISemanticZoomInformation.IsActiveView.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ISemanticZoomInformation.IsZoomedInView.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ISemanticZoomInformation.IsZoomedInView.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void InitializeViewChange();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void CompleteViewChange();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void MakeVisible( global::Windows.UI.Xaml.Controls.SemanticZoomLocation item);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void StartViewChangeFrom( global::Windows.UI.Xaml.Controls.SemanticZoomLocation source,  global::Windows.UI.Xaml.Controls.SemanticZoomLocation destination);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void StartViewChangeTo( global::Windows.UI.Xaml.Controls.SemanticZoomLocation source,  global::Windows.UI.Xaml.Controls.SemanticZoomLocation destination);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void CompleteViewChangeFrom( global::Windows.UI.Xaml.Controls.SemanticZoomLocation source,  global::Windows.UI.Xaml.Controls.SemanticZoomLocation destination);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void CompleteViewChangeTo( global::Windows.UI.Xaml.Controls.SemanticZoomLocation source,  global::Windows.UI.Xaml.Controls.SemanticZoomLocation destination);
		#endif
	}
}
