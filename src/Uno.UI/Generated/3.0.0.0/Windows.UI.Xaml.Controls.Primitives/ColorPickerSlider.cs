#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ColorPickerSlider : global::Windows.UI.Xaml.Controls.Slider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.ColorPickerHsvChannel ColorChannel
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ColorPickerHsvChannel)this.GetValue(ColorChannelProperty);
			}
			set
			{
				this.SetValue(ColorChannelProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ColorChannelProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ColorChannel", typeof(global::Windows.UI.Xaml.Controls.ColorPickerHsvChannel), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.ColorPickerSlider), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.ColorPickerHsvChannel)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ColorPickerSlider() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Primitives.ColorPickerSlider", "ColorPickerSlider.ColorPickerSlider()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorPickerSlider.ColorPickerSlider()
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorPickerSlider.ColorChannel.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorPickerSlider.ColorChannel.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorPickerSlider.ColorChannelProperty.get
	}
}
