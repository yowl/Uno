#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Audio
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CreateAudioFileOutputNodeResult 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Audio.AudioFileOutputNode FileOutputNode
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioFileOutputNode CreateAudioFileOutputNodeResult.FileOutputNode is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Audio.AudioFileNodeCreationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioFileNodeCreationStatus CreateAudioFileOutputNodeResult.Status is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception CreateAudioFileOutputNodeResult.ExtendedError is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Audio.CreateAudioFileOutputNodeResult.Status.get
		// Forced skipping of method Windows.Media.Audio.CreateAudioFileOutputNodeResult.FileOutputNode.get
		// Forced skipping of method Windows.Media.Audio.CreateAudioFileOutputNodeResult.ExtendedError.get
	}
}
