#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteSystemSessionAddedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.RemoteSystems.RemoteSystemSessionInfo SessionInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemSessionInfo RemoteSystemSessionAddedEventArgs.SessionInfo is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionAddedEventArgs.SessionInfo.get
	}
}
