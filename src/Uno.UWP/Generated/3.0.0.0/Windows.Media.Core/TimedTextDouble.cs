#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct TimedTextDouble 
	{
		// Forced skipping of method Windows.Media.Core.TimedTextDouble.TimedTextDouble()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  double Value;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  global::Windows.Media.Core.TimedTextUnit Unit;
		#endif
	}
}
