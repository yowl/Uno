#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Pivot 
	{
		// Skipping already declared property TitleTemplate
		// Skipping already declared property Title
		// Skipping already declared property SelectedItem
		// Skipping already declared property SelectedIndex
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsLocked
		{
			get
			{
				return (bool)this.GetValue(IsLockedProperty);
			}
			set
			{
				this.SetValue(IsLockedProperty, value);
			}
		}
		#endif
		// Skipping already declared property HeaderTemplate
		// Skipping already declared property RightHeaderTemplate
		// Skipping already declared property RightHeader
		// Skipping already declared property LeftHeaderTemplate
		// Skipping already declared property LeftHeader
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsHeaderItemsCarouselEnabled
		{
			get
			{
				return (bool)this.GetValue(IsHeaderItemsCarouselEnabledProperty);
			}
			set
			{
				this.SetValue(IsHeaderItemsCarouselEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.PivotHeaderFocusVisualPlacement HeaderFocusVisualPlacement
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.PivotHeaderFocusVisualPlacement)this.GetValue(HeaderFocusVisualPlacementProperty);
			}
			set
			{
				this.SetValue(HeaderFocusVisualPlacementProperty, value);
			}
		}
		#endif
		// Skipping already declared property HeaderTemplateProperty
		// Skipping already declared property IsLockedProperty
		// Skipping already declared property SelectedIndexProperty
		// Skipping already declared property SelectedItemProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SlideInAnimationGroupProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"SlideInAnimationGroup", typeof(global::Windows.UI.Xaml.Controls.PivotSlideInAnimationGroup), 
			typeof(global::Windows.UI.Xaml.Controls.Pivot), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.PivotSlideInAnimationGroup)));
		#endif
		// Skipping already declared property TitleProperty
		// Skipping already declared property TitleTemplateProperty
		// Skipping already declared property LeftHeaderProperty
		// Skipping already declared property LeftHeaderTemplateProperty
		// Skipping already declared property RightHeaderProperty
		// Skipping already declared property RightHeaderTemplateProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HeaderFocusVisualPlacementProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HeaderFocusVisualPlacement", typeof(global::Windows.UI.Xaml.Controls.PivotHeaderFocusVisualPlacement), 
			typeof(global::Windows.UI.Xaml.Controls.Pivot), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.PivotHeaderFocusVisualPlacement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsHeaderItemsCarouselEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsHeaderItemsCarouselEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.Pivot), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.Pivot.Pivot()
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.Pivot()
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.Title.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.Title.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.TitleTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.TitleTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.HeaderTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.HeaderTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.SelectedIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.SelectedIndex.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.SelectedItem.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.SelectedItem.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.IsLocked.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.IsLocked.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.SelectionChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.SelectionChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.PivotItemLoading.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.PivotItemLoading.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.PivotItemLoaded.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.PivotItemLoaded.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.PivotItemUnloading.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.PivotItemUnloading.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.PivotItemUnloaded.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.PivotItemUnloaded.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.LeftHeader.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.LeftHeader.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.LeftHeaderTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.LeftHeaderTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.RightHeader.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.RightHeader.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.RightHeaderTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.RightHeaderTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.HeaderFocusVisualPlacement.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.HeaderFocusVisualPlacement.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.IsHeaderItemsCarouselEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.IsHeaderItemsCarouselEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.HeaderFocusVisualPlacementProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.IsHeaderItemsCarouselEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.LeftHeaderProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.LeftHeaderTemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.RightHeaderProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.RightHeaderTemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.TitleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.TitleTemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.HeaderTemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.SelectedIndexProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.SelectedItemProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.IsLockedProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Pivot.SlideInAnimationGroupProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.Controls.PivotSlideInAnimationGroup GetSlideInAnimationGroup( global::Windows.UI.Xaml.FrameworkElement element)
		{
			return (global::Windows.UI.Xaml.Controls.PivotSlideInAnimationGroup)element.GetValue(SlideInAnimationGroupProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetSlideInAnimationGroup( global::Windows.UI.Xaml.FrameworkElement element,  global::Windows.UI.Xaml.Controls.PivotSlideInAnimationGroup value)
		{
			element.SetValue(SlideInAnimationGroupProperty, value);
		}
		#endif
		// Skipping already declared event Windows.UI.Xaml.Controls.Pivot.PivotItemLoaded
		// Skipping already declared event Windows.UI.Xaml.Controls.Pivot.PivotItemLoading
		// Skipping already declared event Windows.UI.Xaml.Controls.Pivot.PivotItemUnloaded
		// Skipping already declared event Windows.UI.Xaml.Controls.Pivot.PivotItemUnloading
		// Skipping already declared event Windows.UI.Xaml.Controls.Pivot.SelectionChanged
	}
}
