#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TreeViewItem : global::Windows.UI.Xaml.Controls.ListViewItem
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsExpanded
		{
			get
			{
				return (bool)this.GetValue(IsExpandedProperty);
			}
			set
			{
				this.SetValue(IsExpandedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double GlyphSize
		{
			get
			{
				return (double)this.GetValue(GlyphSizeProperty);
			}
			set
			{
				this.SetValue(GlyphSizeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double GlyphOpacity
		{
			get
			{
				return (double)this.GetValue(GlyphOpacityProperty);
			}
			set
			{
				this.SetValue(GlyphOpacityProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Brush GlyphBrush
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(GlyphBrushProperty);
			}
			set
			{
				this.SetValue(GlyphBrushProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string ExpandedGlyph
		{
			get
			{
				return (string)this.GetValue(ExpandedGlyphProperty);
			}
			set
			{
				this.SetValue(ExpandedGlyphProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string CollapsedGlyph
		{
			get
			{
				return (string)this.GetValue(CollapsedGlyphProperty);
			}
			set
			{
				this.SetValue(CollapsedGlyphProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.TreeViewItemTemplateSettings TreeViewItemTemplateSettings
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TreeViewItemTemplateSettings)this.GetValue(TreeViewItemTemplateSettingsProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object ItemsSource
		{
			get
			{
				return (object)this.GetValue(ItemsSourceProperty);
			}
			set
			{
				this.SetValue(ItemsSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool HasUnrealizedChildren
		{
			get
			{
				return (bool)this.GetValue(HasUnrealizedChildrenProperty);
			}
			set
			{
				this.SetValue(HasUnrealizedChildrenProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CollapsedGlyphProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CollapsedGlyph", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewItem), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ExpandedGlyphProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ExpandedGlyph", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewItem), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty GlyphBrushProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"GlyphBrush", typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewItem), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty GlyphOpacityProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"GlyphOpacity", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewItem), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty GlyphSizeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"GlyphSize", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewItem), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsExpandedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsExpanded", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewItem), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TreeViewItemTemplateSettingsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TreeViewItemTemplateSettings", typeof(global::Windows.UI.Xaml.Controls.TreeViewItemTemplateSettings), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewItem), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.TreeViewItemTemplateSettings)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HasUnrealizedChildrenProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HasUnrealizedChildren", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewItem), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ItemsSourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ItemsSource", typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewItem), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TreeViewItem() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.TreeViewItem", "TreeViewItem.TreeViewItem()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.TreeViewItem()
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.GlyphOpacity.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.GlyphOpacity.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.GlyphBrush.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.GlyphBrush.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.ExpandedGlyph.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.ExpandedGlyph.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.CollapsedGlyph.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.CollapsedGlyph.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.GlyphSize.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.GlyphSize.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.IsExpanded.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.IsExpanded.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.TreeViewItemTemplateSettings.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.HasUnrealizedChildren.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.HasUnrealizedChildren.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.ItemsSource.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.ItemsSource.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.HasUnrealizedChildrenProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.ItemsSourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.GlyphOpacityProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.GlyphBrushProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.ExpandedGlyphProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.CollapsedGlyphProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.GlyphSizeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.IsExpandedProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItem.TreeViewItemTemplateSettingsProperty.get
	}
}
