#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Documents
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Glyphs : global::Windows.UI.Xaml.FrameworkElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string UnicodeString
		{
			get
			{
				return (string)this.GetValue(UnicodeStringProperty);
			}
			set
			{
				this.SetValue(UnicodeStringProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.StyleSimulations StyleSimulations
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.StyleSimulations)this.GetValue(StyleSimulationsProperty);
			}
			set
			{
				this.SetValue(StyleSimulationsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double OriginY
		{
			get
			{
				return (double)this.GetValue(OriginYProperty);
			}
			set
			{
				this.SetValue(OriginYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double OriginX
		{
			get
			{
				return (double)this.GetValue(OriginXProperty);
			}
			set
			{
				this.SetValue(OriginXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Indices
		{
			get
			{
				return (string)this.GetValue(IndicesProperty);
			}
			set
			{
				this.SetValue(IndicesProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Uri FontUri
		{
			get
			{
				return (global::System.Uri)this.GetValue(FontUriProperty);
			}
			set
			{
				this.SetValue(FontUriProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double FontRenderingEmSize
		{
			get
			{
				return (double)this.GetValue(FontRenderingEmSizeProperty);
			}
			set
			{
				this.SetValue(FontRenderingEmSizeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Brush Fill
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(FillProperty);
			}
			set
			{
				this.SetValue(FillProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsColorFontEnabled
		{
			get
			{
				return (bool)this.GetValue(IsColorFontEnabledProperty);
			}
			set
			{
				this.SetValue(IsColorFontEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int ColorFontPaletteIndex
		{
			get
			{
				return (int)this.GetValue(ColorFontPaletteIndexProperty);
			}
			set
			{
				this.SetValue(ColorFontPaletteIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FillProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Fill", typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FontRenderingEmSizeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"FontRenderingEmSize", typeof(double), 
			typeof(global::Windows.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FontUriProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"FontUri", typeof(global::System.Uri), 
			typeof(global::Windows.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(global::System.Uri)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IndicesProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Indices", typeof(string), 
			typeof(global::Windows.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty OriginXProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"OriginX", typeof(double), 
			typeof(global::Windows.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty OriginYProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"OriginY", typeof(double), 
			typeof(global::Windows.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StyleSimulationsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"StyleSimulations", typeof(global::Windows.UI.Xaml.Media.StyleSimulations), 
			typeof(global::Windows.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.StyleSimulations)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty UnicodeStringProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"UnicodeString", typeof(string), 
			typeof(global::Windows.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ColorFontPaletteIndexProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ColorFontPaletteIndex", typeof(int), 
			typeof(global::Windows.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsColorFontEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsColorFontEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public Glyphs() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.Glyphs", "Glyphs.Glyphs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.Glyphs()
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.UnicodeString.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.UnicodeString.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.Indices.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.Indices.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.FontUri.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.FontUri.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.StyleSimulations.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.StyleSimulations.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.FontRenderingEmSize.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.FontRenderingEmSize.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.OriginX.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.OriginX.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.OriginY.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.OriginY.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.Fill.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.Fill.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.IsColorFontEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.IsColorFontEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.ColorFontPaletteIndex.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.ColorFontPaletteIndex.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.IsColorFontEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.ColorFontPaletteIndexProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.UnicodeStringProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.IndicesProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.FontUriProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.StyleSimulationsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.FontRenderingEmSizeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.OriginXProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.OriginYProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Glyphs.FillProperty.get
	}
}
