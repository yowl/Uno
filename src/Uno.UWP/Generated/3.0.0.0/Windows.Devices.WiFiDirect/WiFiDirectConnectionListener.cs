#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFiDirect
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WiFiDirectConnectionListener 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public WiFiDirectConnectionListener() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFiDirect.WiFiDirectConnectionListener", "WiFiDirectConnectionListener.WiFiDirectConnectionListener()");
		}
		#endif
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectConnectionListener.WiFiDirectConnectionListener()
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectConnectionListener.ConnectionRequested.add
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectConnectionListener.ConnectionRequested.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.WiFiDirect.WiFiDirectConnectionListener, global::Windows.Devices.WiFiDirect.WiFiDirectConnectionRequestedEventArgs> ConnectionRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFiDirect.WiFiDirectConnectionListener", "event TypedEventHandler<WiFiDirectConnectionListener, WiFiDirectConnectionRequestedEventArgs> WiFiDirectConnectionListener.ConnectionRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFiDirect.WiFiDirectConnectionListener", "event TypedEventHandler<WiFiDirectConnectionListener, WiFiDirectConnectionRequestedEventArgs> WiFiDirectConnectionListener.ConnectionRequested");
			}
		}
		#endif
	}
}
