#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PerceptionColorFrameArrivedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan RelativeTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan PerceptionColorFrameArrivedEventArgs.RelativeTime is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Perception.PerceptionColorFrameArrivedEventArgs.RelativeTime.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Perception.PerceptionColorFrame TryOpenFrame()
		{
			throw new global::System.NotImplementedException("The member PerceptionColorFrame PerceptionColorFrameArrivedEventArgs.TryOpenFrame() is not implemented in Uno.");
		}
		#endif
	}
}
