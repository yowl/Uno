#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Media3D
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositeTransform3D : global::Windows.UI.Xaml.Media.Media3D.Transform3D
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double TranslateZ
		{
			get
			{
				return (double)this.GetValue(TranslateZProperty);
			}
			set
			{
				this.SetValue(TranslateZProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double TranslateY
		{
			get
			{
				return (double)this.GetValue(TranslateYProperty);
			}
			set
			{
				this.SetValue(TranslateYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double TranslateX
		{
			get
			{
				return (double)this.GetValue(TranslateXProperty);
			}
			set
			{
				this.SetValue(TranslateXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ScaleZ
		{
			get
			{
				return (double)this.GetValue(ScaleZProperty);
			}
			set
			{
				this.SetValue(ScaleZProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ScaleY
		{
			get
			{
				return (double)this.GetValue(ScaleYProperty);
			}
			set
			{
				this.SetValue(ScaleYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ScaleX
		{
			get
			{
				return (double)this.GetValue(ScaleXProperty);
			}
			set
			{
				this.SetValue(ScaleXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double RotationZ
		{
			get
			{
				return (double)this.GetValue(RotationZProperty);
			}
			set
			{
				this.SetValue(RotationZProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double RotationY
		{
			get
			{
				return (double)this.GetValue(RotationYProperty);
			}
			set
			{
				this.SetValue(RotationYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double RotationX
		{
			get
			{
				return (double)this.GetValue(RotationXProperty);
			}
			set
			{
				this.SetValue(RotationXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double CenterZ
		{
			get
			{
				return (double)this.GetValue(CenterZProperty);
			}
			set
			{
				this.SetValue(CenterZProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double CenterY
		{
			get
			{
				return (double)this.GetValue(CenterYProperty);
			}
			set
			{
				this.SetValue(CenterYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double CenterX
		{
			get
			{
				return (double)this.GetValue(CenterXProperty);
			}
			set
			{
				this.SetValue(CenterXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CenterXProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CenterX", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CenterYProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CenterY", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CenterZProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CenterZ", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty RotationXProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"RotationX", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty RotationYProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"RotationY", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty RotationZProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"RotationZ", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ScaleXProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ScaleX", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ScaleYProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ScaleY", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ScaleZProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ScaleZ", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TranslateXProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TranslateX", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TranslateYProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TranslateY", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TranslateZProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TranslateZ", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Media3D.CompositeTransform3D), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CompositeTransform3D() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Media3D.CompositeTransform3D", "CompositeTransform3D.CompositeTransform3D()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.CompositeTransform3D()
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.CenterX.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.CenterX.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.CenterY.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.CenterY.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.CenterZ.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.CenterZ.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.RotationX.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.RotationX.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.RotationY.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.RotationY.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.RotationZ.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.RotationZ.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.ScaleX.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.ScaleX.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.ScaleY.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.ScaleY.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.ScaleZ.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.ScaleZ.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.TranslateX.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.TranslateX.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.TranslateY.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.TranslateY.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.TranslateZ.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.TranslateZ.set
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.CenterXProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.CenterYProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.CenterZProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.RotationXProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.RotationYProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.RotationZProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.ScaleXProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.ScaleYProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.ScaleZProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.TranslateXProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.TranslateYProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Media3D.CompositeTransform3D.TranslateZProperty.get
	}
}
