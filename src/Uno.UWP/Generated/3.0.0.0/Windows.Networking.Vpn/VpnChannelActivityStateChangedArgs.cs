#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Vpn
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VpnChannelActivityStateChangedArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Networking.Vpn.VpnChannelActivityEventType ActivityState
		{
			get
			{
				throw new global::System.NotImplementedException("The member VpnChannelActivityEventType VpnChannelActivityStateChangedArgs.ActivityState is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Vpn.VpnChannelActivityStateChangedArgs.ActivityState.get
	}
}
