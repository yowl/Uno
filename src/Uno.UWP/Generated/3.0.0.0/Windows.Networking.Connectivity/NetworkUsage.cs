#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Connectivity
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class NetworkUsage 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  ulong BytesReceived
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong NetworkUsage.BytesReceived is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  ulong BytesSent
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong NetworkUsage.BytesSent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan ConnectionDuration
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan NetworkUsage.ConnectionDuration is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Connectivity.NetworkUsage.BytesSent.get
		// Forced skipping of method Windows.Networking.Connectivity.NetworkUsage.BytesReceived.get
		// Forced skipping of method Windows.Networking.Connectivity.NetworkUsage.ConnectionDuration.get
	}
}
