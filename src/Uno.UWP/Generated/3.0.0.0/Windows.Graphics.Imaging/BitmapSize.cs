#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Imaging
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct BitmapSize 
	{
		// Forced skipping of method Windows.Graphics.Imaging.BitmapSize.BitmapSize()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  uint Width;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  uint Height;
		#endif
	}
}
