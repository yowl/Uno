#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Shapes
{
	#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Polyline : global::Windows.UI.Xaml.Shapes.Shape
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.PointCollection Points
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.PointCollection)this.GetValue(PointsProperty);
			}
			set
			{
				this.SetValue(PointsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.FillRule FillRule
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.FillRule)this.GetValue(FillRuleProperty);
			}
			set
			{
				this.SetValue(FillRuleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FillRuleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"FillRule", typeof(global::Windows.UI.Xaml.Media.FillRule), 
			typeof(global::Windows.UI.Xaml.Shapes.Polyline), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.FillRule)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PointsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Points", typeof(global::Windows.UI.Xaml.Media.PointCollection), 
			typeof(global::Windows.UI.Xaml.Shapes.Polyline), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.PointCollection)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		public Polyline() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Shapes.Polyline", "Polyline.Polyline()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Shapes.Polyline.Polyline()
		// Forced skipping of method Windows.UI.Xaml.Shapes.Polyline.FillRule.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Polyline.FillRule.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Polyline.Points.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Polyline.Points.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Polyline.FillRuleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Polyline.PointsProperty.get
	}
}
