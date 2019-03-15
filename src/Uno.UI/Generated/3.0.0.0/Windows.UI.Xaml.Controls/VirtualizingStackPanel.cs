#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VirtualizingStackPanel : global::Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel
	{
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
		public  bool AreScrollSnapPointsRegular
		{
			get
			{
				return (bool)this.GetValue(AreScrollSnapPointsRegularProperty);
			}
			set
			{
				this.SetValue(AreScrollSnapPointsRegularProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AreScrollSnapPointsRegularProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AreScrollSnapPointsRegular", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.VirtualizingStackPanel), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsVirtualizingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"IsVirtualizing", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.VirtualizingStackPanel), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty OrientationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Orientation", typeof(global::Windows.UI.Xaml.Controls.Orientation), 
			typeof(global::Windows.UI.Xaml.Controls.VirtualizingStackPanel), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.Orientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty VirtualizationModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"VirtualizationMode", typeof(global::Windows.UI.Xaml.Controls.VirtualizationMode), 
			typeof(global::Windows.UI.Xaml.Controls.VirtualizingStackPanel), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.VirtualizationMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public VirtualizingStackPanel() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.VirtualizingStackPanel", "VirtualizingStackPanel.VirtualizingStackPanel()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingStackPanel.VirtualizingStackPanel()
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingStackPanel.AreScrollSnapPointsRegular.get
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingStackPanel.AreScrollSnapPointsRegular.set
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingStackPanel.Orientation.get
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingStackPanel.Orientation.set
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingStackPanel.CleanUpVirtualizedItemEvent.add
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingStackPanel.CleanUpVirtualizedItemEvent.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnCleanUpVirtualizedItem( global::Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventArgs e)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.VirtualizingStackPanel", "void VirtualizingStackPanel.OnCleanUpVirtualizedItem(CleanUpVirtualizedItemEventArgs e)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingStackPanel.AreScrollSnapPointsRegularProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingStackPanel.OrientationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingStackPanel.VirtualizationModeProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.Controls.VirtualizationMode GetVirtualizationMode( global::Windows.UI.Xaml.DependencyObject element)
		{
			return (global::Windows.UI.Xaml.Controls.VirtualizationMode)element.GetValue(VirtualizationModeProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetVirtualizationMode( global::Windows.UI.Xaml.DependencyObject element,  global::Windows.UI.Xaml.Controls.VirtualizationMode value)
		{
			element.SetValue(VirtualizationModeProperty, value);
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingStackPanel.IsVirtualizingProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool GetIsVirtualizing( global::Windows.UI.Xaml.DependencyObject o)
		{
			return (bool)o.GetValue(IsVirtualizingProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventHandler CleanUpVirtualizedItemEvent
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.VirtualizingStackPanel", "event CleanUpVirtualizedItemEventHandler VirtualizingStackPanel.CleanUpVirtualizedItemEvent");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.VirtualizingStackPanel", "event CleanUpVirtualizedItemEventHandler VirtualizingStackPanel.CleanUpVirtualizedItemEvent");
			}
		}
		#endif
	}
}
