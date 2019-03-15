#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Spatial
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpatialPointerPose 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Perception.People.HeadPose Head
		{
			get
			{
				throw new global::System.NotImplementedException("The member HeadPose SpatialPointerPose.Head is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Perception.PerceptionTimestamp Timestamp
		{
			get
			{
				throw new global::System.NotImplementedException("The member PerceptionTimestamp SpatialPointerPose.Timestamp is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Input.Spatial.SpatialPointerPose.Timestamp.get
		// Forced skipping of method Windows.UI.Input.Spatial.SpatialPointerPose.Head.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Input.Spatial.SpatialPointerInteractionSourcePose TryGetInteractionSourcePose( global::Windows.UI.Input.Spatial.SpatialInteractionSource source)
		{
			throw new global::System.NotImplementedException("The member SpatialPointerInteractionSourcePose SpatialPointerPose.TryGetInteractionSourcePose(SpatialInteractionSource source) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Input.Spatial.SpatialPointerPose TryGetAtTimestamp( global::Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem,  global::Windows.Perception.PerceptionTimestamp timestamp)
		{
			throw new global::System.NotImplementedException("The member SpatialPointerPose SpatialPointerPose.TryGetAtTimestamp(SpatialCoordinateSystem coordinateSystem, PerceptionTimestamp timestamp) is not implemented in Uno.");
		}
		#endif
	}
}
