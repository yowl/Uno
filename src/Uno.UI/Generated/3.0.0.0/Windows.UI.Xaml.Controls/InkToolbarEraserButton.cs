#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarEraserButton : global::Windows.UI.Xaml.Controls.InkToolbarToolButton
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsClearAllVisible
		{
			get
			{
				return (bool)this.GetValue(IsClearAllVisibleProperty);
			}
			set
			{
				this.SetValue(IsClearAllVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsClearAllVisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsClearAllVisible", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarEraserButton), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public InkToolbarEraserButton() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarEraserButton", "InkToolbarEraserButton.InkToolbarEraserButton()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarEraserButton.InkToolbarEraserButton()
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarEraserButton.IsClearAllVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarEraserButton.IsClearAllVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarEraserButton.IsClearAllVisibleProperty.get
	}
}
