#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.DataTransfer
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	public delegate void ShareProviderHandler(global::Windows.ApplicationModel.DataTransfer.ShareProviderOperation @operation);
	#endif
}
