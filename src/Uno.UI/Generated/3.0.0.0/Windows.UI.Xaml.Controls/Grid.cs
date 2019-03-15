#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Grid : global::Windows.UI.Xaml.Controls.Panel
	{
		// Skipping already declared property ColumnDefinitions
		// Skipping already declared property RowDefinitions
		// Skipping already declared property Padding
		// Skipping already declared property CornerRadius
		// Skipping already declared property BorderThickness
		// Skipping already declared property BorderBrush
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double RowSpacing
		{
			get
			{
				return (double)this.GetValue(RowSpacingProperty);
			}
			set
			{
				this.SetValue(RowSpacingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ColumnSpacing
		{
			get
			{
				return (double)this.GetValue(ColumnSpacingProperty);
			}
			set
			{
				this.SetValue(ColumnSpacingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.BackgroundSizing BackgroundSizing
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.BackgroundSizing)this.GetValue(BackgroundSizingProperty);
			}
			set
			{
				this.SetValue(BackgroundSizingProperty, value);
			}
		}
		#endif
		// Skipping already declared property ColumnProperty
		// Skipping already declared property ColumnSpanProperty
		// Skipping already declared property RowProperty
		// Skipping already declared property RowSpanProperty
		// Skipping already declared property BorderBrushProperty
		// Skipping already declared property BorderThicknessProperty
		// Skipping already declared property CornerRadiusProperty
		// Skipping already declared property PaddingProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ColumnSpacingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ColumnSpacing", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.Grid), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty RowSpacingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"RowSpacing", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.Grid), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty BackgroundSizingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"BackgroundSizing", typeof(global::Windows.UI.Xaml.Controls.BackgroundSizing), 
			typeof(global::Windows.UI.Xaml.Controls.Grid), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.BackgroundSizing)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.Grid.Grid()
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.Grid()
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.RowDefinitions.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.ColumnDefinitions.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.BorderBrush.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.BorderBrush.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.BorderThickness.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.BorderThickness.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.CornerRadius.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.CornerRadius.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.Padding.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.Padding.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.RowSpacing.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.RowSpacing.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.ColumnSpacing.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.ColumnSpacing.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.BackgroundSizing.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.BackgroundSizing.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.BackgroundSizingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.RowSpacingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.ColumnSpacingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.BorderBrushProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.BorderThicknessProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.CornerRadiusProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.PaddingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.RowProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.GetRow(Windows.UI.Xaml.FrameworkElement)
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.SetRow(Windows.UI.Xaml.FrameworkElement, int)
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.ColumnProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.GetColumn(Windows.UI.Xaml.FrameworkElement)
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.SetColumn(Windows.UI.Xaml.FrameworkElement, int)
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.RowSpanProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.GetRowSpan(Windows.UI.Xaml.FrameworkElement)
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.SetRowSpan(Windows.UI.Xaml.FrameworkElement, int)
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.ColumnSpanProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.GetColumnSpan(Windows.UI.Xaml.FrameworkElement)
		// Forced skipping of method Windows.UI.Xaml.Controls.Grid.SetColumnSpan(Windows.UI.Xaml.FrameworkElement, int)
	}
}
