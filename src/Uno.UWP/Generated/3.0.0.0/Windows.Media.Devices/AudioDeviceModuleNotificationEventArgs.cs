#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AudioDeviceModuleNotificationEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Devices.AudioDeviceModule Module
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioDeviceModule AudioDeviceModuleNotificationEventArgs.Module is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Storage.Streams.IBuffer NotificationData
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer AudioDeviceModuleNotificationEventArgs.NotificationData is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Devices.AudioDeviceModuleNotificationEventArgs.Module.get
		// Forced skipping of method Windows.Media.Devices.AudioDeviceModuleNotificationEventArgs.NotificationData.get
	}
}
