#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContactStoreNotificationTrigger : global::Windows.ApplicationModel.Background.IBackgroundTrigger
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ContactStoreNotificationTrigger() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.ContactStoreNotificationTrigger", "ContactStoreNotificationTrigger.ContactStoreNotificationTrigger()");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.ContactStoreNotificationTrigger.ContactStoreNotificationTrigger()
		// Processing: Windows.ApplicationModel.Background.IBackgroundTrigger
	}
}
