#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.Spatial
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpatialAnchorManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Perception.Spatial.SpatialAnchorStore> RequestStoreAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SpatialAnchorStore> SpatialAnchorManager.RequestStoreAsync() is not implemented in Uno.");
		}
		#endif
	}
}
