#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContactBatch 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.Contact> Contacts
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<Contact> ContactBatch.Contacts is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Contacts.ContactBatchStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactBatchStatus ContactBatch.Status is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactBatch.Contacts.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactBatch.Status.get
	}
}
