#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	public delegate void ApplicationDataSetVersionHandler(global::Windows.Storage.SetVersionRequest @setVersionRequest);
	#endif
}
