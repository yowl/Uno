#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContactChange 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Contacts.ContactChangeType ChangeType
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactChangeType ContactChange.ChangeType is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Contacts.Contact Contact
		{
			get
			{
				throw new global::System.NotImplementedException("The member Contact ContactChange.Contact is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactChange.ChangeType.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactChange.Contact.get
	}
}
