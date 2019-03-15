#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteSystemConnectionRequest 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.RemoteSystems.RemoteSystem RemoteSystem
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystem RemoteSystemConnectionRequest.RemoteSystem is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.RemoteSystems.RemoteSystemApp RemoteSystemApp
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemApp RemoteSystemConnectionRequest.RemoteSystemApp is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RemoteSystemConnectionRequest( global::Windows.System.RemoteSystems.RemoteSystem remoteSystem) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.RemoteSystems.RemoteSystemConnectionRequest", "RemoteSystemConnectionRequest.RemoteSystemConnectionRequest(RemoteSystem remoteSystem)");
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemConnectionRequest.RemoteSystemConnectionRequest(Windows.System.RemoteSystems.RemoteSystem)
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemConnectionRequest.RemoteSystem.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemConnectionRequest.RemoteSystemApp.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.System.RemoteSystems.RemoteSystemConnectionRequest CreateForApp( global::Windows.System.RemoteSystems.RemoteSystemApp remoteSystemApp)
		{
			throw new global::System.NotImplementedException("The member RemoteSystemConnectionRequest RemoteSystemConnectionRequest.CreateForApp(RemoteSystemApp remoteSystemApp) is not implemented in Uno.");
		}
		#endif
	}
}
