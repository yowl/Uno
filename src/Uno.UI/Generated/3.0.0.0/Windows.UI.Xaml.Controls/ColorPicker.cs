#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ColorPicker : global::Windows.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Color? PreviousColor
		{
			get
			{
				return (global::Windows.UI.Color?)this.GetValue(PreviousColorProperty);
			}
			set
			{
				this.SetValue(PreviousColorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int MinValue
		{
			get
			{
				return (int)this.GetValue(MinValueProperty);
			}
			set
			{
				this.SetValue(MinValueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int MinSaturation
		{
			get
			{
				return (int)this.GetValue(MinSaturationProperty);
			}
			set
			{
				this.SetValue(MinSaturationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int MinHue
		{
			get
			{
				return (int)this.GetValue(MinHueProperty);
			}
			set
			{
				this.SetValue(MinHueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int MaxValue
		{
			get
			{
				return (int)this.GetValue(MaxValueProperty);
			}
			set
			{
				this.SetValue(MaxValueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int MaxSaturation
		{
			get
			{
				return (int)this.GetValue(MaxSaturationProperty);
			}
			set
			{
				this.SetValue(MaxSaturationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int MaxHue
		{
			get
			{
				return (int)this.GetValue(MaxHueProperty);
			}
			set
			{
				this.SetValue(MaxHueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsMoreButtonVisible
		{
			get
			{
				return (bool)this.GetValue(IsMoreButtonVisibleProperty);
			}
			set
			{
				this.SetValue(IsMoreButtonVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsHexInputVisible
		{
			get
			{
				return (bool)this.GetValue(IsHexInputVisibleProperty);
			}
			set
			{
				this.SetValue(IsHexInputVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsColorSpectrumVisible
		{
			get
			{
				return (bool)this.GetValue(IsColorSpectrumVisibleProperty);
			}
			set
			{
				this.SetValue(IsColorSpectrumVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsColorSliderVisible
		{
			get
			{
				return (bool)this.GetValue(IsColorSliderVisibleProperty);
			}
			set
			{
				this.SetValue(IsColorSliderVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsColorPreviewVisible
		{
			get
			{
				return (bool)this.GetValue(IsColorPreviewVisibleProperty);
			}
			set
			{
				this.SetValue(IsColorPreviewVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsColorChannelTextInputVisible
		{
			get
			{
				return (bool)this.GetValue(IsColorChannelTextInputVisibleProperty);
			}
			set
			{
				this.SetValue(IsColorChannelTextInputVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsAlphaTextInputVisible
		{
			get
			{
				return (bool)this.GetValue(IsAlphaTextInputVisibleProperty);
			}
			set
			{
				this.SetValue(IsAlphaTextInputVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsAlphaSliderVisible
		{
			get
			{
				return (bool)this.GetValue(IsAlphaSliderVisibleProperty);
			}
			set
			{
				this.SetValue(IsAlphaSliderVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsAlphaEnabled
		{
			get
			{
				return (bool)this.GetValue(IsAlphaEnabledProperty);
			}
			set
			{
				this.SetValue(IsAlphaEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.ColorSpectrumShape ColorSpectrumShape
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ColorSpectrumShape)this.GetValue(ColorSpectrumShapeProperty);
			}
			set
			{
				this.SetValue(ColorSpectrumShapeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.ColorSpectrumComponents ColorSpectrumComponents
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ColorSpectrumComponents)this.GetValue(ColorSpectrumComponentsProperty);
			}
			set
			{
				this.SetValue(ColorSpectrumComponentsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Color Color
		{
			get
			{
				return (global::Windows.UI.Color)this.GetValue(ColorProperty);
			}
			set
			{
				this.SetValue(ColorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ColorProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Color", typeof(global::Windows.UI.Color), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Color)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ColorSpectrumComponentsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ColorSpectrumComponents", typeof(global::Windows.UI.Xaml.Controls.ColorSpectrumComponents), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.ColorSpectrumComponents)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ColorSpectrumShapeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ColorSpectrumShape", typeof(global::Windows.UI.Xaml.Controls.ColorSpectrumShape), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.ColorSpectrumShape)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsAlphaEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsAlphaEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsAlphaSliderVisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsAlphaSliderVisible", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsAlphaTextInputVisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsAlphaTextInputVisible", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsColorChannelTextInputVisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsColorChannelTextInputVisible", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsColorPreviewVisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsColorPreviewVisible", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsColorSliderVisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsColorSliderVisible", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsColorSpectrumVisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsColorSpectrumVisible", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsHexInputVisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsHexInputVisible", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsMoreButtonVisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsMoreButtonVisible", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MaxHueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MaxHue", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MaxSaturationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MaxSaturation", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MaxValueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MaxValue", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MinHueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MinHue", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MinSaturationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MinSaturation", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MinValueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MinValue", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PreviousColorProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PreviousColor", typeof(global::Windows.UI.Color?), 
			typeof(global::Windows.UI.Xaml.Controls.ColorPicker), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Color?)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ColorPicker() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ColorPicker", "ColorPicker.ColorPicker()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.ColorPicker()
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.Color.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.Color.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.PreviousColor.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.PreviousColor.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsAlphaEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsAlphaEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorSpectrumVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorSpectrumVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorPreviewVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorPreviewVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorSliderVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorSliderVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsAlphaSliderVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsAlphaSliderVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsMoreButtonVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsMoreButtonVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorChannelTextInputVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorChannelTextInputVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsAlphaTextInputVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsAlphaTextInputVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsHexInputVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsHexInputVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MinHue.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MinHue.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MaxHue.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MaxHue.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MinSaturation.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MinSaturation.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MaxSaturation.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MaxSaturation.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MinValue.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MinValue.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MaxValue.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MaxValue.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.ColorSpectrumShape.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.ColorSpectrumShape.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.ColorSpectrumComponents.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.ColorSpectrumComponents.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.ColorChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.ColorChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.ColorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.PreviousColorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsAlphaEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorSpectrumVisibleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorPreviewVisibleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorSliderVisibleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsAlphaSliderVisibleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsMoreButtonVisibleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsColorChannelTextInputVisibleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsAlphaTextInputVisibleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.IsHexInputVisibleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MinHueProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MaxHueProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MinSaturationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MaxSaturationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MinValueProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.MaxValueProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.ColorSpectrumShapeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorPicker.ColorSpectrumComponentsProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.ColorPicker, global::Windows.UI.Xaml.Controls.ColorChangedEventArgs> ColorChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ColorPicker", "event TypedEventHandler<ColorPicker, ColorChangedEventArgs> ColorPicker.ColorChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ColorPicker", "event TypedEventHandler<ColorPicker, ColorChangedEventArgs> ColorPicker.ColorChanged");
			}
		}
		#endif
	}
}
