#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Markup
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct XamlBinaryWriterErrorInformation 
	{
		// Forced skipping of method Windows.UI.Xaml.Markup.XamlBinaryWriterErrorInformation.XamlBinaryWriterErrorInformation()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  uint InputStreamIndex;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  uint LineNumber;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  uint LinePosition;
		#endif
	}
}
