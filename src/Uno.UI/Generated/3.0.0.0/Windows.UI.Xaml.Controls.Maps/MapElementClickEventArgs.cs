#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapElementClickEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Geolocation.Geopoint Location
		{
			get
			{
				throw new global::System.NotImplementedException("The member Geopoint MapElementClickEventArgs.Location is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.Maps.MapElement> MapElements
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<MapElement> MapElementClickEventArgs.MapElements is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point Position
		{
			get
			{
				throw new global::System.NotImplementedException("The member Point MapElementClickEventArgs.Position is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapElementClickEventArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs", "MapElementClickEventArgs.MapElementClickEventArgs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs.MapElementClickEventArgs()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs.Position.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs.Location.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs.MapElements.get
	}
}
