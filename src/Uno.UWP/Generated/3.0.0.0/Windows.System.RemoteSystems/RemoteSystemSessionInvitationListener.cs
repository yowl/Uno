#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteSystemSessionInvitationListener 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RemoteSystemSessionInvitationListener() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.RemoteSystems.RemoteSystemSessionInvitationListener", "RemoteSystemSessionInvitationListener.RemoteSystemSessionInvitationListener()");
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionInvitationListener.RemoteSystemSessionInvitationListener()
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionInvitationListener.InvitationReceived.add
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionInvitationListener.InvitationReceived.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.System.RemoteSystems.RemoteSystemSessionInvitationListener, global::Windows.System.RemoteSystems.RemoteSystemSessionInvitationReceivedEventArgs> InvitationReceived
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.RemoteSystems.RemoteSystemSessionInvitationListener", "event TypedEventHandler<RemoteSystemSessionInvitationListener, RemoteSystemSessionInvitationReceivedEventArgs> RemoteSystemSessionInvitationListener.InvitationReceived");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.RemoteSystems.RemoteSystemSessionInvitationListener", "event TypedEventHandler<RemoteSystemSessionInvitationListener, RemoteSystemSessionInvitationReceivedEventArgs> RemoteSystemSessionInvitationListener.InvitationReceived");
			}
		}
		#endif
	}
}
