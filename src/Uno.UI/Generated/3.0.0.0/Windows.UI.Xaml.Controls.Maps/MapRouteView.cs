#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapRouteView : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Color RouteColor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color MapRouteView.RouteColor is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapRouteView", "Color MapRouteView.RouteColor");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Color OutlineColor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color MapRouteView.OutlineColor is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapRouteView", "Color MapRouteView.OutlineColor");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Services.Maps.MapRoute Route
		{
			get
			{
				throw new global::System.NotImplementedException("The member MapRoute MapRouteView.Route is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapRouteView( global::Windows.Services.Maps.MapRoute route) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapRouteView", "MapRouteView.MapRouteView(MapRoute route)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapRouteView.MapRouteView(Windows.Services.Maps.MapRoute)
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapRouteView.RouteColor.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapRouteView.RouteColor.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapRouteView.OutlineColor.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapRouteView.OutlineColor.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapRouteView.Route.get
	}
}
