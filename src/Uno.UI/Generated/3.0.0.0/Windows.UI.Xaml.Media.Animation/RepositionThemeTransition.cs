#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class RepositionThemeTransition : global::Windows.UI.Xaml.Media.Animation.Transition
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsStaggeringEnabled
		{
			get
			{
				return (bool)this.GetValue(IsStaggeringEnabledProperty);
			}
			set
			{
				this.SetValue(IsStaggeringEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsStaggeringEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsStaggeringEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Media.Animation.RepositionThemeTransition), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Media.Animation.RepositionThemeTransition.RepositionThemeTransition()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeTransition.RepositionThemeTransition()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeTransition.IsStaggeringEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeTransition.IsStaggeringEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeTransition.IsStaggeringEnabledProperty.get
	}
}
