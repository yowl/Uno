#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebViewSettings 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsJavaScriptEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool WebViewSettings.IsJavaScriptEnabled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebViewSettings", "bool WebViewSettings.IsJavaScriptEnabled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsIndexedDBEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool WebViewSettings.IsIndexedDBEnabled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebViewSettings", "bool WebViewSettings.IsIndexedDBEnabled");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.WebViewSettings.IsJavaScriptEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebViewSettings.IsJavaScriptEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WebViewSettings.IsIndexedDBEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebViewSettings.IsIndexedDBEnabled.set
	}
}
