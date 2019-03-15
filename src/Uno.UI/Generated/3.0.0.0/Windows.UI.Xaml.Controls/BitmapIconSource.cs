#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BitmapIconSource : global::Windows.UI.Xaml.Controls.IconSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Uri UriSource
		{
			get
			{
				return (global::System.Uri)this.GetValue(UriSourceProperty);
			}
			set
			{
				this.SetValue(UriSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool ShowAsMonochrome
		{
			get
			{
				return (bool)this.GetValue(ShowAsMonochromeProperty);
			}
			set
			{
				this.SetValue(ShowAsMonochromeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ShowAsMonochromeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ShowAsMonochrome", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.BitmapIconSource), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty UriSourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"UriSource", typeof(global::System.Uri), 
			typeof(global::Windows.UI.Xaml.Controls.BitmapIconSource), 
			new FrameworkPropertyMetadata(default(global::System.Uri)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public BitmapIconSource() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.BitmapIconSource", "BitmapIconSource.BitmapIconSource()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.BitmapIconSource.BitmapIconSource()
		// Forced skipping of method Windows.UI.Xaml.Controls.BitmapIconSource.UriSource.get
		// Forced skipping of method Windows.UI.Xaml.Controls.BitmapIconSource.UriSource.set
		// Forced skipping of method Windows.UI.Xaml.Controls.BitmapIconSource.ShowAsMonochrome.get
		// Forced skipping of method Windows.UI.Xaml.Controls.BitmapIconSource.ShowAsMonochrome.set
		// Forced skipping of method Windows.UI.Xaml.Controls.BitmapIconSource.UriSourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.BitmapIconSource.ShowAsMonochromeProperty.get
	}
}
