#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ShuffleEnabledChangeRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool RequestedShuffleEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ShuffleEnabledChangeRequestedEventArgs.RequestedShuffleEnabled is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.ShuffleEnabledChangeRequestedEventArgs.RequestedShuffleEnabled.get
	}
}
