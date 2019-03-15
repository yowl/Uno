#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AcrylicBrush : global::Windows.UI.Xaml.Media.XamlCompositionBrushBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan TintTransitionDuration
		{
			get
			{
				return (global::System.TimeSpan)this.GetValue(TintTransitionDurationProperty);
			}
			set
			{
				this.SetValue(TintTransitionDurationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double TintOpacity
		{
			get
			{
				return (double)this.GetValue(TintOpacityProperty);
			}
			set
			{
				this.SetValue(TintOpacityProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Color TintColor
		{
			get
			{
				return (global::Windows.UI.Color)this.GetValue(TintColorProperty);
			}
			set
			{
				this.SetValue(TintColorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.AcrylicBackgroundSource BackgroundSource
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.AcrylicBackgroundSource)this.GetValue(BackgroundSourceProperty);
			}
			set
			{
				this.SetValue(BackgroundSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AlwaysUseFallback
		{
			get
			{
				return (bool)this.GetValue(AlwaysUseFallbackProperty);
			}
			set
			{
				this.SetValue(AlwaysUseFallbackProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AlwaysUseFallbackProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AlwaysUseFallback", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Media.AcrylicBrush), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty BackgroundSourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"BackgroundSource", typeof(global::Windows.UI.Xaml.Media.AcrylicBackgroundSource), 
			typeof(global::Windows.UI.Xaml.Media.AcrylicBrush), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.AcrylicBackgroundSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TintColorProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TintColor", typeof(global::Windows.UI.Color), 
			typeof(global::Windows.UI.Xaml.Media.AcrylicBrush), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Color)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TintOpacityProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TintOpacity", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.AcrylicBrush), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TintTransitionDurationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TintTransitionDuration", typeof(global::System.TimeSpan), 
			typeof(global::Windows.UI.Xaml.Media.AcrylicBrush), 
			new FrameworkPropertyMetadata(default(global::System.TimeSpan)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public AcrylicBrush() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.AcrylicBrush", "AcrylicBrush.AcrylicBrush()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.AcrylicBrush()
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.BackgroundSource.get
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.BackgroundSource.set
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.TintColor.get
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.TintColor.set
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.TintOpacity.get
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.TintOpacity.set
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.TintTransitionDuration.get
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.TintTransitionDuration.set
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.AlwaysUseFallback.get
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.AlwaysUseFallback.set
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.BackgroundSourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.TintColorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.TintOpacityProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.TintTransitionDurationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.AcrylicBrush.AlwaysUseFallbackProperty.get
	}
}
