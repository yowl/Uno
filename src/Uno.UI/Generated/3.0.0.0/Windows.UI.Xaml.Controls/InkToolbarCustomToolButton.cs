#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarCustomToolButton : global::Windows.UI.Xaml.Controls.InkToolbarToolButton
	{
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
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarCustomToolButton), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public InkToolbarCustomToolButton() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarCustomToolButton", "InkToolbarCustomToolButton.InkToolbarCustomToolButton()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomToolButton.InkToolbarCustomToolButton()
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomToolButton.ConfigurationContent.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomToolButton.ConfigurationContent.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomToolButton.ConfigurationContentProperty.get
	}
}
