#if __IOS__ || __ANDROID__
using Windows.Media.Playback;

namespace Windows.Media.Core
{
	public partial class AudioTrack
	{
		public string Name { get; internal set; }

		public MediaPlaybackItem PlaybackItem { get; internal set; }

		public string Label { get; set; }

		public string Id { get; internal set; }

		public string Language { get; internal set; }

		public MediaTrackKind TrackKind { get; } = MediaTrackKind.Audio;
	}
}
#endif
