#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GattLocalDescriptorResult 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalDescriptor Descriptor
		{
			get
			{
				throw new global::System.NotImplementedException("The member GattLocalDescriptor GattLocalDescriptorResult.Descriptor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Bluetooth.BluetoothError Error
		{
			get
			{
				throw new global::System.NotImplementedException("The member BluetoothError GattLocalDescriptorResult.Error is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalDescriptorResult.Descriptor.get
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalDescriptorResult.Error.get
	}
}
