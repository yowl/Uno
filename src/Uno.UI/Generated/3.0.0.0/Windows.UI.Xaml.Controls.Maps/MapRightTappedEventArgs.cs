#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapRightTappedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Geolocation.Geopoint Location
		{
			get
			{
				throw new global::System.NotImplementedException("The member Geopoint MapRightTappedEventArgs.Location is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point Position
		{
			get
			{
				throw new global::System.NotImplementedException("The member Point MapRightTappedEventArgs.Position is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapRightTappedEventArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapRightTappedEventArgs", "MapRightTappedEventArgs.MapRightTappedEventArgs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapRightTappedEventArgs.MapRightTappedEventArgs()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapRightTappedEventArgs.Position.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapRightTappedEventArgs.Location.get
	}
}
