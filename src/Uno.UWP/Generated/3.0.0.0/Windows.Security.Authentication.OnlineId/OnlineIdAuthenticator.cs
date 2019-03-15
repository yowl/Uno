#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.OnlineId
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class OnlineIdAuthenticator 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Guid ApplicationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid OnlineIdAuthenticator.ApplicationId is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator", "Guid OnlineIdAuthenticator.ApplicationId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string AuthenticatedSafeCustomerId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string OnlineIdAuthenticator.AuthenticatedSafeCustomerId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanSignOut
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool OnlineIdAuthenticator.CanSignOut is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public OnlineIdAuthenticator() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator", "OnlineIdAuthenticator.OnlineIdAuthenticator()");
		}
		#endif
		// Forced skipping of method Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.OnlineIdAuthenticator()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Security.Authentication.OnlineId.UserAuthenticationOperation AuthenticateUserAsync( global::Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest request)
		{
			throw new global::System.NotImplementedException("The member UserAuthenticationOperation OnlineIdAuthenticator.AuthenticateUserAsync(OnlineIdServiceTicketRequest request) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Security.Authentication.OnlineId.UserAuthenticationOperation AuthenticateUserAsync( global::System.Collections.Generic.IEnumerable<global::Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest> requests,  global::Windows.Security.Authentication.OnlineId.CredentialPromptType credentialPromptType)
		{
			throw new global::System.NotImplementedException("The member UserAuthenticationOperation OnlineIdAuthenticator.AuthenticateUserAsync(IEnumerable<OnlineIdServiceTicketRequest> requests, CredentialPromptType credentialPromptType) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Security.Authentication.OnlineId.SignOutUserOperation SignOutUserAsync()
		{
			throw new global::System.NotImplementedException("The member SignOutUserOperation OnlineIdAuthenticator.SignOutUserAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.ApplicationId.set
		// Forced skipping of method Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.ApplicationId.get
		// Forced skipping of method Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.CanSignOut.get
		// Forced skipping of method Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.AuthenticatedSafeCustomerId.get
	}
}
