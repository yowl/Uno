#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Phone.Notification.Management
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public   enum PhoneMediaType 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		AudioOnly,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		AudioVideo,
		#endif
	}
	#endif
}
