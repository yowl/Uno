#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.SpeechRecognition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpeechContinuousRecognitionCompletedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.SpeechRecognition.SpeechRecognitionResultStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpeechRecognitionResultStatus SpeechContinuousRecognitionCompletedEventArgs.Status is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.SpeechRecognition.SpeechContinuousRecognitionCompletedEventArgs.Status.get
	}
}
