#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.Spatial
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct SpatialBoundingOrientedBox 
	{
		// Forced skipping of method Windows.Perception.Spatial.SpatialBoundingOrientedBox.SpatialBoundingOrientedBox()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  global::System.Numerics.Vector3 Center;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  global::System.Numerics.Vector3 Extents;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  global::System.Numerics.Quaternion Orientation;
		#endif
	}
}
