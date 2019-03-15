#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.Spatial.Preview
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpatialGraphInteropPreview 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Perception.Spatial.SpatialCoordinateSystem CreateCoordinateSystemForNode( global::System.Guid nodeId)
		{
			throw new global::System.NotImplementedException("The member SpatialCoordinateSystem SpatialGraphInteropPreview.CreateCoordinateSystemForNode(Guid nodeId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Perception.Spatial.SpatialCoordinateSystem CreateCoordinateSystemForNode( global::System.Guid nodeId,  global::System.Numerics.Vector3 relativePosition)
		{
			throw new global::System.NotImplementedException("The member SpatialCoordinateSystem SpatialGraphInteropPreview.CreateCoordinateSystemForNode(Guid nodeId, Vector3 relativePosition) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Perception.Spatial.SpatialCoordinateSystem CreateCoordinateSystemForNode( global::System.Guid nodeId,  global::System.Numerics.Vector3 relativePosition,  global::System.Numerics.Quaternion relativeOrientation)
		{
			throw new global::System.NotImplementedException("The member SpatialCoordinateSystem SpatialGraphInteropPreview.CreateCoordinateSystemForNode(Guid nodeId, Vector3 relativePosition, Quaternion relativeOrientation) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Perception.Spatial.SpatialLocator CreateLocatorForNode( global::System.Guid nodeId)
		{
			throw new global::System.NotImplementedException("The member SpatialLocator SpatialGraphInteropPreview.CreateLocatorForNode(Guid nodeId) is not implemented in Uno.");
		}
		#endif
	}
}
