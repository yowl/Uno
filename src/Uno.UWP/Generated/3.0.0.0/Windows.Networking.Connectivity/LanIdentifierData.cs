#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Connectivity
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LanIdentifierData 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint Type
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint LanIdentifierData.Type is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<byte> Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<byte> LanIdentifierData.Value is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Connectivity.LanIdentifierData.Type.get
		// Forced skipping of method Windows.Networking.Connectivity.LanIdentifierData.Value.get
	}
}
