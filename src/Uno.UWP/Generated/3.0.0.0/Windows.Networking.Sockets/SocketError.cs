#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SocketError 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Networking.Sockets.SocketErrorStatus GetStatus( int hresult)
		{
			throw new global::System.NotImplementedException("The member SocketErrorStatus SocketError.GetStatus(int hresult) is not implemented in Uno.");
		}
		#endif
	}
}
