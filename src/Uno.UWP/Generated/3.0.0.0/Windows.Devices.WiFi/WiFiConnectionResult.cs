#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFi
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WiFiConnectionResult 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.WiFi.WiFiConnectionStatus ConnectionStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member WiFiConnectionStatus WiFiConnectionResult.ConnectionStatus is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.WiFi.WiFiConnectionResult.ConnectionStatus.get
	}
}
