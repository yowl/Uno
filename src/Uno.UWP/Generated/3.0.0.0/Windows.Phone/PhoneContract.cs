#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Phone
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct PhoneContract 
	{
		// Forced skipping of method Windows.Phone.PhoneContract.PhoneContract()
	}
}
