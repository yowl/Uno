#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Holographic
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HolographicSpaceCameraAddedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Holographic.HolographicCamera Camera
		{
			get
			{
				throw new global::System.NotImplementedException("The member HolographicCamera HolographicSpaceCameraAddedEventArgs.Camera is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Graphics.Holographic.HolographicSpaceCameraAddedEventArgs.Camera.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral HolographicSpaceCameraAddedEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
