#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteSystemSessionJoinResult 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.RemoteSystems.RemoteSystemSession Session
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemSession RemoteSystemSessionJoinResult.Session is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.RemoteSystems.RemoteSystemSessionJoinStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemSessionJoinStatus RemoteSystemSessionJoinResult.Status is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionJoinResult.Status.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionJoinResult.Session.get
	}
}
