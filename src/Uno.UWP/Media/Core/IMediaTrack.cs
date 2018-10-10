#if __IOS__ || __ANDROID__
namespace Windows.Media.Core
{
	public partial interface IMediaTrack 
	{
		string Id
		{
			get;
		}

		string Label
		{
			get;
			set;
		}

		string Language
		{
			get;
		}

		MediaTrackKind TrackKind
		{
			get;
		}
	}
}
#endif
