#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PerceptionColorFrameSourceAddedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Perception.PerceptionColorFrameSource FrameSource
		{
			get
			{
				throw new global::System.NotImplementedException("The member PerceptionColorFrameSource PerceptionColorFrameSourceAddedEventArgs.FrameSource is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Perception.PerceptionColorFrameSourceAddedEventArgs.FrameSource.get
	}
}
