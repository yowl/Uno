#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Documents
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TextHighlighter 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Brush Foreground
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(ForegroundProperty);
			}
			set
			{
				this.SetValue(ForegroundProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Brush Background
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(BackgroundProperty);
			}
			set
			{
				this.SetValue(BackgroundProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Documents.TextRange> Ranges
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<TextRange> TextHighlighter.Ranges is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty BackgroundProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Background", typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Documents.TextHighlighter), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ForegroundProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Foreground", typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Documents.TextHighlighter), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TextHighlighter() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.TextHighlighter", "TextHighlighter.TextHighlighter()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Documents.TextHighlighter.TextHighlighter()
		// Forced skipping of method Windows.UI.Xaml.Documents.TextHighlighter.Ranges.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextHighlighter.Foreground.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextHighlighter.Foreground.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextHighlighter.Background.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextHighlighter.Background.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextHighlighter.ForegroundProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextHighlighter.BackgroundProperty.get
	}
}
