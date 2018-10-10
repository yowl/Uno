#if __ANDROID__ || __IOS__
namespace Windows.Media.Playback
{
	public enum TimedMetadataTrackPresentationMode 
	{
		Disabled,

		Hidden,

		ApplicationPresented,

		PlatformPresented
	}
}
#endif
