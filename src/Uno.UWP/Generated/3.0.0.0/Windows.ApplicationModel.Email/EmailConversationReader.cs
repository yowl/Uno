#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EmailConversationReader 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Email.EmailConversationBatch> ReadBatchAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<EmailConversationBatch> EmailConversationReader.ReadBatchAsync() is not implemented in Uno.");
		}
		#endif
	}
}
