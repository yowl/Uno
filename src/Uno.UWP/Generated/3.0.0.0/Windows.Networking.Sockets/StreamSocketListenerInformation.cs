#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StreamSocketListenerInformation 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string LocalPort
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StreamSocketListenerInformation.LocalPort is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Sockets.StreamSocketListenerInformation.LocalPort.get
	}
}
