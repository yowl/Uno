#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	public partial class NavigationViewTemplateSettings : DependencyObject
	{
		public Visibility BackButtonVisibility
		{
			get => (Visibility)GetValue(BackButtonVisibilityProperty);
			internal set => SetValue(BackButtonVisibilityProperty, value);
		}

		public Visibility LeftPaneVisibility
		{
			get => (Visibility)GetValue(LeftPaneVisibilityProperty);
			internal set => SetValue(LeftPaneVisibilityProperty, value);
		}

		public Visibility OverflowButtonVisibility
		{
			get => (Visibility)this.GetValue(OverflowButtonVisibilityProperty);
			internal set => SetValue(OverflowButtonVisibilityProperty, value);
		}

		public Visibility PaneToggleButtonVisibility
		{
			get => (Visibility)this.GetValue(PaneToggleButtonVisibilityProperty);
			internal set => SetValue(PaneToggleButtonVisibilityProperty, value);
		}

		public bool SingleSelectionFollowsFocus
		{
			get => (bool)this.GetValue(SingleSelectionFollowsFocusProperty);
			internal set => SetValue(SingleSelectionFollowsFocusProperty, value);
		}

		public double TopPadding
		{
			get => (double)this.GetValue(TopPaddingProperty);
			internal set => SetValue(TopPaddingProperty, value);
		}

		public Visibility TopPaneVisibility
		{
			get => (Visibility)this.GetValue(TopPaneVisibilityProperty);
			internal set => SetValue(TopPaneVisibilityProperty, value);
		}

		public static DependencyProperty BackButtonVisibilityProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"BackButtonVisibility", typeof(Visibility),
			typeof(Controls.NavigationViewTemplateSettings),
			new FrameworkPropertyMetadata(default(Visibility)));

		public static DependencyProperty LeftPaneVisibilityProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"LeftPaneVisibility", typeof(Visibility),
			typeof(Controls.NavigationViewTemplateSettings),
			new FrameworkPropertyMetadata(default(Visibility)));

		public static DependencyProperty OverflowButtonVisibilityProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"OverflowButtonVisibility", typeof(Visibility),
			typeof(Controls.NavigationViewTemplateSettings),
			new FrameworkPropertyMetadata(default(Visibility)));

		public static DependencyProperty PaneToggleButtonVisibilityProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"PaneToggleButtonVisibility", typeof(Visibility),
			typeof(Controls.NavigationViewTemplateSettings),
			new FrameworkPropertyMetadata(default(Visibility)));

		public static DependencyProperty SingleSelectionFollowsFocusProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"SingleSelectionFollowsFocus", typeof(bool),
			typeof(Controls.NavigationViewTemplateSettings),
			new FrameworkPropertyMetadata(default(bool)));

		public static DependencyProperty TopPaddingProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"TopPadding", typeof(double),
			typeof(Controls.NavigationViewTemplateSettings),
			new FrameworkPropertyMetadata(default(double)));

		public static DependencyProperty TopPaneVisibilityProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"TopPaneVisibility", typeof(Visibility),
			typeof(Controls.NavigationViewTemplateSettings),
			new FrameworkPropertyMetadata(default(Visibility)));
	}
}
