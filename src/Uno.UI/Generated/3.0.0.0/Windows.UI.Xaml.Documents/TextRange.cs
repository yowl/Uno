#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Documents
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct TextRange 
	{
		// Forced skipping of method Windows.UI.Xaml.Documents.TextRange.TextRange()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  int StartIndex;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  int Length;
		#endif
	}
}
