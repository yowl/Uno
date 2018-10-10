#if __IOS__ || __ANDROID__
using System.Collections.Generic;
using Windows.Foundation;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
	public partial class MediaPlaybackTimedMetadataTrackList : List<TimedMetadataTrack>
	{
		public uint Size => (uint)Count;

		private IDictionary<TimedMetadataTrack, TimedMetadataTrackPresentationMode> _presentationModes = new Dictionary<TimedMetadataTrack, TimedMetadataTrackPresentationMode>();

		public TimedMetadataTrackPresentationMode GetPresentationMode(uint index)
		{
			var track = this[(int)index];

			if (_presentationModes.ContainsKey(track))
			{
				return _presentationModes[track];
			}

			return TimedMetadataTrackPresentationMode.Disabled;
		}

		public void SetPresentationMode(uint index,  TimedMetadataTrackPresentationMode value)
		{
			var track = this[(int)index];
			var oldValue = TimedMetadataTrackPresentationMode.Disabled;
			var hasChanged = false;

			if (_presentationModes.ContainsKey(track))
			{
				oldValue = _presentationModes[track];

				if (value != oldValue)
				{
					_presentationModes[track] = value;
					hasChanged = true;
				}
			}
			else
			{
				_presentationModes.Add(track, value);
				hasChanged = true;
			}

			if (hasChanged)
			{
				PresentationModeChanged?.Invoke(this, new TimedMetadataPresentationModeChangedEventArgs()
				{
					OldPresentationMode = oldValue,
					NewPresentationMode = value,
					Track = track
				});
			}
		}

		public event TypedEventHandler<MediaPlaybackTimedMetadataTrackList, TimedMetadataPresentationModeChangedEventArgs> PresentationModeChanged;
	}
}
#endif
