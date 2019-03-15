#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WrapGrid : global::Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.VerticalAlignment VerticalChildrenAlignment
		{
			get
			{
				return (global::Windows.UI.Xaml.VerticalAlignment)this.GetValue(VerticalChildrenAlignmentProperty);
			}
			set
			{
				this.SetValue(VerticalChildrenAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Orientation Orientation
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Orientation)this.GetValue(OrientationProperty);
			}
			set
			{
				this.SetValue(OrientationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int MaximumRowsOrColumns
		{
			get
			{
				return (int)this.GetValue(MaximumRowsOrColumnsProperty);
			}
			set
			{
				this.SetValue(MaximumRowsOrColumnsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ItemWidth
		{
			get
			{
				return (double)this.GetValue(ItemWidthProperty);
			}
			set
			{
				this.SetValue(ItemWidthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ItemHeight
		{
			get
			{
				return (double)this.GetValue(ItemHeightProperty);
			}
			set
			{
				this.SetValue(ItemHeightProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.HorizontalAlignment HorizontalChildrenAlignment
		{
			get
			{
				return (global::Windows.UI.Xaml.HorizontalAlignment)this.GetValue(HorizontalChildrenAlignmentProperty);
			}
			set
			{
				this.SetValue(HorizontalChildrenAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HorizontalChildrenAlignmentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HorizontalChildrenAlignment", typeof(global::Windows.UI.Xaml.HorizontalAlignment), 
			typeof(global::Windows.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.HorizontalAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ItemHeightProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ItemHeight", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ItemWidthProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ItemWidth", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MaximumRowsOrColumnsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MaximumRowsOrColumns", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty OrientationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Orientation", typeof(global::Windows.UI.Xaml.Controls.Orientation), 
			typeof(global::Windows.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.Orientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty VerticalChildrenAlignmentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"VerticalChildrenAlignment", typeof(global::Windows.UI.Xaml.VerticalAlignment), 
			typeof(global::Windows.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.VerticalAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public WrapGrid() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WrapGrid", "WrapGrid.WrapGrid()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.WrapGrid()
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.ItemWidth.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.ItemWidth.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.ItemHeight.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.ItemHeight.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.Orientation.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.Orientation.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.HorizontalChildrenAlignment.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.HorizontalChildrenAlignment.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.VerticalChildrenAlignment.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.VerticalChildrenAlignment.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.MaximumRowsOrColumns.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.MaximumRowsOrColumns.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.ItemWidthProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.ItemHeightProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.OrientationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.HorizontalChildrenAlignmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.VerticalChildrenAlignmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WrapGrid.MaximumRowsOrColumnsProperty.get
	}
}
