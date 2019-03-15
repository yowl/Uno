#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Media3D
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PerspectiveTransform3D : global::Windows.UI.Xaml.Media.Media3D.Transform3D
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double OffsetY
		{
			get
			{
				return (double)this.GetValue(OffsetYProperty);
			}
			set
			{
				this.SetValue(OffsetYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double OffsetX
		{
			get
			{
				return (double)this.GetValue(OffsetXProperty);
			}
			set
			{
				this.SetValue(OffsetXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double Depth
		{
			get
			{
				return (double)this.GetValue(DepthProperty);
			}
			set
			{
				this.SetValue(DepthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DepthProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Depth", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty OffsetXProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"OffsetX", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty OffsetYProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"OffsetY", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public PerspectiveTransform3D() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D", "PerspectiveTransform3D.PerspectiveTransform3D()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D.PerspectiveTransform3D()
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D.Depth.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D.Depth.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D.OffsetX.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D.OffsetX.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D.OffsetY.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D.OffsetY.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D.DepthProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D.OffsetXProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D.OffsetYProperty.get
	}
}
