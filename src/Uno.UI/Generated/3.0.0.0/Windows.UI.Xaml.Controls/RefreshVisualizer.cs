#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RefreshVisualizer : global::Windows.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.RefreshVisualizerOrientation Orientation
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.RefreshVisualizerOrientation)this.GetValue(OrientationProperty);
			}
			set
			{
				this.SetValue(OrientationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.UIElement Content
		{
			get
			{
				return (global::Windows.UI.Xaml.UIElement)this.GetValue(ContentProperty);
			}
			set
			{
				this.SetValue(ContentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.RefreshVisualizerState State
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.RefreshVisualizerState)this.GetValue(StateProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ContentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Content", typeof(global::Windows.UI.Xaml.UIElement), 
			typeof(global::Windows.UI.Xaml.Controls.RefreshVisualizer), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		// Generating stub InfoProviderProperty which has no C# getter
		internal static object InfoProviderProperty { get; }
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty OrientationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Orientation", typeof(global::Windows.UI.Xaml.Controls.RefreshVisualizerOrientation), 
			typeof(global::Windows.UI.Xaml.Controls.RefreshVisualizer), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.RefreshVisualizerOrientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"State", typeof(global::Windows.UI.Xaml.Controls.RefreshVisualizerState), 
			typeof(global::Windows.UI.Xaml.Controls.RefreshVisualizer), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.RefreshVisualizerState)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RefreshVisualizer() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RefreshVisualizer", "RefreshVisualizer.RefreshVisualizer()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.RefreshVisualizer()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void RequestRefresh()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RefreshVisualizer", "void RefreshVisualizer.RequestRefresh()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.Orientation.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.Orientation.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.Content.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.Content.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.State.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.RefreshRequested.add
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.RefreshRequested.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.RefreshStateChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.RefreshStateChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.InfoProviderProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.OrientationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.ContentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshVisualizer.StateProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.RefreshVisualizer, global::Windows.UI.Xaml.Controls.RefreshRequestedEventArgs> RefreshRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RefreshVisualizer", "event TypedEventHandler<RefreshVisualizer, RefreshRequestedEventArgs> RefreshVisualizer.RefreshRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RefreshVisualizer", "event TypedEventHandler<RefreshVisualizer, RefreshRequestedEventArgs> RefreshVisualizer.RefreshRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.RefreshVisualizer, global::Windows.UI.Xaml.Controls.RefreshStateChangedEventArgs> RefreshStateChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RefreshVisualizer", "event TypedEventHandler<RefreshVisualizer, RefreshStateChangedEventArgs> RefreshVisualizer.RefreshStateChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RefreshVisualizer", "event TypedEventHandler<RefreshVisualizer, RefreshStateChangedEventArgs> RefreshVisualizer.RefreshStateChanged");
			}
		}
		#endif
	}
}
