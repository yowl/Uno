#if __IOS__ || __ANDROID__
using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
	public partial class MediaPlaybackItem : IMediaPlaybackSource
	{
		public MediaPlaybackAudioTrackList _audioTracks = new MediaPlaybackAudioTrackList();
		public MediaPlaybackAudioTrackList AudioTracks
		{
			get
			{
				return _audioTracks;
			}
			internal set
			{
				_audioTracks = value;
				AudioTracksChanged?.Invoke(this, new VectorChangedEventArgs(CollectionChange.Reset, 0));
			}
		}

		public MediaPlaybackTimedMetadataTrackList _timedMetadataTracks = new MediaPlaybackTimedMetadataTrackList();
		public MediaPlaybackTimedMetadataTrackList TimedMetadataTracks
		{
			get
			{
				return _timedMetadataTracks;
			}
			internal set
			{
				_timedMetadataTracks = value;
				TimedMetadataTracksChanged?.Invoke(this, new VectorChangedEventArgs(CollectionChange.Reset, 0));
			}
		}

		public MediaSource Source { get; }
		
		public TimeSpan StartTime { get; }

		public TimeSpan? DurationLimit { get; }

		public MediaPlaybackItem(MediaSource source, TimeSpan startTime)
		{
			Source = source;
			StartTime = startTime;
		}

		public MediaPlaybackItem(MediaSource source, TimeSpan startTime, TimeSpan durationLimit)
			:this(source, startTime)
		{
			DurationLimit = durationLimit;
		}

		public MediaPlaybackItem(MediaSource source)
			:this(source, TimeSpan.Zero)
		{
		}

		public static MediaPlaybackItem FindFromMediaSource(MediaSource source)
		{
			return new MediaPlaybackItem(source);
		}

		public event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> AudioTracksChanged;

		public event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> TimedMetadataTracksChanged;
	}
}
#endif
