#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public   enum PackageSignatureKind 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		Developer,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		Enterprise,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		Store,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		System,
		#endif
	}
	#endif
}
