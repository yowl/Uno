#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BitmapCache : global::Windows.UI.Xaml.Media.CacheMode
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public BitmapCache() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.BitmapCache", "BitmapCache.BitmapCache()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.BitmapCache.BitmapCache()
	}
}
