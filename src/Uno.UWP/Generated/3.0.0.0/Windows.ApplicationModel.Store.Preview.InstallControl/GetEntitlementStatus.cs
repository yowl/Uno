#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public   enum GetEntitlementStatus 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		Succeeded,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		NoStoreAccount,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		NetworkError,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		ServerError,
		#endif
	}
	#endif
}
