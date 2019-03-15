#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HandwritingView : global::Windows.UI.Xaml.Controls.Control
	{
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
		public  global::Windows.UI.Xaml.Controls.HandwritingPanelPlacementAlignment PlacementAlignment
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.HandwritingPanelPlacementAlignment)this.GetValue(PlacementAlignmentProperty);
			}
			set
			{
				this.SetValue(PlacementAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AreCandidatesEnabled
		{
			get
			{
				return (bool)this.GetValue(AreCandidatesEnabledProperty);
			}
			set
			{
				this.SetValue(AreCandidatesEnabledProperty, value);
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
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AreCandidatesEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AreCandidatesEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.HandwritingView), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsOpenProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsOpen", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.HandwritingView), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PlacementAlignmentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PlacementAlignment", typeof(global::Windows.UI.Xaml.Controls.HandwritingPanelPlacementAlignment), 
			typeof(global::Windows.UI.Xaml.Controls.HandwritingView), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.HandwritingPanelPlacementAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PlacementTargetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PlacementTarget", typeof(global::Windows.UI.Xaml.UIElement), 
			typeof(global::Windows.UI.Xaml.Controls.HandwritingView), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public HandwritingView() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.HandwritingView", "HandwritingView.HandwritingView()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.HandwritingView()
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.PlacementTarget.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.PlacementTarget.set
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.PlacementAlignment.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.PlacementAlignment.set
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.IsOpen.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.AreCandidatesEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.AreCandidatesEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.Opened.add
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.Opened.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.Closed.add
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.Closed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool TryClose()
		{
			throw new global::System.NotImplementedException("The member bool HandwritingView.TryClose() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool TryOpen()
		{
			throw new global::System.NotImplementedException("The member bool HandwritingView.TryOpen() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.PlacementTargetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.PlacementAlignmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.IsOpenProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingView.AreCandidatesEnabledProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.HandwritingView, global::Windows.UI.Xaml.Controls.HandwritingPanelClosedEventArgs> Closed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.HandwritingView", "event TypedEventHandler<HandwritingView, HandwritingPanelClosedEventArgs> HandwritingView.Closed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.HandwritingView", "event TypedEventHandler<HandwritingView, HandwritingPanelClosedEventArgs> HandwritingView.Closed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.HandwritingView, global::Windows.UI.Xaml.Controls.HandwritingPanelOpenedEventArgs> Opened
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.HandwritingView", "event TypedEventHandler<HandwritingView, HandwritingPanelOpenedEventArgs> HandwritingView.Opened");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.HandwritingView", "event TypedEventHandler<HandwritingView, HandwritingPanelOpenedEventArgs> HandwritingView.Opened");
			}
		}
		#endif
	}
}
