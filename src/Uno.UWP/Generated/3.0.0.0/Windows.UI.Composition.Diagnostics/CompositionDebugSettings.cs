#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Diagnostics
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionDebugSettings 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Diagnostics.CompositionDebugHeatMaps HeatMaps
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionDebugHeatMaps CompositionDebugSettings.HeatMaps is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Diagnostics.CompositionDebugSettings.HeatMaps.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Composition.Diagnostics.CompositionDebugSettings TryGetSettings( global::Windows.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member CompositionDebugSettings CompositionDebugSettings.TryGetSettings(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}
