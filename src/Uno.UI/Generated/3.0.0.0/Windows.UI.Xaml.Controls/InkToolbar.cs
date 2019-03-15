#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbar : global::Windows.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.InkCanvas TargetInkCanvas
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.InkCanvas)this.GetValue(TargetInkCanvasProperty);
			}
			set
			{
				this.SetValue(TargetInkCanvasProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsRulerButtonChecked
		{
			get
			{
				return (bool)this.GetValue(IsRulerButtonCheckedProperty);
			}
			set
			{
				this.SetValue(IsRulerButtonCheckedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.InkToolbarInitialControls InitialControls
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.InkToolbarInitialControls)this.GetValue(InitialControlsProperty);
			}
			set
			{
				this.SetValue(InitialControlsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.InkToolbarToolButton ActiveTool
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.InkToolbarToolButton)this.GetValue(ActiveToolProperty);
			}
			set
			{
				this.SetValue(ActiveToolProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.DependencyObjectCollection Children
		{
			get
			{
				return (global::Windows.UI.Xaml.DependencyObjectCollection)this.GetValue(ChildrenProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Input.Inking.InkDrawingAttributes InkDrawingAttributes
		{
			get
			{
				return (global::Windows.UI.Input.Inking.InkDrawingAttributes)this.GetValue(InkDrawingAttributesProperty);
			}
		}
		#endif
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
		public  bool IsStencilButtonChecked
		{
			get
			{
				return (bool)this.GetValue(IsStencilButtonCheckedProperty);
			}
			set
			{
				this.SetValue(IsStencilButtonCheckedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.InkToolbarButtonFlyoutPlacement ButtonFlyoutPlacement
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.InkToolbarButtonFlyoutPlacement)this.GetValue(ButtonFlyoutPlacementProperty);
			}
			set
			{
				this.SetValue(ButtonFlyoutPlacementProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ActiveToolProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ActiveTool", typeof(global::Windows.UI.Xaml.Controls.InkToolbarToolButton), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbar), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.InkToolbarToolButton)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ChildrenProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Children", typeof(global::Windows.UI.Xaml.DependencyObjectCollection), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbar), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DependencyObjectCollection)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty InitialControlsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"InitialControls", typeof(global::Windows.UI.Xaml.Controls.InkToolbarInitialControls), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbar), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.InkToolbarInitialControls)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty InkDrawingAttributesProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"InkDrawingAttributes", typeof(global::Windows.UI.Input.Inking.InkDrawingAttributes), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbar), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Input.Inking.InkDrawingAttributes)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsRulerButtonCheckedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsRulerButtonChecked", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbar), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TargetInkCanvasProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TargetInkCanvas", typeof(global::Windows.UI.Xaml.Controls.InkCanvas), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbar), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.InkCanvas)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ButtonFlyoutPlacementProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ButtonFlyoutPlacement", typeof(global::Windows.UI.Xaml.Controls.InkToolbarButtonFlyoutPlacement), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbar), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.InkToolbarButtonFlyoutPlacement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsStencilButtonCheckedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsStencilButtonChecked", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbar), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty OrientationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Orientation", typeof(global::Windows.UI.Xaml.Controls.Orientation), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbar), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.Orientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public InkToolbar() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbar", "InkToolbar.InkToolbar()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.InkToolbar()
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.InitialControls.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.InitialControls.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.Children.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.ActiveTool.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.ActiveTool.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.InkDrawingAttributes.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.IsRulerButtonChecked.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.IsRulerButtonChecked.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.TargetInkCanvas.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.TargetInkCanvas.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.ActiveToolChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.ActiveToolChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.InkDrawingAttributesChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.InkDrawingAttributesChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.EraseAllClicked.add
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.EraseAllClicked.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.IsRulerButtonCheckedChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.IsRulerButtonCheckedChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.InkToolbarToolButton GetToolButton( global::Windows.UI.Xaml.Controls.InkToolbarTool tool)
		{
			throw new global::System.NotImplementedException("The member InkToolbarToolButton InkToolbar.GetToolButton(InkToolbarTool tool) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.InkToolbarToggleButton GetToggleButton( global::Windows.UI.Xaml.Controls.InkToolbarToggle tool)
		{
			throw new global::System.NotImplementedException("The member InkToolbarToggleButton InkToolbar.GetToggleButton(InkToolbarToggle tool) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.IsStencilButtonChecked.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.IsStencilButtonChecked.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.ButtonFlyoutPlacement.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.ButtonFlyoutPlacement.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.Orientation.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.Orientation.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.IsStencilButtonCheckedChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.IsStencilButtonCheckedChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.InkToolbarMenuButton GetMenuButton( global::Windows.UI.Xaml.Controls.InkToolbarMenuKind menu)
		{
			throw new global::System.NotImplementedException("The member InkToolbarMenuButton InkToolbar.GetMenuButton(InkToolbarMenuKind menu) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.IsStencilButtonCheckedProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.ButtonFlyoutPlacementProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.OrientationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.InitialControlsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.ChildrenProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.ActiveToolProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.InkDrawingAttributesProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.IsRulerButtonCheckedProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbar.TargetInkCanvasProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.InkToolbar, object> ActiveToolChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbar", "event TypedEventHandler<InkToolbar, object> InkToolbar.ActiveToolChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbar", "event TypedEventHandler<InkToolbar, object> InkToolbar.ActiveToolChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.InkToolbar, object> EraseAllClicked
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbar", "event TypedEventHandler<InkToolbar, object> InkToolbar.EraseAllClicked");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbar", "event TypedEventHandler<InkToolbar, object> InkToolbar.EraseAllClicked");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.InkToolbar, object> InkDrawingAttributesChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbar", "event TypedEventHandler<InkToolbar, object> InkToolbar.InkDrawingAttributesChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbar", "event TypedEventHandler<InkToolbar, object> InkToolbar.InkDrawingAttributesChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.InkToolbar, object> IsRulerButtonCheckedChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbar", "event TypedEventHandler<InkToolbar, object> InkToolbar.IsRulerButtonCheckedChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbar", "event TypedEventHandler<InkToolbar, object> InkToolbar.IsRulerButtonCheckedChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.InkToolbar, global::Windows.UI.Xaml.Controls.InkToolbarIsStencilButtonCheckedChangedEventArgs> IsStencilButtonCheckedChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbar", "event TypedEventHandler<InkToolbar, InkToolbarIsStencilButtonCheckedChangedEventArgs> InkToolbar.IsStencilButtonCheckedChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbar", "event TypedEventHandler<InkToolbar, InkToolbarIsStencilButtonCheckedChangedEventArgs> InkToolbar.IsStencilButtonCheckedChanged");
			}
		}
		#endif
	}
}
