#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct MapZoomLevelRange 
	{
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapZoomLevelRange.MapZoomLevelRange()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  double Min;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  double Max;
		#endif
	}
}
