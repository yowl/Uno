#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Printing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	public delegate void GetPreviewPageEventHandler(object @sender, global::Windows.UI.Xaml.Printing.GetPreviewPageEventArgs @e);
	#endif
}
