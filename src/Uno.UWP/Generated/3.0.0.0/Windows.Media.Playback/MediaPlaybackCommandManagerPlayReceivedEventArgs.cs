#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Playback
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaPlaybackCommandManagerPlayReceivedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool MediaPlaybackCommandManagerPlayReceivedEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackCommandManagerPlayReceivedEventArgs", "bool MediaPlaybackCommandManagerPlayReceivedEventArgs.Handled");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackCommandManagerPlayReceivedEventArgs.Handled.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackCommandManagerPlayReceivedEventArgs.Handled.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral MediaPlaybackCommandManagerPlayReceivedEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
