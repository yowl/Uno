#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Display
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct NitRange 
	{
		// Forced skipping of method Windows.Graphics.Display.NitRange.NitRange()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  float MinNits;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  float MaxNits;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  float StepSizeNits;
		#endif
	}
}
