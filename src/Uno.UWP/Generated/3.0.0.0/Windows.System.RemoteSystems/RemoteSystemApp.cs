#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteSystemApp 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyDictionary<string, string> Attributes
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, string> RemoteSystemApp.Attributes is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string DisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string RemoteSystemApp.DisplayName is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string RemoteSystemApp.Id is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsAvailableByProximity
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool RemoteSystemApp.IsAvailableByProximity is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsAvailableBySpatialProximity
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool RemoteSystemApp.IsAvailableBySpatialProximity is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemApp.Id.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemApp.DisplayName.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemApp.IsAvailableByProximity.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemApp.IsAvailableBySpatialProximity.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemApp.Attributes.get
	}
}
