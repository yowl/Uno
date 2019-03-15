#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SettingsFlyout : global::Windows.UI.Xaml.Controls.ContentControl
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Title
		{
			get
			{
				return (string)this.GetValue(TitleProperty);
			}
			set
			{
				this.SetValue(TitleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.ImageSource IconSource
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.ImageSource)this.GetValue(IconSourceProperty);
			}
			set
			{
				this.SetValue(IconSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Brush HeaderForeground
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(HeaderForegroundProperty);
			}
			set
			{
				this.SetValue(HeaderForegroundProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Brush HeaderBackground
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(HeaderBackgroundProperty);
			}
			set
			{
				this.SetValue(HeaderBackgroundProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Primitives.SettingsFlyoutTemplateSettings TemplateSettings
		{
			get
			{
				throw new global::System.NotImplementedException("The member SettingsFlyoutTemplateSettings SettingsFlyout.TemplateSettings is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HeaderBackgroundProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HeaderBackground", typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Controls.SettingsFlyout), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HeaderForegroundProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HeaderForeground", typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Controls.SettingsFlyout), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IconSourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IconSource", typeof(global::Windows.UI.Xaml.Media.ImageSource), 
			typeof(global::Windows.UI.Xaml.Controls.SettingsFlyout), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.ImageSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TitleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Title", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.SettingsFlyout), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SettingsFlyout() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SettingsFlyout", "SettingsFlyout.SettingsFlyout()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.SettingsFlyout()
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.Title.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.Title.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.HeaderBackground.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.HeaderBackground.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.HeaderForeground.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.HeaderForeground.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.IconSource.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.IconSource.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.TemplateSettings.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.BackClick.add
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.BackClick.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Show()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SettingsFlyout", "void SettingsFlyout.Show()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ShowIndependent()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SettingsFlyout", "void SettingsFlyout.ShowIndependent()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Hide()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SettingsFlyout", "void SettingsFlyout.Hide()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.TitleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.HeaderBackgroundProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.HeaderForegroundProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SettingsFlyout.IconSourceProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Controls.BackClickEventHandler BackClick
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SettingsFlyout", "event BackClickEventHandler SettingsFlyout.BackClick");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SettingsFlyout", "event BackClickEventHandler SettingsFlyout.BackClick");
			}
		}
		#endif
	}
}
