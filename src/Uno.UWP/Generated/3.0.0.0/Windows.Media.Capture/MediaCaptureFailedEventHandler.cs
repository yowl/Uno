#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	public delegate void MediaCaptureFailedEventHandler(global::Windows.Media.Capture.MediaCapture @sender, global::Windows.Media.Capture.MediaCaptureFailedEventArgs @errorEventArgs);
	#endif
}
