#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Inking
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public   enum InkInputRightDragAction 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		LeaveUnprocessed,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		AllowProcessing,
		#endif
	}
	#endif
}
