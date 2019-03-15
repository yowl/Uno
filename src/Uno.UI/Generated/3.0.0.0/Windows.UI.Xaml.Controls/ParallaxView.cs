#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ParallaxView : global::Windows.UI.Xaml.FrameworkElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double VerticalSourceStartOffset
		{
			get
			{
				return (double)this.GetValue(VerticalSourceStartOffsetProperty);
			}
			set
			{
				this.SetValue(VerticalSourceStartOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.ParallaxSourceOffsetKind VerticalSourceOffsetKind
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ParallaxSourceOffsetKind)this.GetValue(VerticalSourceOffsetKindProperty);
			}
			set
			{
				this.SetValue(VerticalSourceOffsetKindProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double VerticalSourceEndOffset
		{
			get
			{
				return (double)this.GetValue(VerticalSourceEndOffsetProperty);
			}
			set
			{
				this.SetValue(VerticalSourceEndOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double VerticalShift
		{
			get
			{
				return (double)this.GetValue(VerticalShiftProperty);
			}
			set
			{
				this.SetValue(VerticalShiftProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.UIElement Source
		{
			get
			{
				return (global::Windows.UI.Xaml.UIElement)this.GetValue(SourceProperty);
			}
			set
			{
				this.SetValue(SourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double MaxVerticalShiftRatio
		{
			get
			{
				return (double)this.GetValue(MaxVerticalShiftRatioProperty);
			}
			set
			{
				this.SetValue(MaxVerticalShiftRatioProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double MaxHorizontalShiftRatio
		{
			get
			{
				return (double)this.GetValue(MaxHorizontalShiftRatioProperty);
			}
			set
			{
				this.SetValue(MaxHorizontalShiftRatioProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsVerticalShiftClamped
		{
			get
			{
				return (bool)this.GetValue(IsVerticalShiftClampedProperty);
			}
			set
			{
				this.SetValue(IsVerticalShiftClampedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsHorizontalShiftClamped
		{
			get
			{
				return (bool)this.GetValue(IsHorizontalShiftClampedProperty);
			}
			set
			{
				this.SetValue(IsHorizontalShiftClampedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double HorizontalSourceStartOffset
		{
			get
			{
				return (double)this.GetValue(HorizontalSourceStartOffsetProperty);
			}
			set
			{
				this.SetValue(HorizontalSourceStartOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.ParallaxSourceOffsetKind HorizontalSourceOffsetKind
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ParallaxSourceOffsetKind)this.GetValue(HorizontalSourceOffsetKindProperty);
			}
			set
			{
				this.SetValue(HorizontalSourceOffsetKindProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double HorizontalSourceEndOffset
		{
			get
			{
				return (double)this.GetValue(HorizontalSourceEndOffsetProperty);
			}
			set
			{
				this.SetValue(HorizontalSourceEndOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double HorizontalShift
		{
			get
			{
				return (double)this.GetValue(HorizontalShiftProperty);
			}
			set
			{
				this.SetValue(HorizontalShiftProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.UIElement Child
		{
			get
			{
				return (global::Windows.UI.Xaml.UIElement)this.GetValue(ChildProperty);
			}
			set
			{
				this.SetValue(ChildProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ChildProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Child", typeof(global::Windows.UI.Xaml.UIElement), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HorizontalShiftProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HorizontalShift", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HorizontalSourceEndOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HorizontalSourceEndOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HorizontalSourceOffsetKindProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HorizontalSourceOffsetKind", typeof(global::Windows.UI.Xaml.Controls.ParallaxSourceOffsetKind), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.ParallaxSourceOffsetKind)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HorizontalSourceStartOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HorizontalSourceStartOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsHorizontalShiftClampedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsHorizontalShiftClamped", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsVerticalShiftClampedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsVerticalShiftClamped", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MaxHorizontalShiftRatioProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MaxHorizontalShiftRatio", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MaxVerticalShiftRatioProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MaxVerticalShiftRatio", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Source", typeof(global::Windows.UI.Xaml.UIElement), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty VerticalShiftProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"VerticalShift", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty VerticalSourceEndOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"VerticalSourceEndOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty VerticalSourceOffsetKindProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"VerticalSourceOffsetKind", typeof(global::Windows.UI.Xaml.Controls.ParallaxSourceOffsetKind), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.ParallaxSourceOffsetKind)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty VerticalSourceStartOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"VerticalSourceStartOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.ParallaxView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ParallaxView() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ParallaxView", "ParallaxView.ParallaxView()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.ParallaxView()
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.Child.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.Child.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalShift.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalShift.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalSourceEndOffset.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalSourceEndOffset.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalSourceOffsetKind.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalSourceOffsetKind.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalSourceStartOffset.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalSourceStartOffset.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.IsHorizontalShiftClamped.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.IsHorizontalShiftClamped.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.IsVerticalShiftClamped.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.IsVerticalShiftClamped.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.MaxHorizontalShiftRatio.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.MaxHorizontalShiftRatio.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.MaxVerticalShiftRatio.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.MaxVerticalShiftRatio.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.Source.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.Source.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalShift.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalShift.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalSourceEndOffset.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalSourceEndOffset.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalSourceOffsetKind.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalSourceOffsetKind.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalSourceStartOffset.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalSourceStartOffset.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void RefreshAutomaticHorizontalOffsets()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ParallaxView", "void ParallaxView.RefreshAutomaticHorizontalOffsets()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void RefreshAutomaticVerticalOffsets()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ParallaxView", "void ParallaxView.RefreshAutomaticVerticalOffsets()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.ChildProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalSourceEndOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalSourceOffsetKindProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalSourceStartOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.MaxHorizontalShiftRatioProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.HorizontalShiftProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.IsHorizontalShiftClampedProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.IsVerticalShiftClampedProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.SourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalSourceEndOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalSourceOffsetKindProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalSourceStartOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.MaxVerticalShiftRatioProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ParallaxView.VerticalShiftProperty.get
	}
}
