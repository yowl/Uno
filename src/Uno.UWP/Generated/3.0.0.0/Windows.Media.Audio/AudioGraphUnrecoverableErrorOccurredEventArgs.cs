#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Audio
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AudioGraphUnrecoverableErrorOccurredEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Audio.AudioGraphUnrecoverableError Error
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioGraphUnrecoverableError AudioGraphUnrecoverableErrorOccurredEventArgs.Error is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Audio.AudioGraphUnrecoverableErrorOccurredEventArgs.Error.get
	}
}
