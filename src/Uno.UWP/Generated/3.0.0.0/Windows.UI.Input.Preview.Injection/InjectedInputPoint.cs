#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Preview.Injection
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct InjectedInputPoint 
	{
		// Forced skipping of method Windows.UI.Input.Preview.Injection.InjectedInputPoint.InjectedInputPoint()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  int PositionX;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  int PositionY;
		#endif
	}
}
