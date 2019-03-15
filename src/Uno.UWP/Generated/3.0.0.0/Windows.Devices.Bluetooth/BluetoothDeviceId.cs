#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BluetoothDeviceId 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string BluetoothDeviceId.Id is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsClassicDevice
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool BluetoothDeviceId.IsClassicDevice is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsLowEnergyDevice
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool BluetoothDeviceId.IsLowEnergyDevice is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothDeviceId.Id.get
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothDeviceId.IsClassicDevice.get
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothDeviceId.IsLowEnergyDevice.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Devices.Bluetooth.BluetoothDeviceId FromId( string deviceId)
		{
			throw new global::System.NotImplementedException("The member BluetoothDeviceId BluetoothDeviceId.FromId(string deviceId) is not implemented in Uno.");
		}
		#endif
	}
}
