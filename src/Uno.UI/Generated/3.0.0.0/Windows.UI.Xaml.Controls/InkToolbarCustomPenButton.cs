#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarCustomPenButton : global::Windows.UI.Xaml.Controls.InkToolbarPenButton
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.InkToolbarCustomPen CustomPen
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.InkToolbarCustomPen)this.GetValue(CustomPenProperty);
			}
			set
			{
				this.SetValue(CustomPenProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.UIElement ConfigurationContent
		{
			get
			{
				return (global::Windows.UI.Xaml.UIElement)this.GetValue(ConfigurationContentProperty);
			}
			set
			{
				this.SetValue(ConfigurationContentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ConfigurationContentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ConfigurationContent", typeof(global::Windows.UI.Xaml.UIElement), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CustomPenProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CustomPen", typeof(global::Windows.UI.Xaml.Controls.InkToolbarCustomPen), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.InkToolbarCustomPen)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public InkToolbarCustomPenButton() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarCustomPenButton", "InkToolbarCustomPenButton.InkToolbarCustomPenButton()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.InkToolbarCustomPenButton()
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.CustomPen.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.CustomPen.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.ConfigurationContent.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.ConfigurationContent.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.CustomPenProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.ConfigurationContentProperty.get
	}
}
