#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GattReadResult 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Bluetooth.GenericAttributeProfile.GattCommunicationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member GattCommunicationStatus GattReadResult.Status is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Storage.Streams.IBuffer Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer GattReadResult.Value is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  byte? ProtocolError
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte? GattReadResult.ProtocolError is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattReadResult.Status.get
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattReadResult.Value.get
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattReadResult.ProtocolError.get
	}
}
