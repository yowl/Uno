#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AudioTrackSupportInfo 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Core.MediaDecoderStatus DecoderStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaDecoderStatus AudioTrackSupportInfo.DecoderStatus is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Core.AudioDecoderDegradation Degradation
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioDecoderDegradation AudioTrackSupportInfo.Degradation is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Core.AudioDecoderDegradationReason DegradationReason
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioDecoderDegradationReason AudioTrackSupportInfo.DegradationReason is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Core.MediaSourceStatus MediaSourceStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaSourceStatus AudioTrackSupportInfo.MediaSourceStatus is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Core.AudioTrackSupportInfo.DecoderStatus.get
		// Forced skipping of method Windows.Media.Core.AudioTrackSupportInfo.Degradation.get
		// Forced skipping of method Windows.Media.Core.AudioTrackSupportInfo.DegradationReason.get
		// Forced skipping of method Windows.Media.Core.AudioTrackSupportInfo.MediaSourceStatus.get
	}
}
