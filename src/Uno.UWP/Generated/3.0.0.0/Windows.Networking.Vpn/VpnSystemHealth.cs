#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Vpn
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VpnSystemHealth 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Storage.Streams.Buffer StatementOfHealth
		{
			get
			{
				throw new global::System.NotImplementedException("The member Buffer VpnSystemHealth.StatementOfHealth is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Vpn.VpnSystemHealth.StatementOfHealth.get
	}
}
