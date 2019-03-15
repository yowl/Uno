#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.AllJoyn
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AllJoynServiceInfo 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string ObjectPath
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AllJoynServiceInfo.ObjectPath is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  ushort SessionPort
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort AllJoynServiceInfo.SessionPort is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string UniqueName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AllJoynServiceInfo.UniqueName is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public AllJoynServiceInfo( string uniqueName,  string objectPath,  ushort sessionPort) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.AllJoyn.AllJoynServiceInfo", "AllJoynServiceInfo.AllJoynServiceInfo(string uniqueName, string objectPath, ushort sessionPort)");
		}
		#endif
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynServiceInfo.AllJoynServiceInfo(string, string, ushort)
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynServiceInfo.UniqueName.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynServiceInfo.ObjectPath.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynServiceInfo.SessionPort.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.AllJoyn.AllJoynServiceInfo> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AllJoynServiceInfo> AllJoynServiceInfo.FromIdAsync(string deviceId) is not implemented in Uno.");
		}
		#endif
	}
}
