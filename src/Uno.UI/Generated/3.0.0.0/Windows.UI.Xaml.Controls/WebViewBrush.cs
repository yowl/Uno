#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebViewBrush : global::Windows.UI.Xaml.Media.TileBrush
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string SourceName
		{
			get
			{
				return (string)this.GetValue(SourceNameProperty);
			}
			set
			{
				this.SetValue(SourceNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SourceNameProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SourceName", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.WebViewBrush), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public WebViewBrush() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebViewBrush", "WebViewBrush.WebViewBrush()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.WebViewBrush.WebViewBrush()
		// Forced skipping of method Windows.UI.Xaml.Controls.WebViewBrush.SourceName.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebViewBrush.SourceName.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Redraw()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebViewBrush", "void WebViewBrush.Redraw()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetSource( global::Windows.UI.Xaml.Controls.WebView source)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebViewBrush", "void WebViewBrush.SetSource(WebView source)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.WebViewBrush.SourceNameProperty.get
	}
}
