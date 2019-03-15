#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Documents
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Block : global::Windows.UI.Xaml.Documents.TextElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.TextAlignment TextAlignment
		{
			get
			{
				return (global::Windows.UI.Xaml.TextAlignment)this.GetValue(TextAlignmentProperty);
			}
			set
			{
				this.SetValue(TextAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Thickness Margin
		{
			get
			{
				return (global::Windows.UI.Xaml.Thickness)this.GetValue(MarginProperty);
			}
			set
			{
				this.SetValue(MarginProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.LineStackingStrategy LineStackingStrategy
		{
			get
			{
				return (global::Windows.UI.Xaml.LineStackingStrategy)this.GetValue(LineStackingStrategyProperty);
			}
			set
			{
				this.SetValue(LineStackingStrategyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double LineHeight
		{
			get
			{
				return (double)this.GetValue(LineHeightProperty);
			}
			set
			{
				this.SetValue(LineHeightProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.TextAlignment HorizontalTextAlignment
		{
			get
			{
				return (global::Windows.UI.Xaml.TextAlignment)this.GetValue(HorizontalTextAlignmentProperty);
			}
			set
			{
				this.SetValue(HorizontalTextAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty LineHeightProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"LineHeight", typeof(double), 
			typeof(global::Windows.UI.Xaml.Documents.Block), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty LineStackingStrategyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"LineStackingStrategy", typeof(global::Windows.UI.Xaml.LineStackingStrategy), 
			typeof(global::Windows.UI.Xaml.Documents.Block), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.LineStackingStrategy)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MarginProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Margin", typeof(global::Windows.UI.Xaml.Thickness), 
			typeof(global::Windows.UI.Xaml.Documents.Block), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Thickness)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TextAlignmentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TextAlignment", typeof(global::Windows.UI.Xaml.TextAlignment), 
			typeof(global::Windows.UI.Xaml.Documents.Block), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.TextAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HorizontalTextAlignmentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HorizontalTextAlignment", typeof(global::Windows.UI.Xaml.TextAlignment), 
			typeof(global::Windows.UI.Xaml.Documents.Block), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.TextAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected Block() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.Block", "Block.Block()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.Block()
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.TextAlignment.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.TextAlignment.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.LineHeight.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.LineHeight.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.LineStackingStrategy.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.LineStackingStrategy.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.Margin.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.Margin.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.HorizontalTextAlignment.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.HorizontalTextAlignment.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.HorizontalTextAlignmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.TextAlignmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.LineHeightProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.LineStackingStrategyProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Block.MarginProperty.get
	}
}
