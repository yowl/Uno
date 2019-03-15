#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Frame : global::Windows.UI.Xaml.Controls.ContentControl,global::Windows.UI.Xaml.Controls.INavigate
	{
		// Skipping already declared property SourcePageType
		// Skipping already declared property CacheSize
		// Skipping already declared property BackStackDepth
		// Skipping already declared property CanGoBack
		// Skipping already declared property CanGoForward
		// Skipping already declared property CurrentSourcePageType
		// Skipping already declared property BackStack
		// Skipping already declared property ForwardStack
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsNavigationStackEnabled
		{
			get
			{
				return (bool)this.GetValue(IsNavigationStackEnabledProperty);
			}
			set
			{
				this.SetValue(IsNavigationStackEnabledProperty, value);
			}
		}
		#endif
		// Skipping already declared property BackStackDepthProperty
		// Skipping already declared property CacheSizeProperty
		// Skipping already declared property CanGoBackProperty
		// Skipping already declared property CanGoForwardProperty
		// Skipping already declared property CurrentSourcePageTypeProperty
		// Skipping already declared property SourcePageTypeProperty
		// Skipping already declared property BackStackProperty
		// Skipping already declared property ForwardStackProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsNavigationStackEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsNavigationStackEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.Frame), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.Frame.Frame()
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.Frame()
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.CacheSize.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.CacheSize.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.CanGoBack.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.CanGoForward.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.CurrentSourcePageType.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.SourcePageType.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.SourcePageType.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.BackStackDepth.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.Navigated.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.Navigated.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.Navigating.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.Navigating.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.NavigationFailed.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.NavigationFailed.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.NavigationStopped.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.NavigationStopped.remove
		// Skipping already declared method Windows.UI.Xaml.Controls.Frame.GoBack()
		// Skipping already declared method Windows.UI.Xaml.Controls.Frame.GoForward()
		// Skipping already declared method Windows.UI.Xaml.Controls.Frame.Navigate(System.Type, object)
		// Skipping already declared method Windows.UI.Xaml.Controls.Frame.GetNavigationState()
		// Skipping already declared method Windows.UI.Xaml.Controls.Frame.SetNavigationState(string)
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.BackStack.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.ForwardStack.get
		// Skipping already declared method Windows.UI.Xaml.Controls.Frame.Navigate(System.Type, object, Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo)
		// Skipping already declared method Windows.UI.Xaml.Controls.Frame.GoBack(Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetNavigationState( string navigationState,  bool suppressNavigate)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Frame", "void Frame.SetNavigationState(string navigationState, bool suppressNavigate)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.IsNavigationStackEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.IsNavigationStackEnabled.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool NavigateToType( global::System.Type sourcePageType,  object parameter,  global::Windows.UI.Xaml.Navigation.FrameNavigationOptions navigationOptions)
		{
			throw new global::System.NotImplementedException("The member bool Frame.NavigateToType(Type sourcePageType, object parameter, FrameNavigationOptions navigationOptions) is not implemented in Uno.");
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.Frame.Navigate(System.Type)
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.IsNavigationStackEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.BackStackProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.ForwardStackProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.CacheSizeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.CanGoBackProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.CanGoForwardProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.CurrentSourcePageTypeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.SourcePageTypeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Frame.BackStackDepthProperty.get
		// Skipping already declared event Windows.UI.Xaml.Controls.Frame.Navigated
		// Skipping already declared event Windows.UI.Xaml.Controls.Frame.Navigating
		// Skipping already declared event Windows.UI.Xaml.Controls.Frame.NavigationFailed
		// Skipping already declared event Windows.UI.Xaml.Controls.Frame.NavigationStopped
		// Processing: Windows.UI.Xaml.Controls.INavigate
	}
}
