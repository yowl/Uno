#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.VoiceCommands
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VoiceCommandCompletedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.VoiceCommands.VoiceCommandCompletionReason Reason
		{
			get
			{
				throw new global::System.NotImplementedException("The member VoiceCommandCompletionReason VoiceCommandCompletedEventArgs.Reason is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.VoiceCommands.VoiceCommandCompletedEventArgs.Reason.get
	}
}
