#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarPenConfigurationControl : global::Windows.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.InkToolbarPenButton PenButton
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.InkToolbarPenButton)this.GetValue(PenButtonProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PenButtonProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PenButton", typeof(global::Windows.UI.Xaml.Controls.InkToolbarPenButton), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarPenConfigurationControl), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.InkToolbarPenButton)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public InkToolbarPenConfigurationControl() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarPenConfigurationControl", "InkToolbarPenConfigurationControl.InkToolbarPenConfigurationControl()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenConfigurationControl.InkToolbarPenConfigurationControl()
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenConfigurationControl.PenButton.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenConfigurationControl.PenButtonProperty.get
	}
}
