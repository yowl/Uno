#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapElementsLayerPointerEnteredEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Geolocation.Geopoint Location
		{
			get
			{
				throw new global::System.NotImplementedException("The member Geopoint MapElementsLayerPointerEnteredEventArgs.Location is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Maps.MapElement MapElement
		{
			get
			{
				throw new global::System.NotImplementedException("The member MapElement MapElementsLayerPointerEnteredEventArgs.MapElement is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point Position
		{
			get
			{
				throw new global::System.NotImplementedException("The member Point MapElementsLayerPointerEnteredEventArgs.Position is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapElementsLayerPointerEnteredEventArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElementsLayerPointerEnteredEventArgs", "MapElementsLayerPointerEnteredEventArgs.MapElementsLayerPointerEnteredEventArgs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayerPointerEnteredEventArgs.MapElementsLayerPointerEnteredEventArgs()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayerPointerEnteredEventArgs.Position.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayerPointerEnteredEventArgs.Location.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayerPointerEnteredEventArgs.MapElement.get
	}
}
