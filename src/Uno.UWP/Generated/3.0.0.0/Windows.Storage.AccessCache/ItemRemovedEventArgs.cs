#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.AccessCache
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ItemRemovedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Storage.AccessCache.AccessListEntry RemovedEntry
		{
			get
			{
				throw new global::System.NotImplementedException("The member AccessListEntry ItemRemovedEventArgs.RemovedEntry is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Storage.AccessCache.ItemRemovedEventArgs.RemovedEntry.get
	}
}
