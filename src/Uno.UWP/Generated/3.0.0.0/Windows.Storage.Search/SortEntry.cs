#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Search
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct SortEntry 
	{
		// Forced skipping of method Windows.Storage.Search.SortEntry.SortEntry()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  string PropertyName;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  bool AscendingOrder;
		#endif
	}
}
