#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Streaming.Adaptive
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AdaptiveMediaSourceDownloadBitrateChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint NewValue
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint AdaptiveMediaSourceDownloadBitrateChangedEventArgs.NewValue is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint OldValue
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint AdaptiveMediaSourceDownloadBitrateChangedEventArgs.OldValue is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedReason Reason
		{
			get
			{
				throw new global::System.NotImplementedException("The member AdaptiveMediaSourceDownloadBitrateChangedReason AdaptiveMediaSourceDownloadBitrateChangedEventArgs.Reason is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedEventArgs.OldValue.get
		// Forced skipping of method Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedEventArgs.NewValue.get
		// Forced skipping of method Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedEventArgs.Reason.get
	}
}
