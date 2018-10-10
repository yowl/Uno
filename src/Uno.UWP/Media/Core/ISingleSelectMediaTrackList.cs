#if __ANDROID__ || __IOS__
using Windows.Foundation;

namespace Windows.Media.Core
{
	public partial interface ISingleSelectMediaTrackList 
	{
		int SelectedIndex { get; set; }

		event TypedEventHandler<ISingleSelectMediaTrackList, object> SelectedIndexChanged;
	}
}
#endif
