#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Identity
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EnterpriseKeyCredentialRegistrationManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Security.Authentication.Identity.EnterpriseKeyCredentialRegistrationManager Current
		{
			get
			{
				throw new global::System.NotImplementedException("The member EnterpriseKeyCredentialRegistrationManager EnterpriseKeyCredentialRegistrationManager.Current is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Authentication.Identity.EnterpriseKeyCredentialRegistrationInfo>> GetRegistrationsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<EnterpriseKeyCredentialRegistrationInfo>> EnterpriseKeyCredentialRegistrationManager.GetRegistrationsAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.Security.Authentication.Identity.EnterpriseKeyCredentialRegistrationManager.Current.get
	}
}
