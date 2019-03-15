#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ESim 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int? AvailableMemoryInBytes
		{
			get
			{
				throw new global::System.NotImplementedException("The member int? ESim.AvailableMemoryInBytes is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Eid
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ESim.Eid is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string FirmwareVersion
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ESim.FirmwareVersion is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string MobileBroadbandModemDeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ESim.MobileBroadbandModemDeviceId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Networking.NetworkOperators.ESimPolicy Policy
		{
			get
			{
				throw new global::System.NotImplementedException("The member ESimPolicy ESim.Policy is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Networking.NetworkOperators.ESimState State
		{
			get
			{
				throw new global::System.NotImplementedException("The member ESimState ESim.State is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.ESim.AvailableMemoryInBytes.get
		// Forced skipping of method Windows.Networking.NetworkOperators.ESim.Eid.get
		// Forced skipping of method Windows.Networking.NetworkOperators.ESim.FirmwareVersion.get
		// Forced skipping of method Windows.Networking.NetworkOperators.ESim.MobileBroadbandModemDeviceId.get
		// Forced skipping of method Windows.Networking.NetworkOperators.ESim.Policy.get
		// Forced skipping of method Windows.Networking.NetworkOperators.ESim.State.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.NetworkOperators.ESimProfile> GetProfiles()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<ESimProfile> ESim.GetProfiles() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.NetworkOperators.ESimOperationResult> DeleteProfileAsync( string profileId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ESimOperationResult> ESim.DeleteProfileAsync(string profileId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.NetworkOperators.ESimDownloadProfileMetadataResult> DownloadProfileMetadataAsync( string activationCode)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ESimDownloadProfileMetadataResult> ESim.DownloadProfileMetadataAsync(string activationCode) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.NetworkOperators.ESimOperationResult> ResetAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ESimOperationResult> ESim.ResetAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.ESim.ProfileChanged.add
		// Forced skipping of method Windows.Networking.NetworkOperators.ESim.ProfileChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Networking.NetworkOperators.ESim, object> ProfileChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.NetworkOperators.ESim", "event TypedEventHandler<ESim, object> ESim.ProfileChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.NetworkOperators.ESim", "event TypedEventHandler<ESim, object> ESim.ProfileChanged");
			}
		}
		#endif
	}
}
