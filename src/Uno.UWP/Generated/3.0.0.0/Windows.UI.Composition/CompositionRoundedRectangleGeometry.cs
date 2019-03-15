#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionRoundedRectangleGeometry : global::Windows.UI.Composition.CompositionGeometry
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionRoundedRectangleGeometry.Size is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionRoundedRectangleGeometry", "Vector2 CompositionRoundedRectangleGeometry.Size");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 Offset
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionRoundedRectangleGeometry.Offset is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionRoundedRectangleGeometry", "Vector2 CompositionRoundedRectangleGeometry.Offset");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 CornerRadius
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionRoundedRectangleGeometry.CornerRadius is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionRoundedRectangleGeometry", "Vector2 CompositionRoundedRectangleGeometry.CornerRadius");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionRoundedRectangleGeometry.CornerRadius.get
		// Forced skipping of method Windows.UI.Composition.CompositionRoundedRectangleGeometry.CornerRadius.set
		// Forced skipping of method Windows.UI.Composition.CompositionRoundedRectangleGeometry.Offset.get
		// Forced skipping of method Windows.UI.Composition.CompositionRoundedRectangleGeometry.Offset.set
		// Forced skipping of method Windows.UI.Composition.CompositionRoundedRectangleGeometry.Size.get
		// Forced skipping of method Windows.UI.Composition.CompositionRoundedRectangleGeometry.Size.set
	}
}
