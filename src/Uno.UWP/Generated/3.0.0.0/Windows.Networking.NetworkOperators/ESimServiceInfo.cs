#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ESimServiceInfo 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Networking.NetworkOperators.ESimAuthenticationPreference AuthenticationPreference
		{
			get
			{
				throw new global::System.NotImplementedException("The member ESimAuthenticationPreference ESimServiceInfo.AuthenticationPreference is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsESimUiEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ESimServiceInfo.IsESimUiEnabled is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimServiceInfo.AuthenticationPreference.get
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimServiceInfo.IsESimUiEnabled.get
	}
}
