#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaStreamSourceSwitchStreamsRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Core.MediaStreamSourceSwitchStreamsRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaStreamSourceSwitchStreamsRequest MediaStreamSourceSwitchStreamsRequestedEventArgs.Request is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestedEventArgs.Request.get
	}
}
