#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Web.Provider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IWebAccountProviderTokenObjects 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Security.Authentication.Web.Provider.IWebAccountProviderOperation Operation
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Security.Authentication.Web.Provider.IWebAccountProviderTokenObjects.Operation.get
	}
}
