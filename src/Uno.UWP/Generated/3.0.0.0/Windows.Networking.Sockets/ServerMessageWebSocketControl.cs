#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ServerMessageWebSocketControl 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Networking.Sockets.SocketMessageType MessageType
		{
			get
			{
				throw new global::System.NotImplementedException("The member SocketMessageType ServerMessageWebSocketControl.MessageType is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.ServerMessageWebSocketControl", "SocketMessageType ServerMessageWebSocketControl.MessageType");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Sockets.ServerMessageWebSocketControl.MessageType.get
		// Forced skipping of method Windows.Networking.Sockets.ServerMessageWebSocketControl.MessageType.set
	}
}
