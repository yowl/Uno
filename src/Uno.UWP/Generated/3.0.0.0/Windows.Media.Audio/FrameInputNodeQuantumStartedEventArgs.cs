#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Audio
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FrameInputNodeQuantumStartedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int RequiredSamples
		{
			get
			{
				throw new global::System.NotImplementedException("The member int FrameInputNodeQuantumStartedEventArgs.RequiredSamples is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Audio.FrameInputNodeQuantumStartedEventArgs.RequiredSamples.get
	}
}
