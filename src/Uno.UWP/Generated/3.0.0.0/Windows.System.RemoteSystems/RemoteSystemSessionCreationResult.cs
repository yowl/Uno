#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteSystemSessionCreationResult 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.RemoteSystems.RemoteSystemSession Session
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemSession RemoteSystemSessionCreationResult.Session is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.RemoteSystems.RemoteSystemSessionCreationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemSessionCreationStatus RemoteSystemSessionCreationResult.Status is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionCreationResult.Status.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionCreationResult.Session.get
	}
}
