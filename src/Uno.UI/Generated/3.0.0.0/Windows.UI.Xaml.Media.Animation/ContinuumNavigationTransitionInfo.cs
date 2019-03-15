#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContinuumNavigationTransitionInfo : global::Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.UIElement ExitElement
		{
			get
			{
				return (global::Windows.UI.Xaml.UIElement)this.GetValue(ExitElementProperty);
			}
			set
			{
				this.SetValue(ExitElementProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ExitElementContainerProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"ExitElementContainer", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ExitElementProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ExitElement", typeof(global::Windows.UI.Xaml.UIElement), 
			typeof(global::Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsEntranceElementProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"IsEntranceElement", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsExitElementProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"IsExitElement", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ContinuumNavigationTransitionInfo() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo", "ContinuumNavigationTransitionInfo.ContinuumNavigationTransitionInfo()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.ContinuumNavigationTransitionInfo()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.ExitElement.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.ExitElement.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.ExitElementProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.IsEntranceElementProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool GetIsEntranceElement( global::Windows.UI.Xaml.UIElement element)
		{
			return (bool)element.GetValue(IsEntranceElementProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetIsEntranceElement( global::Windows.UI.Xaml.UIElement element,  bool value)
		{
			element.SetValue(IsEntranceElementProperty, value);
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.IsExitElementProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool GetIsExitElement( global::Windows.UI.Xaml.UIElement element)
		{
			return (bool)element.GetValue(IsExitElementProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetIsExitElement( global::Windows.UI.Xaml.UIElement element,  bool value)
		{
			element.SetValue(IsExitElementProperty, value);
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.ExitElementContainerProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool GetExitElementContainer( global::Windows.UI.Xaml.Controls.ListViewBase element)
		{
			return (bool)element.GetValue(ExitElementContainerProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetExitElementContainer( global::Windows.UI.Xaml.Controls.ListViewBase element,  bool value)
		{
			element.SetValue(ExitElementContainerProperty, value);
		}
		#endif
	}
}
