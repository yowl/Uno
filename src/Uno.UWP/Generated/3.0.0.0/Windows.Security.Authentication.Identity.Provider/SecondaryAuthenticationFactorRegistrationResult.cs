#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Identity.Provider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SecondaryAuthenticationFactorRegistrationResult 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration Registration
		{
			get
			{
				throw new global::System.NotImplementedException("The member SecondaryAuthenticationFactorRegistration SecondaryAuthenticationFactorRegistrationResult.Registration is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistrationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member SecondaryAuthenticationFactorRegistrationStatus SecondaryAuthenticationFactorRegistrationResult.Status is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistrationResult.Status.get
		// Forced skipping of method Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistrationResult.Registration.get
	}
}
