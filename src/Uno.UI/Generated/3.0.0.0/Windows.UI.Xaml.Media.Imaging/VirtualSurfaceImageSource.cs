#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Imaging
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VirtualSurfaceImageSource : global::Windows.UI.Xaml.Media.Imaging.SurfaceImageSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public VirtualSurfaceImageSource( int pixelWidth,  int pixelHeight) : base(pixelWidth, pixelHeight)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource", "VirtualSurfaceImageSource.VirtualSurfaceImageSource(int pixelWidth, int pixelHeight)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource.VirtualSurfaceImageSource(int, int)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public VirtualSurfaceImageSource( int pixelWidth,  int pixelHeight,  bool isOpaque) : base(pixelWidth, pixelHeight)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource", "VirtualSurfaceImageSource.VirtualSurfaceImageSource(int pixelWidth, int pixelHeight, bool isOpaque)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource.VirtualSurfaceImageSource(int, int, bool)
	}
}
