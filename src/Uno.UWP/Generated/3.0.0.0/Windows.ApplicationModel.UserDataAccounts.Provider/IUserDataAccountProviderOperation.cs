#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IUserDataAccountProviderOperation 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountProviderOperationKind Kind
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountProviderOperation.Kind.get
	}
}
