#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DistantLight : global::Windows.UI.Composition.CompositionLight
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 Direction
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 DistantLight.Direction is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.DistantLight", "Vector3 DistantLight.Direction");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Visual CoordinateSpace
		{
			get
			{
				throw new global::System.NotImplementedException("The member Visual DistantLight.CoordinateSpace is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.DistantLight", "Visual DistantLight.CoordinateSpace");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Color Color
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color DistantLight.Color is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.DistantLight", "Color DistantLight.Color");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Intensity
		{
			get
			{
				throw new global::System.NotImplementedException("The member float DistantLight.Intensity is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.DistantLight", "float DistantLight.Intensity");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.DistantLight.Color.get
		// Forced skipping of method Windows.UI.Composition.DistantLight.Color.set
		// Forced skipping of method Windows.UI.Composition.DistantLight.CoordinateSpace.get
		// Forced skipping of method Windows.UI.Composition.DistantLight.CoordinateSpace.set
		// Forced skipping of method Windows.UI.Composition.DistantLight.Direction.get
		// Forced skipping of method Windows.UI.Composition.DistantLight.Direction.set
		// Forced skipping of method Windows.UI.Composition.DistantLight.Intensity.get
		// Forced skipping of method Windows.UI.Composition.DistantLight.Intensity.set
	}
}
