#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Enumeration
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DeviceSelectedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Enumeration.DeviceInformation SelectedDevice
		{
			get
			{
				throw new global::System.NotImplementedException("The member DeviceInformation DeviceSelectedEventArgs.SelectedDevice is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Enumeration.DeviceSelectedEventArgs.SelectedDevice.get
	}
}
