#if __IOS__ || __ANDROID__
using System.Collections.Generic;
using Windows.Foundation;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
	public partial class MediaPlaybackAudioTrackList : List<AudioTrack>, ISingleSelectMediaTrackList
	{
		public uint Size => (uint)Count;

		private int _selectedIndex;
		public int SelectedIndex
		{
			get
			{
				return _selectedIndex;
			}
			set
			{
				_selectedIndex = value;
				SelectedIndexChanged?.Invoke(this, this[_selectedIndex]);
			}
		}

		public event TypedEventHandler<ISingleSelectMediaTrackList, object> SelectedIndexChanged;
	}
}
#endif
