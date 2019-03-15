#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapBillboard : global::Windows.UI.Xaml.Controls.Maps.MapElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point NormalizedAnchorPoint
		{
			get
			{
				return (global::Windows.Foundation.Point)this.GetValue(NormalizedAnchorPointProperty);
			}
			set
			{
				this.SetValue(NormalizedAnchorPointProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Geolocation.Geopoint Location
		{
			get
			{
				return (global::Windows.Devices.Geolocation.Geopoint)this.GetValue(LocationProperty);
			}
			set
			{
				this.SetValue(LocationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Storage.Streams.IRandomAccessStreamReference Image
		{
			get
			{
				throw new global::System.NotImplementedException("The member IRandomAccessStreamReference MapBillboard.Image is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapBillboard", "IRandomAccessStreamReference MapBillboard.Image");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Maps.MapElementCollisionBehavior CollisionBehaviorDesired
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Maps.MapElementCollisionBehavior)this.GetValue(CollisionBehaviorDesiredProperty);
			}
			set
			{
				this.SetValue(CollisionBehaviorDesiredProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Maps.MapCamera ReferenceCamera
		{
			get
			{
				throw new global::System.NotImplementedException("The member MapCamera MapBillboard.ReferenceCamera is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CollisionBehaviorDesiredProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CollisionBehaviorDesired", typeof(global::Windows.UI.Xaml.Controls.Maps.MapElementCollisionBehavior), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapBillboard), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.Maps.MapElementCollisionBehavior)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty LocationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Location", typeof(global::Windows.Devices.Geolocation.Geopoint), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapBillboard), 
			new FrameworkPropertyMetadata(default(global::Windows.Devices.Geolocation.Geopoint)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty NormalizedAnchorPointProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"NormalizedAnchorPoint", typeof(global::Windows.Foundation.Point), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapBillboard), 
			new FrameworkPropertyMetadata(default(global::Windows.Foundation.Point)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapBillboard( global::Windows.UI.Xaml.Controls.Maps.MapCamera camera) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapBillboard", "MapBillboard.MapBillboard(MapCamera camera)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.MapBillboard(Windows.UI.Xaml.Controls.Maps.MapCamera)
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.Location.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.Location.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.NormalizedAnchorPoint.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.NormalizedAnchorPoint.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.Image.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.Image.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.CollisionBehaviorDesired.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.CollisionBehaviorDesired.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.ReferenceCamera.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.LocationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.NormalizedAnchorPointProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapBillboard.CollisionBehaviorDesiredProperty.get
	}
}
