#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ToolTip : global::Windows.UI.Xaml.Controls.ContentControl
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double VerticalOffset
		{
			get
			{
				return (double)this.GetValue(VerticalOffsetProperty);
			}
			set
			{
				this.SetValue(VerticalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.UIElement PlacementTarget
		{
			get
			{
				return (global::Windows.UI.Xaml.UIElement)this.GetValue(PlacementTargetProperty);
			}
			set
			{
				this.SetValue(PlacementTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Primitives.PlacementMode Placement
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Primitives.PlacementMode)this.GetValue(PlacementProperty);
			}
			set
			{
				this.SetValue(PlacementProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsOpen
		{
			get
			{
				return (bool)this.GetValue(IsOpenProperty);
			}
			set
			{
				this.SetValue(IsOpenProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double HorizontalOffset
		{
			get
			{
				return (double)this.GetValue(HorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(HorizontalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Primitives.ToolTipTemplateSettings TemplateSettings
		{
			get
			{
				throw new global::System.NotImplementedException("The member ToolTipTemplateSettings ToolTip.TemplateSettings is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Rect? PlacementRect
		{
			get
			{
				return (global::Windows.Foundation.Rect?)this.GetValue(PlacementRectProperty);
			}
			set
			{
				this.SetValue(PlacementRectProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HorizontalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HorizontalOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.ToolTip), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsOpenProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsOpen", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ToolTip), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PlacementProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Placement", typeof(global::Windows.UI.Xaml.Controls.Primitives.PlacementMode), 
			typeof(global::Windows.UI.Xaml.Controls.ToolTip), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.Primitives.PlacementMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PlacementTargetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PlacementTarget", typeof(global::Windows.UI.Xaml.UIElement), 
			typeof(global::Windows.UI.Xaml.Controls.ToolTip), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty VerticalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"VerticalOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.ToolTip), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PlacementRectProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PlacementRect", typeof(global::Windows.Foundation.Rect?), 
			typeof(global::Windows.UI.Xaml.Controls.ToolTip), 
			new FrameworkPropertyMetadata(default(global::Windows.Foundation.Rect?)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ToolTip() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ToolTip", "ToolTip.ToolTip()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.ToolTip()
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.HorizontalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.HorizontalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.IsOpen.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.IsOpen.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.Placement.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.Placement.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.PlacementTarget.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.PlacementTarget.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.VerticalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.VerticalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.TemplateSettings.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.Closed.add
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.Closed.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.Opened.add
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.Opened.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.PlacementRect.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.PlacementRect.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.PlacementRectProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.HorizontalOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.IsOpenProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.PlacementProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.PlacementTargetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTip.VerticalOffsetProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.RoutedEventHandler Closed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ToolTip", "event RoutedEventHandler ToolTip.Closed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ToolTip", "event RoutedEventHandler ToolTip.Closed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.RoutedEventHandler Opened
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ToolTip", "event RoutedEventHandler ToolTip.Opened");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ToolTip", "event RoutedEventHandler ToolTip.Opened");
			}
		}
		#endif
	}
}
