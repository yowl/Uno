#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BluetoothAdapter 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  ulong BluetoothAddress
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong BluetoothAdapter.BluetoothAddress is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string BluetoothAdapter.DeviceId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsAdvertisementOffloadSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool BluetoothAdapter.IsAdvertisementOffloadSupported is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsCentralRoleSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool BluetoothAdapter.IsCentralRoleSupported is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsClassicSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool BluetoothAdapter.IsClassicSupported is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsLowEnergySupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool BluetoothAdapter.IsLowEnergySupported is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsPeripheralRoleSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool BluetoothAdapter.IsPeripheralRoleSupported is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AreClassicSecureConnectionsSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool BluetoothAdapter.AreClassicSecureConnectionsSupported is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AreLowEnergySecureConnectionsSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool BluetoothAdapter.AreLowEnergySecureConnectionsSupported is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothAdapter.DeviceId.get
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothAdapter.BluetoothAddress.get
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothAdapter.IsClassicSupported.get
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothAdapter.IsLowEnergySupported.get
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothAdapter.IsPeripheralRoleSupported.get
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothAdapter.IsCentralRoleSupported.get
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothAdapter.IsAdvertisementOffloadSupported.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Radios.Radio> GetRadioAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Radio> BluetoothAdapter.GetRadioAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothAdapter.AreClassicSecureConnectionsSupported.get
		// Forced skipping of method Windows.Devices.Bluetooth.BluetoothAdapter.AreLowEnergySecureConnectionsSupported.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static string GetDeviceSelector()
		{
			throw new global::System.NotImplementedException("The member string BluetoothAdapter.GetDeviceSelector() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Bluetooth.BluetoothAdapter> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<BluetoothAdapter> BluetoothAdapter.FromIdAsync(string deviceId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Bluetooth.BluetoothAdapter> GetDefaultAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<BluetoothAdapter> BluetoothAdapter.GetDefaultAsync() is not implemented in Uno.");
		}
		#endif
	}
}
