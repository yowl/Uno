#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Input.Preview
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GazeDeviceWatcherRemovedPreviewEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Input.Preview.GazeDevicePreview Device
		{
			get
			{
				throw new global::System.NotImplementedException("The member GazeDevicePreview GazeDeviceWatcherRemovedPreviewEventArgs.Device is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Input.Preview.GazeDeviceWatcherRemovedPreviewEventArgs.Device.get
	}
}
