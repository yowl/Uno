#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public   enum ZoomTransitionMode 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		Auto,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		Direct,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		Smooth,
		#endif
	}
	#endif
}
