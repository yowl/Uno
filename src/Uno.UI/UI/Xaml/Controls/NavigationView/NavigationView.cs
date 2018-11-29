using System;
using System.Collections.Generic;
using System.Linq;
using Uno.Disposables;
using Uno.Extensions;
using Uno.Logging;
using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml.Controls
{
	public partial class NavigationView : ContentControl
	{
		private readonly SerialDisposable _subscriptions = new SerialDisposable();
		private readonly ObservableVector<object> _menuItems;
		private NavigationViewList _menuItemsHost;
		private Grid _paneContentGrid;
		private Grid _buttonHolderGrid;
		private TextBlock _paneTitleTextBlock;
		private Button _togglePaneButton;
		private Button _navigationViewBackButton;
		private SplitView _rootSplitView;
		private NavigationViewList _topNavMenuItemsHost;

		public NavigationView()
		{
			_menuItems = new ObservableVector<object>();
			_menuItems.VectorChanged += (s, e) => OnMenuItemsChanged();

			SetValue(TemplateSettingsProperty, new NavigationViewTemplateSettings());

			SetValue(MenuItemsProperty, _menuItems);
			SizeChanged += NavigationView_SizeChanged;
			Loaded += (s, e) => OnNavigationViewLoaded();
			Unloaded += (s, e) => UnregisterEvents();
		}

		private void OnNavigationViewLoaded()
		{
			RegisterEvents();

			// Update posision uses RenderSize, which is computed late, reevaluate the positions.
			UpdatePositions();
		}

		private void NavigationView_SizeChanged(object sender, SizeChangedEventArgs args)
		{
			UpdatePositions();
		}

		private void UpdatePositions()
		{
			if (PaneDisplayMode != NavigationViewPaneDisplayMode.Top)
			{
				if (
					(RenderSize.Width < CompactModeThresholdWidth && PaneDisplayMode == NavigationViewPaneDisplayMode.Auto)
					|| PaneDisplayMode == NavigationViewPaneDisplayMode.LeftCompact
				)
					
				{
					UpdateCompactMode();
				}
				else if (
					(RenderSize.Width > ExpandedModeThresholdWidth && PaneDisplayMode == NavigationViewPaneDisplayMode.Auto)
					|| PaneDisplayMode == NavigationViewPaneDisplayMode.Left
				)
				{
					UpdateExpandedMode();
				}
				else
				{
					UpdateMinimalMode();
				}

				VisualStateManager.GoToState(this, !IsPaneOpen ? "ListSizeCompact" : "ListSizeFull", true);
			}
			else
			{

			}
		}

		private void UpdateMinimalMode()
		{
			if (_rootSplitView != null)
			{
				_rootSplitView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
			}

			DisplayMode = NavigationViewDisplayMode.Minimal;

			if (_paneContentGrid != null && _navigationViewBackButton != null)
			{
				_paneContentGrid.RowDefinitions.ElementAt(1).Height = GridLengthHelper.FromPixels(_navigationViewBackButton.RenderSize.Height);
			}

			if (_paneTitleTextBlock != null && _togglePaneButton != null)
			{
				_paneTitleTextBlock.Margin = new Thickness(_togglePaneButton.RenderSize.Width, 0, 0, 0);
			}

			if (_togglePaneButton != null && _navigationViewBackButton != null)
			{
				_togglePaneButton.Margin = new Thickness(0, _navigationViewBackButton.Height, 0, 0);
			}
		}

		private void UpdateExpandedMode()
		{
			if (_rootSplitView != null)
			{
				_rootSplitView.DisplayMode = SplitViewDisplayMode.CompactInline;
			}

			DisplayMode = NavigationViewDisplayMode.Expanded;

			if (_paneContentGrid != null && _navigationViewBackButton != null)
			{
				_paneContentGrid.RowDefinitions.ElementAt(1).Height = GridLengthHelper.FromPixels(_navigationViewBackButton.RenderSize.Height);
			}

			if (_paneTitleTextBlock != null && _togglePaneButton != null)
			{
				_paneTitleTextBlock.Margin = new Thickness(_togglePaneButton.RenderSize.Width, 0, 0, 0);
			}

			if (_togglePaneButton != null && _navigationViewBackButton != null)
			{
				_togglePaneButton.Margin = new Thickness(0, _navigationViewBackButton.Height, 0, 0);
			}
		}

		private void UpdateCompactMode()
		{
			if (_rootSplitView != null)
			{
				_rootSplitView.DisplayMode = SplitViewDisplayMode.Overlay;
			}

			DisplayMode = NavigationViewDisplayMode.Compact;

			if (_paneContentGrid != null && _buttonHolderGrid != null)
			{
				_paneContentGrid.RowDefinitions.ElementAt(1).Height = GridLengthHelper.FromPixels(0);
			}

			if (_paneTitleTextBlock != null && _togglePaneButton != null)
			{
				_paneTitleTextBlock.Margin = IsPaneOpen ? new Thickness(_togglePaneButton.RenderSize.Width + _navigationViewBackButton.RenderSize.Width, 0, 0, 0) : new Thickness(0, 0, 0, 0);
			}

			if (_togglePaneButton != null && _navigationViewBackButton != null)
			{
				_togglePaneButton.Margin = new Thickness(_navigationViewBackButton.Width, 0, 0, 0);
			}
		}

		private void OnMenuItemsChanged()
		{
			if (PaneDisplayMode == NavigationViewPaneDisplayMode.Top)
			{
				_menuItemsHost?.Items.Clear();
				_topNavMenuItemsHost?.Items.Update(_menuItems);
			}
			else
			{
				_topNavMenuItemsHost?.Items.Clear();
				_menuItemsHost?.Items.Update(_menuItems);
			}

			UpdateItemStates();
		}

		[Uno.NotImplemented]
		public object MenuItemFromContainer(DependencyObject container)
		{
			throw new global::System.NotImplementedException("The member object NavigationView.MenuItemFromContainer(DependencyObject container) is not implemented in Uno.");
		}

		[Uno.NotImplemented]
		public DependencyObject ContainerFromMenuItem(object item)
		{
			throw new global::System.NotImplementedException("The member DependencyObject NavigationView.ContainerFromMenuItem(object item) is not implemented in Uno.");
		}

		protected override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			_menuItemsHost = GetTemplateChild("MenuItemsHost") as NavigationViewList;
			_paneContentGrid = GetTemplateChild("PaneContentGrid") as Grid;
			_buttonHolderGrid = GetTemplateChild("ButtonHolderGrid") as Grid;
			_paneTitleTextBlock = GetTemplateChild("PaneTitleTextBlock") as TextBlock;
			_togglePaneButton = GetTemplateChild("TogglePaneButton") as Button;
			_navigationViewBackButton = GetTemplateChild("NavigationViewBackButton") as Button;
			_rootSplitView = GetTemplateChild("RootSplitView") as SplitView;
			_topNavMenuItemsHost = GetTemplateChild("TopNavMenuItemsHost") as NavigationViewList;

			_topNavMenuItemsHost?.SetBinding(NavigationViewList.ItemsSourceProperty, new Binding() { Path = "MenuItemsSource", Source = this });

			TemplateSettings.PaneToggleButtonVisibility = Visibility.Visible;

			SetValue(SettingsItemProperty, GetTemplateChild("SettingsNavPaneItem"));

			if (
				_navigationViewBackButton != null
				&& (
				double.IsNaN(_navigationViewBackButton.Height)
				|| double.IsNaN(_navigationViewBackButton.Width)
				)
			)
			{
				throw new InvalidOperationException("NavigationViewBackButton must have a Width and Height set");
			}

			if (MenuItemsSource == null)
			{
				if (PaneDisplayMode != NavigationViewPaneDisplayMode.Top && _menuItemsHost != null)
				{
					_menuItemsHost.Items.Clear();
					_menuItemsHost.Items.AddRange(_menuItems);
				}
				else if(_topNavMenuItemsHost != null) 
				{
					_topNavMenuItemsHost.Items.Clear();
					_topNavMenuItemsHost.Items.AddRange(_menuItems);
				}
			}

			if (SettingsItem is NavigationViewItem item)
			{
				item.Content = ResourceLoader.GetForCurrentView().GetString("NavigationView_Settings_Content");
			}

			OnIsSettingsVisibleChanged();
			RegisterEvents();
			UpdatePositions();
			UpdateItemStates();
		}

		private void RegisterEvents()
		{
			_subscriptions.Disposable = null;

			if (IsLoaded)
			{
				if (_menuItemsHost != null)
				{
					_menuItemsHost.SelectionChanged += OnMenuItemsHost_SelectionChanged;
					_menuItemsHost.ItemClick += OnMenuItemsHost_ItemClick;
				}

				if (_togglePaneButton != null)
				{
					_togglePaneButton.Click += OnTogglePaneButton_Click;
				}

				if (_navigationViewBackButton != null)
				{
					_navigationViewBackButton.Click += OnNavigationViewBackButtonClick;
				}

				if (SettingsItem is NavigationViewItem item)
				{
					item.InternalPointerPressed += OnSettingsPressed;
				}

				_subscriptions.Disposable = Disposable.Create(() => {
					if (_menuItemsHost != null)
					{
						_menuItemsHost.SelectionChanged -= OnMenuItemsHost_SelectionChanged;
						_menuItemsHost.ItemClick -= OnMenuItemsHost_ItemClick;
					}

					if (_togglePaneButton != null)
					{
						_togglePaneButton.Click -= OnTogglePaneButton_Click;
					}

					if (_navigationViewBackButton != null)
					{
						_navigationViewBackButton.Click -= OnNavigationViewBackButtonClick;
					}

					if (SettingsItem is NavigationViewItem item2)
					{
						item2.InternalPointerPressed -= OnSettingsPressed;
					}
				});
			}
		}

		private void UnregisterEvents()
		{
			_subscriptions.Disposable = null;
		}

		private void OnMenuItemsSourceChanged(object oldValue, object newValue)
		{

		}

		private void OnMenuItemsHost_ItemClick(object sender, ItemClickEventArgs e)
		{
			RaiseItemInvoked(CreateInvokedItemParameter(e.ClickedItem));
		}

		private void RaiseItemInvoked(NavigationViewItemInvokedEventArgs e)
		{
			ItemInvoked?.Invoke(
				this,
				e
			);

			if(_rootSplitView != null && DisplayMode != NavigationViewDisplayMode.Expanded)
			{
				_rootSplitView.IsPaneOpen = false;
			}
		}

		private NavigationViewItemInvokedEventArgs CreateInvokedItemParameter(object clickedItem)
		{
			if (clickedItem is NavigationViewItem nvi)
			{
				if(SettingsItem == clickedItem)
				{
					return new NavigationViewItemInvokedEventArgs
					{
						InvokedItem = SettingsItem,
						IsSettingsInvoked = true
					};
				}
				else
				{
					return new NavigationViewItemInvokedEventArgs
					{
						InvokedItem = nvi.Content,
						IsSettingsInvoked = false
					};
				}
			}

			throw new InvalidOperationException($"Item [{clickedItem}] is not a NavigationViewItem");
		}

		private void OnNavigationViewBackButtonClick(object sender, RoutedEventArgs e)
		{
			BackRequested?.Invoke(this, new NavigationViewBackRequestedEventArgs());
		}

		private void OnTogglePaneButton_Click(object sender, RoutedEventArgs e)
		{
			var closing = new NavigationViewPaneClosingEventArgs();

			if (IsPaneOpen)
			{
				PaneClosing?.Invoke(this, closing);

				if (closing.Cancel)
				{
					this.Log().DebugIfEnabled(() => "Close pane canceled");
					return;
				}
			}
			else
			{
				PaneOpening?.Invoke(this, null);
			}

			IsPaneOpen = !IsPaneOpen;

			if (IsPaneOpen)
			{
				PaneOpened?.Invoke(this, null);
			}
			else
			{
				PaneClosed?.Invoke(this, null);
			}
		}

		private void OnIsPaneOpenChanged()
		{
			foreach (var item in MenuItems.OfType<NavigationViewItemHeader>())
			{
				VisualStateManager.GoToState(item, IsPaneOpen ? "HeaderTextVisible" : "HeaderTextCollapsed", true);
			}

			VisualStateManager.GoToState(this, IsPaneOpen ? "AutoSuggestBoxVisible" : "AutoSuggestBoxCollapsed", true);

			bool isClosedCompact = !IsPaneOpen && DisplayMode == NavigationViewDisplayMode.Compact;
			VisualStateManager.GoToState(this, isClosedCompact ? "ClosedCompact" : "NotClosedCompact", true);

			UpdatePositions();
		}

		private void OnSettingsPressed()
		{
			if (SettingsItem is NavigationViewItem item)
			{
				ItemInvoked?.Invoke(
					this,
					CreateInvokedItemParameter(item)
				);

				SelectedItem = SettingsItem;
				_menuItemsHost.SelectedItem = null;
			}
		}

		private void OnMenuItemsHost_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (_menuItemsHost.SelectedItem == null && SelectedItem == SettingsItem)
			{
				// Ignore the change, we just selected the settings.
			}
			else
			{
				SelectedItem = _menuItemsHost.SelectedItem;
			}
		}

		private void OnSelectedItemChanged()
		{
			SelectionChanged?.Invoke(
				this,
				new NavigationViewSelectionChangedEventArgs
				{
					IsSettingsSelected = SelectedItem == SettingsItem,
					SelectedItem = SelectedItem
				}
			);

			UpdateItemStates();

			if (SettingsItem is NavigationViewItem settings)
			{
				UpdateItemState(settings);
				settings.IsSelected = SelectedItem == settings;
			}
		}

		void UpdateItemState(NavigationViewItem item)
		{
			if (item.SelectionIndicator != null)
			{
				item.SelectionIndicator.Opacity = SelectedItem == item ? 1 : 0;
			}

			VisualStateManager.GoToState(item, GetItemVisualState(), true);
		}

		string GetItemVisualState()
		{
			switch (PaneDisplayMode)
			{
				default:
				case NavigationViewPaneDisplayMode.Auto:
				case NavigationViewPaneDisplayMode.Left:
				case NavigationViewPaneDisplayMode.LeftCompact:
				case NavigationViewPaneDisplayMode.LeftMinimal:
					return "OnLeftNavigation";

				case NavigationViewPaneDisplayMode.Top:
					return "OnTopNavigationPrimary";
			}
		}

		private void UpdateItemStates()
		{
			if (MenuItemsSource == null)
			{
				foreach (var item in MenuItems.OfType<NavigationViewItem>())
				{
					UpdateItemState(item);
				}
			}
			else
			{
				var list = PaneDisplayMode == NavigationViewPaneDisplayMode.Top ? _topNavMenuItemsHost : _menuItemsHost;

				foreach (var item in list.Items.OfType<NavigationViewItem>())
				{
					UpdateItemState(item);
				}
			}
		}

		private void OnIsSettingsVisibleChanged()
		{
			VisualStateManager.GoToState(this, IsSettingsVisible ? "SettingsVisible" : "SettingsCollapsed", true);
		}

		private void OnPaneToggleButtonVisibleChanged()
		{
			VisualStateManager.GoToState(this, IsPaneToggleButtonVisible ? "TogglePaneButtonVisible" : "TogglePaneButtonCollapsed", true);
		}

		private void OnDisplayModeChanged()
		{
			switch (DisplayMode)
			{
				case NavigationViewDisplayMode.Expanded:
					VisualStateManager.GoToState(this, "Expanded", true);
					break;

				case NavigationViewDisplayMode.Compact:
					VisualStateManager.GoToState(this, IsBackButtonVisible != NavigationViewBackButtonVisible.Collapsed ? "MinimalWithBackButton" : "Compact", true);
					break;

				case NavigationViewDisplayMode.Minimal:
					VisualStateManager.GoToState(this, "Minimal", true);
					break;
			}

			DisplayModeChanged?.Invoke(this, new NavigationViewDisplayModeChangedEventArgs { DisplayMode = DisplayMode });
		}

		private void OnPaneDisplayModeChanged(NavigationViewPaneDisplayMode oldValue, NavigationViewPaneDisplayMode newValue)
		{
			switch (newValue)
			{
				case NavigationViewPaneDisplayMode.Auto:
					TemplateSettings.LeftPaneVisibility = Visibility.Visible;
					break;

				case NavigationViewPaneDisplayMode.Left:
					DisplayMode = NavigationViewDisplayMode.Expanded;
					TemplateSettings.LeftPaneVisibility = Visibility.Visible;
					TemplateSettings.TopPaneVisibility = Visibility.Collapsed;
					break;

				case NavigationViewPaneDisplayMode.LeftCompact:
					DisplayMode = NavigationViewDisplayMode.Compact;
					TemplateSettings.LeftPaneVisibility = Visibility.Visible;
					TemplateSettings.TopPaneVisibility = Visibility.Collapsed;
					break;

				case NavigationViewPaneDisplayMode.LeftMinimal:
					TemplateSettings.LeftPaneVisibility = Visibility.Visible;
					TemplateSettings.TopPaneVisibility = Visibility.Collapsed;
					DisplayMode = NavigationViewDisplayMode.Minimal;
					break;

				case NavigationViewPaneDisplayMode.Top:
					TemplateSettings.LeftPaneVisibility = Visibility.Collapsed;
					TemplateSettings.TopPaneVisibility = Visibility.Visible;
					break;
			}

			UpdatePositions();
		}
	}
}
