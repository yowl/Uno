#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Proximity
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ConnectionRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Networking.Proximity.PeerInformation PeerInformation
		{
			get
			{
				throw new global::System.NotImplementedException("The member PeerInformation ConnectionRequestedEventArgs.PeerInformation is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Proximity.ConnectionRequestedEventArgs.PeerInformation.get
	}
}
