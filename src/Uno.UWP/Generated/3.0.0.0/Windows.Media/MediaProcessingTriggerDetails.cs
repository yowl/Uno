#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaProcessingTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Collections.ValueSet Arguments
		{
			get
			{
				throw new global::System.NotImplementedException("The member ValueSet MediaProcessingTriggerDetails.Arguments is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.MediaProcessingTriggerDetails.Arguments.get
	}
}
