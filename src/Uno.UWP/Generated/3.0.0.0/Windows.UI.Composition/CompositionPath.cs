#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionPath : global::Windows.Graphics.IGeometrySource2D
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CompositionPath( global::Windows.Graphics.IGeometrySource2D source) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionPath", "CompositionPath.CompositionPath(IGeometrySource2D source)");
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionPath.CompositionPath(Windows.Graphics.IGeometrySource2D)
		// Processing: Windows.Graphics.IGeometrySource2D
	}
}
