#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Phone.Notification.Management
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EmailFolderInfo 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string DisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string EmailFolderInfo.DisplayName is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsNotificationEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool EmailFolderInfo.IsNotificationEnabled is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Phone.Notification.Management.EmailFolderInfo.DisplayName.get
		// Forced skipping of method Windows.Phone.Notification.Management.EmailFolderInfo.IsNotificationEnabled.get
	}
}
