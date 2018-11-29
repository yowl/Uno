using System;
using System.Collections.Generic;

namespace Windows.UI.Xaml.Controls
{
	public partial class NavigationView : ContentControl
	{
		public object SelectedItem
		{
			get => (object)GetValue(SelectedItemProperty);
			set => SetValue(SelectedItemProperty, value);
		}

		public Style PaneToggleButtonStyle
		{
			get => (Style)GetValue(PaneToggleButtonStyleProperty);
			set => SetValue(PaneToggleButtonStyleProperty, value);
		}

		public UIElement PaneFooter
		{
			get => (UIElement)GetValue(PaneFooterProperty);
			set => SetValue(PaneFooterProperty, value);
		}

		public double OpenPaneLength
		{
			get => (double)GetValue(OpenPaneLengthProperty);
			set => SetValue(OpenPaneLengthProperty, value);
		}

		public object MenuItemsSource
		{
			get => (object)GetValue(MenuItemsSourceProperty);
			set => SetValue(MenuItemsSourceProperty, value);
		}

		public DataTemplateSelector MenuItemTemplateSelector
		{
			get => (DataTemplateSelector)GetValue(MenuItemTemplateSelectorProperty);
			set => SetValue(MenuItemTemplateSelectorProperty, value);
		}

		public DataTemplate MenuItemTemplate
		{
			get => (DataTemplate)GetValue(MenuItemTemplateProperty);
			set => SetValue(MenuItemTemplateProperty, value);
		}

		public StyleSelector MenuItemContainerStyleSelector
		{
			get => (StyleSelector)GetValue(MenuItemContainerStyleSelectorProperty);
			set => SetValue(MenuItemContainerStyleSelectorProperty, value);
		}

		public Style MenuItemContainerStyle
		{
			get => (Style)GetValue(MenuItemContainerStyleProperty);
			set => SetValue(MenuItemContainerStyleProperty, value);
		}

		public bool IsSettingsVisible
		{
			get => (bool)GetValue(IsSettingsVisibleProperty);
			set => SetValue(IsSettingsVisibleProperty, value);
		}

		public bool IsPaneToggleButtonVisible
		{
			get => (bool)GetValue(IsPaneToggleButtonVisibleProperty);
			set => SetValue(IsPaneToggleButtonVisibleProperty, value);
		}

		public bool IsPaneOpen
		{
			get => (bool)GetValue(IsPaneOpenProperty);
			set => SetValue(IsPaneOpenProperty, value);
		}

		public DataTemplate HeaderTemplate
		{
			get => (DataTemplate)GetValue(HeaderTemplateProperty);
			set => SetValue(HeaderTemplateProperty, value);
		}

		public object Header
		{
			get => (object)GetValue(HeaderProperty);
			set => SetValue(HeaderProperty, value);
		}

		public double ExpandedModeThresholdWidth
		{
			get => (double)GetValue(ExpandedModeThresholdWidthProperty);
			set => SetValue(ExpandedModeThresholdWidthProperty, value);
		}

		public double CompactPaneLength
		{
			get => (double)GetValue(CompactPaneLengthProperty);
			set => SetValue(CompactPaneLengthProperty, value);
		}

		public double CompactModeThresholdWidth
		{
			get => (double)GetValue(CompactModeThresholdWidthProperty);
			set => SetValue(CompactModeThresholdWidthProperty, value);
		}

		public AutoSuggestBox AutoSuggestBox
		{
			get => (AutoSuggestBox)GetValue(AutoSuggestBoxProperty);
			set => SetValue(AutoSuggestBoxProperty, value);
		}

		[Uno.NotImplemented]
		public bool AlwaysShowHeader
		{
			get => (bool)GetValue(AlwaysShowHeaderProperty);
			set => SetValue(AlwaysShowHeaderProperty, value);
		}

		public NavigationViewDisplayMode DisplayMode
		{
			get
			{
				return (NavigationViewDisplayMode)GetValue(DisplayModeProperty);
			}
			internal set
			{
				SetValue(DisplayModeProperty, value);
			}
		}

		public IList<object> MenuItems => (IList<object>)GetValue(MenuItemsProperty);

		public object SettingsItem => (object)GetValue(SettingsItemProperty);

		public string PaneTitle
		{
			get => (string)GetValue(PaneTitleProperty);
			set => SetValue(PaneTitleProperty, value);
		}

		public bool IsBackEnabled
		{
			get => (bool)GetValue(IsBackEnabledProperty);
			set => SetValue(IsBackEnabledProperty, value);
		}

		public NavigationViewBackButtonVisible IsBackButtonVisible
		{
			get => (NavigationViewBackButtonVisible)GetValue(IsBackButtonVisibleProperty);
			set => SetValue(IsBackButtonVisibleProperty, value);
		}

		[global::Uno.NotImplemented]
		public NavigationViewShoulderNavigationEnabled ShoulderNavigationEnabled
		{
			get
			{
				return (NavigationViewShoulderNavigationEnabled)this.GetValue(ShoulderNavigationEnabledProperty);
			}
			set
			{
				this.SetValue(ShoulderNavigationEnabledProperty, value);
			}
		}

		[global::Uno.NotImplemented]
		public NavigationViewSelectionFollowsFocus SelectionFollowsFocus
		{
			get
			{
				return (NavigationViewSelectionFollowsFocus)this.GetValue(SelectionFollowsFocusProperty);
			}
			set
			{
				this.SetValue(SelectionFollowsFocusProperty, value);
			}
		}

		public UIElement PaneHeader
		{
			get
			{
				return (UIElement)this.GetValue(PaneHeaderProperty);
			}
			set
			{
				this.SetValue(PaneHeaderProperty, value);
			}
		}

		public NavigationViewPaneDisplayMode PaneDisplayMode
		{
			get
			{
				return (NavigationViewPaneDisplayMode)this.GetValue(PaneDisplayModeProperty);
			}
			set
			{
				this.SetValue(PaneDisplayModeProperty, value);
			}
		}

		public UIElement PaneCustomContent
		{
			get
			{
				return (UIElement)this.GetValue(PaneCustomContentProperty);
			}
			set
			{
				this.SetValue(PaneCustomContentProperty, value);
			}
		}

		[global::Uno.NotImplemented]
		public NavigationViewOverflowLabelMode OverflowLabelMode
		{
			get
			{
				return (NavigationViewOverflowLabelMode)this.GetValue(OverflowLabelModeProperty);
			}
			set
			{
				this.SetValue(OverflowLabelModeProperty, value);
			}
		}

		public bool IsPaneVisible
		{
			get
			{
				return (bool)this.GetValue(IsPaneVisibleProperty);
			}
			set
			{
				this.SetValue(IsPaneVisibleProperty, value);
			}
		}

		public UIElement ContentOverlay
		{
			get
			{
				return (UIElement)this.GetValue(ContentOverlayProperty);
			}
			set
			{
				this.SetValue(ContentOverlayProperty, value);
			}
		}

		public NavigationViewTemplateSettings TemplateSettings
		{
			get
			{
				return (NavigationViewTemplateSettings)this.GetValue(TemplateSettingsProperty);
			}
		}

		public static DependencyProperty IsPaneVisibleProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsPaneVisible", typeof(bool),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(bool)));

		[global::Uno.NotImplemented]
		public static DependencyProperty OverflowLabelModeProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"OverflowLabelMode", typeof(NavigationViewOverflowLabelMode),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(NavigationViewOverflowLabelMode)));

		public static DependencyProperty PaneCustomContentProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"PaneCustomContent", typeof(UIElement),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(UIElement)));

		public static DependencyProperty PaneDisplayModeProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(PaneDisplayMode),
			typeof(NavigationViewPaneDisplayMode),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(
				NavigationViewPaneDisplayMode.Auto,
				propertyChangedCallback: (s, e) => (s as NavigationView)?.OnPaneDisplayModeChanged((NavigationViewPaneDisplayMode)e.OldValue, (NavigationViewPaneDisplayMode)e.NewValue)
			)
		);

		public static DependencyProperty PaneHeaderProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"PaneHeader", typeof(UIElement),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(UIElement)));

		[global::Uno.NotImplemented]
		public static DependencyProperty SelectionFollowsFocusProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"SelectionFollowsFocus", typeof(NavigationViewSelectionFollowsFocus),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(NavigationViewSelectionFollowsFocus)));

		[global::Uno.NotImplemented]
		public static DependencyProperty ShoulderNavigationEnabledProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"ShoulderNavigationEnabled", typeof(NavigationViewShoulderNavigationEnabled),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(NavigationViewShoulderNavigationEnabled)));

		public static DependencyProperty TemplateSettingsProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"TemplateSettings", typeof(NavigationViewTemplateSettings),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(NavigationViewTemplateSettings)));

		public static DependencyProperty ContentOverlayProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"ContentOverlay", typeof(UIElement),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(UIElement)));

		[Uno.NotImplemented]
		public static DependencyProperty AlwaysShowHeaderProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"AlwaysShowHeader", typeof(bool),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(bool)));

		public static DependencyProperty AutoSuggestBoxProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"AutoSuggestBox", typeof(AutoSuggestBox),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(AutoSuggestBox)));

		public static DependencyProperty CompactModeThresholdWidthProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			name: nameof(CompactModeThresholdWidth),
			propertyType: typeof(double),
			ownerType: typeof(NavigationView),
			typeMetadata: new FrameworkPropertyMetadata(defaultValue: 641.0)
		);

		public static DependencyProperty CompactPaneLengthProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			name: nameof(CompactPaneLength),
			propertyType: typeof(double),
			ownerType: typeof(NavigationView),
			typeMetadata: new FrameworkPropertyMetadata(defaultValue: 48.0)
		);

		public static DependencyProperty DisplayModeProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			name: nameof(DisplayMode),
			propertyType: typeof(NavigationViewDisplayMode),
			ownerType: typeof(NavigationView),
			typeMetadata: new FrameworkPropertyMetadata(
				NavigationViewDisplayMode.Expanded,
				(s, e) => (s as NavigationView)?.OnDisplayModeChanged()
			)
		);

		public static DependencyProperty ExpandedModeThresholdWidthProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			name: nameof(ExpandedModeThresholdWidth),
			propertyType: typeof(double),
			ownerType: typeof(NavigationView),
			typeMetadata: new FrameworkPropertyMetadata(1008.0)
		);

		public static DependencyProperty HeaderProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"Header", typeof(object),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(object)));

		public static DependencyProperty HeaderTemplateProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"HeaderTemplate", typeof(DataTemplate),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(DataTemplate)));

		public static DependencyProperty IsPaneOpenProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsPaneOpen", typeof(bool),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(true, (s, e) => (s as NavigationView)?.OnIsPaneOpenChanged()));

		public static DependencyProperty IsPaneToggleButtonVisibleProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsPaneToggleButtonVisible", typeof(bool),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(true, (s, e) => (s as NavigationView)?.OnPaneToggleButtonVisibleChanged()));

		public static DependencyProperty IsSettingsVisibleProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			name: "IsSettingsVisible",
			propertyType: typeof(bool),
			ownerType: typeof(NavigationView),
			typeMetadata: new FrameworkPropertyMetadata(
				defaultValue: true,
				propertyChangedCallback: (s, e) => (s as NavigationView)?.OnIsSettingsVisibleChanged()
			)
		);

		public static DependencyProperty MenuItemContainerStyleProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"MenuItemContainerStyle", typeof(Style),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(Style)));

		public static DependencyProperty MenuItemContainerStyleSelectorProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"MenuItemContainerStyleSelector", typeof(StyleSelector),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(StyleSelector)));

		public static DependencyProperty MenuItemTemplateProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"MenuItemTemplate", typeof(DataTemplate),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(DataTemplate)));

		public static DependencyProperty MenuItemTemplateSelectorProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"MenuItemTemplateSelector", typeof(DataTemplateSelector),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(DataTemplateSelector)));

		public static DependencyProperty MenuItemsProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			name: nameof(MenuItems),
			propertyType: typeof(IList<object>),
			ownerType: typeof(NavigationView),
			typeMetadata: new FrameworkPropertyMetadata(null)
		);

		public static DependencyProperty MenuItemsSourceProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MenuItemsSource),
			typeof(object),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(
				null,
				propertyChangedCallback: (s, e) => (s as NavigationView)?.OnMenuItemsSourceChanged(e.OldValue, e.NewValue))
		);

		public static DependencyProperty OpenPaneLengthProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			name: nameof(OpenPaneLength),
			propertyType: typeof(double),
			ownerType: typeof(NavigationView),
			typeMetadata: new FrameworkPropertyMetadata(defaultValue: 320.0)
		);

		public static DependencyProperty PaneFooterProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"PaneFooter", typeof(UIElement),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(UIElement)));

		public static DependencyProperty PaneToggleButtonStyleProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"PaneToggleButtonStyle", typeof(Style),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(null)
		);

		public static DependencyProperty SelectedItemProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			name: nameof(SelectedItem),
			propertyType: typeof(object),
			ownerType: typeof(NavigationView),
			typeMetadata: new FrameworkPropertyMetadata(
				null,
				propertyChangedCallback: (s, e) => (s as NavigationView)?.OnSelectedItemChanged()
			)
		);

		public static DependencyProperty SettingsItemProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"SettingsItem", typeof(object),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(object)));

		public static DependencyProperty IsBackButtonVisibleProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsBackButtonVisible", typeof(NavigationViewBackButtonVisible),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(NavigationViewBackButtonVisible.Auto));

		public static DependencyProperty IsBackEnabledProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsBackEnabled", typeof(bool),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(true));

		public static DependencyProperty PaneTitleProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			"PaneTitle", typeof(string),
			typeof(NavigationView),
			new FrameworkPropertyMetadata(default(string)));
	}
}
