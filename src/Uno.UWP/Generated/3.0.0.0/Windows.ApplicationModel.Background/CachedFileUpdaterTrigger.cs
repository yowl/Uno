#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CachedFileUpdaterTrigger : global::Windows.ApplicationModel.Background.IBackgroundTrigger
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CachedFileUpdaterTrigger() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.CachedFileUpdaterTrigger", "CachedFileUpdaterTrigger.CachedFileUpdaterTrigger()");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.CachedFileUpdaterTrigger.CachedFileUpdaterTrigger()
		// Processing: Windows.ApplicationModel.Background.IBackgroundTrigger
	}
}
