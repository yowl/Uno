#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GattServiceProviderAdvertisingParameters 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsDiscoverable
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool GattServiceProviderAdvertisingParameters.IsDiscoverable is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters", "bool GattServiceProviderAdvertisingParameters.IsDiscoverable");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsConnectable
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool GattServiceProviderAdvertisingParameters.IsConnectable is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters", "bool GattServiceProviderAdvertisingParameters.IsConnectable");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public GattServiceProviderAdvertisingParameters() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters", "GattServiceProviderAdvertisingParameters.GattServiceProviderAdvertisingParameters()");
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters.GattServiceProviderAdvertisingParameters()
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters.IsConnectable.set
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters.IsConnectable.get
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters.IsDiscoverable.set
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters.IsDiscoverable.get
	}
}
