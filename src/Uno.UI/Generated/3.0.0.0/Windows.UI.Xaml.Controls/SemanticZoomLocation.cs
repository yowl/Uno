#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SemanticZoomLocation 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Item
		{
			get
			{
				throw new global::System.NotImplementedException("The member object SemanticZoomLocation.Item is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SemanticZoomLocation", "object SemanticZoomLocation.Item");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Rect Bounds
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect SemanticZoomLocation.Bounds is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SemanticZoomLocation", "Rect SemanticZoomLocation.Bounds");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SemanticZoomLocation() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SemanticZoomLocation", "SemanticZoomLocation.SemanticZoomLocation()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomLocation.SemanticZoomLocation()
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomLocation.Item.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomLocation.Item.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomLocation.Bounds.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomLocation.Bounds.set
	}
}
