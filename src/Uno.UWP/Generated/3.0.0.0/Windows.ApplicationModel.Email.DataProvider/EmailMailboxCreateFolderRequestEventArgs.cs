#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email.DataProvider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EmailMailboxCreateFolderRequestEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Email.DataProvider.EmailMailboxCreateFolderRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member EmailMailboxCreateFolderRequest EmailMailboxCreateFolderRequestEventArgs.Request is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Email.DataProvider.EmailMailboxCreateFolderRequestEventArgs.Request.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral EmailMailboxCreateFolderRequestEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
