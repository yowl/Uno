#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ApplicationSettings
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	public delegate void WebAccountCommandInvokedHandler(global::Windows.UI.ApplicationSettings.WebAccountCommand @command, global::Windows.UI.ApplicationSettings.WebAccountInvokedArgs @args);
	#endif
}
