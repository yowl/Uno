#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Printing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GetPreviewPageEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int PageNumber
		{
			get
			{
				throw new global::System.NotImplementedException("The member int GetPreviewPageEventArgs.PageNumber is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public GetPreviewPageEventArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.GetPreviewPageEventArgs", "GetPreviewPageEventArgs.GetPreviewPageEventArgs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Printing.GetPreviewPageEventArgs.GetPreviewPageEventArgs()
		// Forced skipping of method Windows.UI.Xaml.Printing.GetPreviewPageEventArgs.PageNumber.get
	}
}
