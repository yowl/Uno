#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContactReader 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactBatch> ReadBatchAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactBatch> ContactReader.ReadBatchAsync() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.ContactMatchReason> GetMatchingPropertiesWithMatchReason( global::Windows.ApplicationModel.Contacts.Contact contact)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<ContactMatchReason> ContactReader.GetMatchingPropertiesWithMatchReason(Contact contact) is not implemented in Uno.");
		}
		#endif
	}
}
