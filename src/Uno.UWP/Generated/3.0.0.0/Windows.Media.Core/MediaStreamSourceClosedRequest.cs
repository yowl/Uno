#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaStreamSourceClosedRequest 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Core.MediaStreamSourceClosedReason Reason
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaStreamSourceClosedReason MediaStreamSourceClosedRequest.Reason is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Core.MediaStreamSourceClosedRequest.Reason.get
	}
}
