#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Playback
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaPlaybackSessionOutputDegradationPolicyState 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Playback.MediaPlaybackSessionVideoConstrictionReason VideoConstrictionReason
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlaybackSessionVideoConstrictionReason MediaPlaybackSessionOutputDegradationPolicyState.VideoConstrictionReason is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackSessionOutputDegradationPolicyState.VideoConstrictionReason.get
	}
}
