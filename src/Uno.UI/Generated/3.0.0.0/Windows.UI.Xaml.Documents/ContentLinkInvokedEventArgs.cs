#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Documents
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContentLinkInvokedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ContentLinkInvokedEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.ContentLinkInvokedEventArgs", "bool ContentLinkInvokedEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Text.ContentLinkInfo ContentLinkInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContentLinkInfo ContentLinkInvokedEventArgs.ContentLinkInfo is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Documents.ContentLinkInvokedEventArgs.ContentLinkInfo.get
		// Forced skipping of method Windows.UI.Xaml.Documents.ContentLinkInvokedEventArgs.Handled.get
		// Forced skipping of method Windows.UI.Xaml.Documents.ContentLinkInvokedEventArgs.Handled.set
	}
}
