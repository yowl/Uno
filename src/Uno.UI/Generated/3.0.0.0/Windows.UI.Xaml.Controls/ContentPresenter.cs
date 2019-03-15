#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContentPresenter : global::Windows.UI.Xaml.FrameworkElement
	{
		// Skipping already declared property Foreground
		// Skipping already declared property FontWeight
		// Skipping already declared property FontStyle
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Text.FontStretch FontStretch
		{
			get
			{
				return (global::Windows.UI.Text.FontStretch)this.GetValue(FontStretchProperty);
			}
			set
			{
				this.SetValue(FontStretchProperty, value);
			}
		}
		#endif
		// Skipping already declared property FontSize
		// Skipping already declared property FontFamily
		// Skipping already declared property ContentTransitions
		// Skipping already declared property ContentTemplateSelector
		// Skipping already declared property ContentTemplate
		// Skipping already declared property Content
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int CharacterSpacing
		{
			get
			{
				return (int)this.GetValue(CharacterSpacingProperty);
			}
			set
			{
				this.SetValue(CharacterSpacingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.TextLineBounds TextLineBounds
		{
			get
			{
				return (global::Windows.UI.Xaml.TextLineBounds)this.GetValue(TextLineBoundsProperty);
			}
			set
			{
				this.SetValue(TextLineBoundsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.OpticalMarginAlignment OpticalMarginAlignment
		{
			get
			{
				return (global::Windows.UI.Xaml.OpticalMarginAlignment)this.GetValue(OpticalMarginAlignmentProperty);
			}
			set
			{
				this.SetValue(OpticalMarginAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsTextScaleFactorEnabled
		{
			get
			{
				return (bool)this.GetValue(IsTextScaleFactorEnabledProperty);
			}
			set
			{
				this.SetValue(IsTextScaleFactorEnabledProperty, value);
			}
		}
		#endif
		// Skipping already declared property VerticalContentAlignment
		// Skipping already declared property TextWrapping
		// Skipping already declared property Padding
		// Skipping already declared property MaxLines
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
		// Skipping already declared property HorizontalContentAlignment
		// Skipping already declared property CornerRadius
		// Skipping already declared property BorderThickness
		// Skipping already declared property BorderBrush
		// Skipping already declared property Background
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.BrushTransition BackgroundTransition
		{
			get
			{
				throw new global::System.NotImplementedException("The member BrushTransition ContentPresenter.BackgroundTransition is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ContentPresenter", "BrushTransition ContentPresenter.BackgroundTransition");
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
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CharacterSpacingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CharacterSpacing", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.ContentPresenter), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		// Skipping already declared property ContentProperty
		// Skipping already declared property ContentTemplateProperty
		// Skipping already declared property ContentTemplateSelectorProperty
		// Skipping already declared property ContentTransitionsProperty
		// Skipping already declared property FontFamilyProperty
		// Skipping already declared property FontSizeProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FontStretchProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"FontStretch", typeof(global::Windows.UI.Text.FontStretch), 
			typeof(global::Windows.UI.Xaml.Controls.ContentPresenter), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Text.FontStretch)));
		#endif
		// Skipping already declared property FontStyleProperty
		// Skipping already declared property FontWeightProperty
		// Skipping already declared property ForegroundProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty OpticalMarginAlignmentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"OpticalMarginAlignment", typeof(global::Windows.UI.Xaml.OpticalMarginAlignment), 
			typeof(global::Windows.UI.Xaml.Controls.ContentPresenter), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.OpticalMarginAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TextLineBoundsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TextLineBounds", typeof(global::Windows.UI.Xaml.TextLineBounds), 
			typeof(global::Windows.UI.Xaml.Controls.ContentPresenter), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.TextLineBounds)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsTextScaleFactorEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsTextScaleFactorEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ContentPresenter), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property BackgroundProperty
		// Skipping already declared property BorderBrushProperty
		// Skipping already declared property BorderThicknessProperty
		// Skipping already declared property CornerRadiusProperty
		// Skipping already declared property HorizontalContentAlignmentProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty LineHeightProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"LineHeight", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.ContentPresenter), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty LineStackingStrategyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"LineStackingStrategy", typeof(global::Windows.UI.Xaml.LineStackingStrategy), 
			typeof(global::Windows.UI.Xaml.Controls.ContentPresenter), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.LineStackingStrategy)));
		#endif
		// Skipping already declared property MaxLinesProperty
		// Skipping already declared property PaddingProperty
		// Skipping already declared property TextWrappingProperty
		// Skipping already declared property VerticalContentAlignmentProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty BackgroundSizingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"BackgroundSizing", typeof(global::Windows.UI.Xaml.Controls.BackgroundSizing), 
			typeof(global::Windows.UI.Xaml.Controls.ContentPresenter), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.BackgroundSizing)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.ContentPresenter.ContentPresenter()
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ContentPresenter()
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.Content.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.Content.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ContentTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ContentTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ContentTemplateSelector.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ContentTemplateSelector.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ContentTransitions.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ContentTransitions.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontSize.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontSize.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontFamily.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontFamily.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontWeight.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontWeight.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontStyle.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontStyle.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontStretch.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontStretch.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.CharacterSpacing.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.CharacterSpacing.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.Foreground.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.Foreground.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.OpticalMarginAlignment.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.OpticalMarginAlignment.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.TextLineBounds.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.TextLineBounds.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.IsTextScaleFactorEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.IsTextScaleFactorEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.TextWrapping.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.TextWrapping.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.MaxLines.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.MaxLines.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.LineStackingStrategy.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.LineStackingStrategy.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.LineHeight.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.LineHeight.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BorderBrush.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BorderBrush.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BorderThickness.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BorderThickness.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.CornerRadius.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.CornerRadius.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.Padding.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.Padding.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.Background.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.Background.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.HorizontalContentAlignment.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.HorizontalContentAlignment.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.VerticalContentAlignment.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.VerticalContentAlignment.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BackgroundTransition.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BackgroundTransition.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BackgroundSizing.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BackgroundSizing.set
		// Skipping already declared method Windows.UI.Xaml.Controls.ContentPresenter.OnContentTemplateChanged(Windows.UI.Xaml.DataTemplate, Windows.UI.Xaml.DataTemplate)
		// Skipping already declared method Windows.UI.Xaml.Controls.ContentPresenter.OnContentTemplateSelectorChanged(Windows.UI.Xaml.Controls.DataTemplateSelector, Windows.UI.Xaml.Controls.DataTemplateSelector)
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BackgroundSizingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.TextWrappingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.MaxLinesProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.LineStackingStrategyProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.LineHeightProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BorderBrushProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BorderThicknessProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.CornerRadiusProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.PaddingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.BackgroundProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.HorizontalContentAlignmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.VerticalContentAlignmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.IsTextScaleFactorEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.OpticalMarginAlignmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.TextLineBoundsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ContentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ContentTemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ContentTemplateSelectorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ContentTransitionsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontSizeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontFamilyProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontWeightProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontStyleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.FontStretchProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.CharacterSpacingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ContentPresenter.ForegroundProperty.get
	}
}
