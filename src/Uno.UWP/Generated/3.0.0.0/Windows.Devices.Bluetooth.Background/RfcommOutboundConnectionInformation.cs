#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.Background
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RfcommOutboundConnectionInformation 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Bluetooth.Rfcomm.RfcommServiceId RemoteServiceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member RfcommServiceId RfcommOutboundConnectionInformation.RemoteServiceId is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Bluetooth.Background.RfcommOutboundConnectionInformation", "RfcommServiceId RfcommOutboundConnectionInformation.RemoteServiceId");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.Background.RfcommOutboundConnectionInformation.RemoteServiceId.get
		// Forced skipping of method Windows.Devices.Bluetooth.Background.RfcommOutboundConnectionInformation.RemoteServiceId.set
	}
}
