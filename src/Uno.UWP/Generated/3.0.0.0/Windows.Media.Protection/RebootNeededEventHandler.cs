#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Protection
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	public delegate void RebootNeededEventHandler(global::Windows.Media.Protection.MediaProtectionManager @sender);
	#endif
}
