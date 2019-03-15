#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SwapChainPanel : global::Windows.UI.Xaml.Controls.Grid
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float CompositionScaleX
		{
			get
			{
				return (float)this.GetValue(CompositionScaleXProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float CompositionScaleY
		{
			get
			{
				return (float)this.GetValue(CompositionScaleYProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CompositionScaleXProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CompositionScaleX", typeof(float), 
			typeof(global::Windows.UI.Xaml.Controls.SwapChainPanel), 
			new FrameworkPropertyMetadata(default(float)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CompositionScaleYProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CompositionScaleY", typeof(float), 
			typeof(global::Windows.UI.Xaml.Controls.SwapChainPanel), 
			new FrameworkPropertyMetadata(default(float)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SwapChainPanel() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SwapChainPanel", "SwapChainPanel.SwapChainPanel()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SwapChainPanel.SwapChainPanel()
		// Forced skipping of method Windows.UI.Xaml.Controls.SwapChainPanel.CompositionScaleX.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwapChainPanel.CompositionScaleY.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwapChainPanel.CompositionScaleChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.SwapChainPanel.CompositionScaleChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Core.CoreIndependentInputSource CreateCoreIndependentInputSource( global::Windows.UI.Core.CoreInputDeviceTypes deviceTypes)
		{
			throw new global::System.NotImplementedException("The member CoreIndependentInputSource SwapChainPanel.CreateCoreIndependentInputSource(CoreInputDeviceTypes deviceTypes) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SwapChainPanel.CompositionScaleXProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwapChainPanel.CompositionScaleYProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.SwapChainPanel, object> CompositionScaleChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SwapChainPanel", "event TypedEventHandler<SwapChainPanel, object> SwapChainPanel.CompositionScaleChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SwapChainPanel", "event TypedEventHandler<SwapChainPanel, object> SwapChainPanel.CompositionScaleChanged");
			}
		}
		#endif
	}
}
