﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Uno.Disposables;
using System.Text;
using Uno.Extensions;
using System.Collections.Specialized;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Animation;
using Uno;
using Windows.UI.Xaml.Media;
using Uno.UI;

namespace Windows.UI.Xaml.Controls
{
	public partial class Frame : ContentControl
	{
		private string _navigationState;

		private static readonly PagePool _pool = new PagePool();

		public Frame()
		{
			var backStack = new ObservableCollection<PageStackEntry>();
			var forwardStack = new ObservableCollection<PageStackEntry>();

			backStack.CollectionChanged += (s, e) =>
			{
				CanGoBack = BackStack.Any();
				BackStackDepth = BackStack.Count;
			};

			forwardStack.CollectionChanged += (s, e) => CanGoForward = ForwardStack.Any();

			BackStack = backStack;
			ForwardStack = forwardStack;

			DefaultStyleKey = typeof(Frame);
		}

		internal PageStackEntry CurrentEntry { get; set; }

		protected override void OnContentChanged(object oldValue, object newValue)
		{
			base.OnContentChanged(oldValue, newValue);

			// Make sure we void CurrentEntry when someone sets Frame.Content = null;
			if (newValue == null)
			{
				CurrentEntry = null;
			}
		}

		#region BackStackDepth DependencyProperty

		public int BackStackDepth
		{
			get { return (int)GetValue(BackStackDepthProperty); }
			private set { this.SetValue(BackStackDepthProperty, value); }
		}

		// Using a DependencyProperty as the backing store for BackStackDepth.  This enables animation, styling, binding, etc...
		public static DependencyProperty BackStackDepthProperty { get ; } =
			DependencyProperty.Register("BackStackDepth", typeof(int), typeof(Frame), new FrameworkPropertyMetadata(0, (s, e) => ((Frame)s)?.OnBackStackDepthChanged(e)));


		protected virtual void OnBackStackDepthChanged(DependencyPropertyChangedEventArgs e)
		{

		}

		#endregion

		#region BackStack DependencyProperty

		public IList<PageStackEntry> BackStack
		{
			get { return (IList<PageStackEntry>)GetValue(BackStackProperty); }
			set { SetValue(BackStackProperty, value); }
		}

		// Using a DependencyProperty as the backing store for BackStack.  This enables animation, styling, binding, etc...
		public static DependencyProperty BackStackProperty { get ; } =
			DependencyProperty.Register("BackStack", typeof(IList<PageStackEntry>), typeof(Frame), new FrameworkPropertyMetadata(null, (s, e) => ((Frame)s)?.OnBackStackChanged(e)));

		private void OnBackStackChanged(DependencyPropertyChangedEventArgs e)
		{
		}

		#endregion

		#region CacheSize DependencyProperty

		public int CacheSize
		{
			get { return (int)GetValue(CacheSizeProperty); }
			set { SetValue(CacheSizeProperty, value); }
		}

		// Using a DependencyProperty as the backing store for CacheSize.  This enables animation, styling, binding, etc...
		public static DependencyProperty CacheSizeProperty { get ; } =
			DependencyProperty.Register("CacheSize", typeof(int), typeof(Frame), new FrameworkPropertyMetadata(0, (s, e) => ((Frame)s)?.OnCacheSizeChanged(e)));


		private void OnCacheSizeChanged(DependencyPropertyChangedEventArgs e)
		{
		}

		#endregion

		#region CanGoBack DependencyProperty

		public bool CanGoBack
		{
			get { return (bool)GetValue(CanGoBackProperty); }
			private set { SetValue(CanGoBackProperty, value); }
		}

		// Using a DependencyProperty as the backing store for CanGoBack.  This enables animation, styling, binding, etc...
		public static DependencyProperty CanGoBackProperty { get ; } =
			DependencyProperty.Register("CanGoBack", typeof(bool), typeof(Frame), new FrameworkPropertyMetadata(false, (s, e) => ((Frame)s)?.OnCanGoBackChanged(e)));


		private void OnCanGoBackChanged(DependencyPropertyChangedEventArgs e)
		{
		}

		#endregion

		#region CanGoForward DependencyProperty

		public bool CanGoForward
		{
			get { return (bool)GetValue(CanGoForwardProperty); }
			private set { SetValue(CanGoForwardProperty, value); }
		}

		// Using a DependencyProperty as the backing store for CanGoForward.  This enables animation, styling, binding, etc...
		public static DependencyProperty CanGoForwardProperty { get ; } =
			DependencyProperty.Register("CanGoForward", typeof(bool), typeof(Frame), new FrameworkPropertyMetadata(true, (s, e) => ((Frame)s)?.OnCanGoForwardChanged(e)));


		private void OnCanGoForwardChanged(DependencyPropertyChangedEventArgs e)
		{

		}

		#endregion

		#region CurrentSourcePageType DependencyProperty

		public Type CurrentSourcePageType
		{
			get { return (Type)GetValue(CurrentSourcePageTypeProperty); }
			private set { SetValue(CurrentSourcePageTypeProperty, value); }
		}

		// Using a DependencyProperty as the backing store for CurrentSourcePageType.  This enables animation, styling, binding, etc...
		public static DependencyProperty CurrentSourcePageTypeProperty { get ; } =
			DependencyProperty.Register("CurrentSourcePageType", typeof(Type), typeof(Frame), new FrameworkPropertyMetadata(null, (s, e) => ((Frame)s)?.OnCurrentSourcePageTypeChanged(e)));


		private void OnCurrentSourcePageTypeChanged(DependencyPropertyChangedEventArgs e)
		{

		}

		#endregion

		#region ForwardStack DependencyProperty

		public IList<PageStackEntry> ForwardStack
		{
			get { return (IList<PageStackEntry>)GetValue(ForwardStackProperty); }
			private set { SetValue(ForwardStackProperty, value); }
		}

		// Using a DependencyProperty as the backing store for ForwardStack.  This enables animation, styling, binding, etc...
		public static DependencyProperty ForwardStackProperty { get ; } =
			DependencyProperty.Register("ForwardStack", typeof(IList<PageStackEntry>), typeof(Frame), new FrameworkPropertyMetadata(null, (s, e) => ((Frame)s)?.OnForwardStackChanged(e)));


		private void OnForwardStackChanged(DependencyPropertyChangedEventArgs e)
		{
		}

		#endregion

		#region SourcePageType DependencyProperty

		public Type SourcePageType
		{
			get { return (Type)GetValue(SourcePageTypeProperty); }
			private set { SetValue(SourcePageTypeProperty, value); }
		}

		// Using a DependencyProperty as the backing store for SourcePageType.  This enables animation, styling, binding, etc...
		public static DependencyProperty SourcePageTypeProperty { get ; } =
			DependencyProperty.Register("SourcePageType", typeof(Type), typeof(Frame), new FrameworkPropertyMetadata(null, (s, e) => ((Frame)s)?.OnSourcePageTypeChanged(e)));

		private void OnSourcePageTypeChanged(DependencyPropertyChangedEventArgs e)
		{
		}

		#endregion

		#region IsNavigationStackEnabled DependencyProperty

		public bool IsNavigationStackEnabled
		{
			get { return (bool)GetValue(IsNavigationStackEnabledProperty); }
			set { SetValue(IsNavigationStackEnabledProperty, value); }
		}

		public static DependencyProperty IsNavigationStackEnabledProperty { get; } =
			DependencyProperty.Register(nameof(IsNavigationStackEnabled), typeof(bool), typeof(Frame), new FrameworkPropertyMetadata(true));

		#endregion

		public event NavigatedEventHandler Navigated;

		public event NavigatingCancelEventHandler Navigating;

		public event NavigationFailedEventHandler NavigationFailed;

		public event NavigationStoppedEventHandler NavigationStopped;

		public string GetNavigationState() => _navigationState;

		public void GoBack() => GoBack(null);

		public void GoBack(NavigationTransitionInfo transitionInfoOverride)
		{
			if (CanGoBack)
			{

				var entry = BackStack.Last();
				if (transitionInfoOverride != null)
				{
					entry.NavigationTransitionInfo = transitionInfoOverride;
				}
				else
				{
					// Fallback to the page forward navigation transition info
					entry.NavigationTransitionInfo = CurrentEntry.NavigationTransitionInfo;
				}

				InnerNavigate(entry, NavigationMode.Back);
			}
		}

		public void GoForward()
		{
			if (CanGoForward)
			{
				InnerNavigate(ForwardStack.Last(), NavigationMode.Forward);
			}
		}

		public bool Navigate(Type sourcePageType) => Navigate(sourcePageType, null, null);

		public bool Navigate(Type sourcePageType, object parameter) => Navigate(sourcePageType, parameter, null);

		public bool Navigate(Type sourcePageType, object parameter, NavigationTransitionInfo infoOverride)
		{
			var entry = new PageStackEntry(sourcePageType, parameter, infoOverride);
			return InnerNavigate(entry, NavigationMode.New);
		}

		private bool InnerNavigate(PageStackEntry entry, NavigationMode mode)
		{
			try
			{
				Application.PrintLine("InnerNavigate");
				// Navigating
				var navigatingFromArgs = new NavigatingCancelEventArgs(
					mode,
					entry.NavigationTransitionInfo,
					entry.Parameter,
					entry.SourcePageType
				); 
				Application.PrintLine("InnerNavigate Invoke");

				Navigating?.Invoke(this, navigatingFromArgs);

				Application.PrintLine("InnerNavigate if (navigatingFromArgs.Cancel)");
				if (navigatingFromArgs.Cancel)
				{
					// Frame canceled
					Application.PrintLine("InnerNavigate OnNavigationStopped");
					OnNavigationStopped(entry, mode);
					return false;
				}

					Application.PrintLine("InnerNavigate OnNavigatingFrom");
				CurrentEntry?.Instance.OnNavigatingFrom(navigatingFromArgs);

					Application.PrintLine("InnerNavigate navigatingFromArgs.Cancel");
				if (navigatingFromArgs.Cancel)
				{
					// Page canceled
					Application.PrintLine("InnerNavigate OnNavigationStopped");
					OnNavigationStopped(entry, mode);
					return false;
				}

				// Navigate
				var previousEntry = CurrentEntry;
				CurrentEntry = entry;

					Application.PrintLine("InnerNavigate mode == NavigationMode.New");
				if (mode == NavigationMode.New)
				{
					Application.PrintLine("InnerNavigate ReleasePages");
					// Doing this first allows CurrentEntry to reuse existing page if pooling is enabled
					ReleasePages(ForwardStack);
				}

					Application.PrintLine("InnerNavigate CurrentEntry.Instance == null");
				if (CurrentEntry.Instance == null)
				{
					Application.PrintLine("InnerNavigate CreatePageInstanceCached");
                    if (entry == null)
                    {
                        Application.PrintLine("InnerNavigate entry == null");
					}
					var page = CreatePageInstanceCached(entry.SourcePageType);
					if (page == null)
					{
						return false;
					}

					page.Frame = this;
					CurrentEntry.Instance = page;
				}

					Application.PrintLine("InnerNavigate Content = CurrentEntry.Instance");
				Content = CurrentEntry.Instance;

					Application.PrintLine("InnerNavigate IsNavigationStackEnabled");
				if (IsNavigationStackEnabled)
				{
					switch (mode)
					{
						case NavigationMode.New:
					Application.PrintLine("InnerNavigate New");
							ForwardStack.Clear();
					if (previousEntry != null)
							{
								BackStack.Add(previousEntry);
							}
							break;
						case NavigationMode.Back:
					Application.PrintLine("InnerNavigate Back");
							ForwardStack.Add(previousEntry);
							BackStack.Remove(CurrentEntry);
							break;
						case NavigationMode.Forward:
					Application.PrintLine("InnerNavigate Forward");
							BackStack.Add(previousEntry);
					ForwardStack.Remove(CurrentEntry);
							break;
						case NavigationMode.Refresh:
					Application.PrintLine("InnerNavigate Refresh");
							break;
					}
				}

				// Navigated
					Application.PrintLine("InnerNavigate new NavigationEventArgs");
				var navigationEvent = new NavigationEventArgs(
					CurrentEntry.Instance,
					mode,
					entry.NavigationTransitionInfo,
					entry.Parameter,
					entry.SourcePageType,
					null
				);

					Application.PrintLine("InnerNavigate OnNavigatedFrom");
				previousEntry?.Instance.OnNavigatedFrom(navigationEvent);
					Application.PrintLine("InnerNavigate OnNavigatedTo");
				CurrentEntry.Instance.OnNavigatedTo(navigationEvent);
					Application.PrintLine("InnerNavigate Navigated?.Invoke");
				Navigated?.Invoke(this, navigationEvent);

					Application.PrintLine("InnerNavigate CloseAllPopups");
				VisualTreeHelper.CloseAllPopups();

				return true;
			}
			catch (Exception exception)
			{
				NavigationFailed?.Invoke(this, new NavigationFailedEventArgs(entry.SourcePageType, exception));

				if (NavigationFailed == null)
				{
					Application.Current.RaiseRecoverableUnhandledException(new InvalidOperationException("Navigation failed", exception));
				}

				return false;
			}
		}

		/// <summary>
		/// Return pages removed from the stack to the pool, if enabled.
		/// </summary>
		private void ReleasePages(IList<PageStackEntry> pageStackEntries)
		{
			foreach (var entry in pageStackEntries)
			{
				entry.Instance.Frame = null;
			}

			if (!FeatureConfiguration.Page.IsPoolingEnabled)
			{
				return;
			}

			foreach (var entry in pageStackEntries)
			{
				if (entry.Instance != null)
				{
					_pool.EnqueuePage(entry.SourcePageType, entry.Instance);
				}
			}
		}

		public void SetNavigationState(string navigationState) => _navigationState = navigationState;

		private static Page CreatePageInstanceCached(Type sourcePageType)
		{
			Application.PrintLine("_pool.DequeuePage");

			return _pool.DequeuePage(sourcePageType);
		}

		internal static Page CreatePageInstance(Type sourcePageType)
		{
			Application.PrintLine("CreatePageInstance");

			if (Uno.UI.DataBinding.BindingPropertyHelper.BindableMetadataProvider != null)
			{
				Application.PrintLine("BindableMetadataProvider");

				var bindableType = Uno.UI.DataBinding.BindingPropertyHelper.BindableMetadataProvider.GetBindableTypeByType(sourcePageType);

				if (bindableType != null)
				{
					Application.PrintLine("CreateInstance");

					return bindableType.CreateInstance()() as Page;
				}
			}
			Application.PrintLine("Activator.CreateInstance");

			return Activator.CreateInstance(sourcePageType) as Page;
		}

		private void OnNavigationStopped(PageStackEntry entry, NavigationMode mode)
		{
			NavigationStopped?.Invoke(this, new NavigationEventArgs(
						entry.Instance,
						mode,
						entry.NavigationTransitionInfo,
						entry.Parameter,
						entry.SourcePageType,
						null
					));
		}
	}
}
