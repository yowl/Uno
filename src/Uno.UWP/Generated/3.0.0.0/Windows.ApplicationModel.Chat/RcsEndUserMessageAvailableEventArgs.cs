#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RcsEndUserMessageAvailableEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsMessageAvailable
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool RcsEndUserMessageAvailableEventArgs.IsMessageAvailable is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Chat.RcsEndUserMessage Message
		{
			get
			{
				throw new global::System.NotImplementedException("The member RcsEndUserMessage RcsEndUserMessageAvailableEventArgs.Message is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs.IsMessageAvailable.get
		// Forced skipping of method Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs.Message.get
	}
}
