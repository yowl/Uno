#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Usb
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class UsbBulkInEndpointDescriptor 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  byte EndpointNumber
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte UsbBulkInEndpointDescriptor.EndpointNumber is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint MaxPacketSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint UsbBulkInEndpointDescriptor.MaxPacketSize is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Usb.UsbBulkInPipe Pipe
		{
			get
			{
				throw new global::System.NotImplementedException("The member UsbBulkInPipe UsbBulkInEndpointDescriptor.Pipe is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Usb.UsbBulkInEndpointDescriptor.MaxPacketSize.get
		// Forced skipping of method Windows.Devices.Usb.UsbBulkInEndpointDescriptor.EndpointNumber.get
		// Forced skipping of method Windows.Devices.Usb.UsbBulkInEndpointDescriptor.Pipe.get
	}
}
