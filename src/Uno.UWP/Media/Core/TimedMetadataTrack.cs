#if __IOS__ || __ANDROID__
using Windows.Media.Playback;

namespace Windows.Media.Core
{
	public partial class TimedMetadataTrack
	{
		public string Label { get; set; }

		public string Id { get; }

		public string Language { get; }

		public MediaTrackKind TrackKind { get; } = MediaTrackKind.TimedMetadata;

		public string Name { get; internal set; }

		public TimedMetadataKind TimedMetadataKind { get; internal set; }

		public MediaPlaybackItem PlaybackItem { get; internal set; }

		public TimedMetadataTrack(string id, string language, TimedMetadataKind kind) 
		{
			Id = id;
			Language = language;
			TimedMetadataKind = kind;
		}
	}
}
#endif
