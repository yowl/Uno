#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFiDirect.Services
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WiFiDirectServiceSessionRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionRequest GetSessionRequest()
		{
			throw new global::System.NotImplementedException("The member WiFiDirectServiceSessionRequest WiFiDirectServiceSessionRequestedEventArgs.GetSessionRequest() is not implemented in Uno.");
		}
		#endif
	}
}
