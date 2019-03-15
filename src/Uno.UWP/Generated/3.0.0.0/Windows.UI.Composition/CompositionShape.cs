#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionShape : global::Windows.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Matrix3x2 TransformMatrix
		{
			get
			{
				throw new global::System.NotImplementedException("The member Matrix3x2 CompositionShape.TransformMatrix is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionShape", "Matrix3x2 CompositionShape.TransformMatrix");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 Scale
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionShape.Scale is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionShape", "Vector2 CompositionShape.Scale");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float RotationAngleInDegrees
		{
			get
			{
				throw new global::System.NotImplementedException("The member float CompositionShape.RotationAngleInDegrees is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionShape", "float CompositionShape.RotationAngleInDegrees");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float RotationAngle
		{
			get
			{
				throw new global::System.NotImplementedException("The member float CompositionShape.RotationAngle is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionShape", "float CompositionShape.RotationAngle");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 Offset
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionShape.Offset is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionShape", "Vector2 CompositionShape.Offset");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 CenterPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionShape.CenterPoint is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionShape", "Vector2 CompositionShape.CenterPoint");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionShape.CenterPoint.get
		// Forced skipping of method Windows.UI.Composition.CompositionShape.CenterPoint.set
		// Forced skipping of method Windows.UI.Composition.CompositionShape.Offset.get
		// Forced skipping of method Windows.UI.Composition.CompositionShape.Offset.set
		// Forced skipping of method Windows.UI.Composition.CompositionShape.RotationAngle.get
		// Forced skipping of method Windows.UI.Composition.CompositionShape.RotationAngle.set
		// Forced skipping of method Windows.UI.Composition.CompositionShape.RotationAngleInDegrees.get
		// Forced skipping of method Windows.UI.Composition.CompositionShape.RotationAngleInDegrees.set
		// Forced skipping of method Windows.UI.Composition.CompositionShape.Scale.get
		// Forced skipping of method Windows.UI.Composition.CompositionShape.Scale.set
		// Forced skipping of method Windows.UI.Composition.CompositionShape.TransformMatrix.get
		// Forced skipping of method Windows.UI.Composition.CompositionShape.TransformMatrix.set
	}
}
