#if __ANDROID__ || __IOS__
using Windows.Media.Core;

namespace Windows.Media.Playback
{
	public  partial class TimedMetadataPresentationModeChangedEventArgs 
	{
		public TimedMetadataTrackPresentationMode NewPresentationMode { get; internal set; }
			   
		public TimedMetadataTrackPresentationMode OldPresentationMode { get; internal set; }
			   
		public TimedMetadataTrack Track { get; internal set; }
	}
}
#endif
