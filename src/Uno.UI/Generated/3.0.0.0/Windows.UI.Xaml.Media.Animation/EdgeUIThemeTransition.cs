#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EdgeUIThemeTransition : global::Windows.UI.Xaml.Media.Animation.Transition
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Primitives.EdgeTransitionLocation Edge
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Primitives.EdgeTransitionLocation)this.GetValue(EdgeProperty);
			}
			set
			{
				this.SetValue(EdgeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty EdgeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Edge", typeof(global::Windows.UI.Xaml.Controls.Primitives.EdgeTransitionLocation), 
			typeof(global::Windows.UI.Xaml.Media.Animation.EdgeUIThemeTransition), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.Primitives.EdgeTransitionLocation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public EdgeUIThemeTransition() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.EdgeUIThemeTransition", "EdgeUIThemeTransition.EdgeUIThemeTransition()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.EdgeUIThemeTransition.EdgeUIThemeTransition()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.EdgeUIThemeTransition.Edge.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.EdgeUIThemeTransition.Edge.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.EdgeUIThemeTransition.EdgeProperty.get
	}
}
