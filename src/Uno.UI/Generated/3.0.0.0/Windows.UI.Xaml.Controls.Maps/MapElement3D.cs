#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapElement3D : global::Windows.UI.Xaml.Controls.Maps.MapElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 Scale
		{
			get
			{
				return (global::System.Numerics.Vector3)this.GetValue(ScaleProperty);
			}
			set
			{
				this.SetValue(ScaleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double Roll
		{
			get
			{
				return (double)this.GetValue(RollProperty);
			}
			set
			{
				this.SetValue(RollProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double Pitch
		{
			get
			{
				return (double)this.GetValue(PitchProperty);
			}
			set
			{
				this.SetValue(PitchProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Maps.MapModel3D Model
		{
			get
			{
				throw new global::System.NotImplementedException("The member MapModel3D MapElement3D.Model is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElement3D", "MapModel3D MapElement3D.Model");
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
		public  double Heading
		{
			get
			{
				return (double)this.GetValue(HeadingProperty);
			}
			set
			{
				this.SetValue(HeadingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HeadingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Heading", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty LocationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Location", typeof(global::Windows.Devices.Geolocation.Geopoint), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement3D), 
			new FrameworkPropertyMetadata(default(global::Windows.Devices.Geolocation.Geopoint)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PitchProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Pitch", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty RollProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Roll", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ScaleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Scale", typeof(global::System.Numerics.Vector3), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement3D), 
			new FrameworkPropertyMetadata(default(global::System.Numerics.Vector3)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapElement3D() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElement3D", "MapElement3D.MapElement3D()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.MapElement3D()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Location.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Location.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Model.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Model.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Heading.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Heading.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Pitch.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Pitch.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Roll.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Roll.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Scale.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.Scale.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.LocationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.HeadingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.PitchProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.RollProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement3D.ScaleProperty.get
	}
}
