#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ObjectAnimationUsingKeyFrames : global::Windows.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool EnableDependentAnimation
		{
			get
			{
				return (bool)this.GetValue(EnableDependentAnimationProperty);
			}
			set
			{
				this.SetValue(EnableDependentAnimationProperty, value);
			}
		}
		#endif
		// Skipping already declared property KeyFrames
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty EnableDependentAnimationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"EnableDependentAnimation", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.ObjectAnimationUsingKeyFrames()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.ObjectAnimationUsingKeyFrames()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.KeyFrames.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.EnableDependentAnimation.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.EnableDependentAnimation.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.EnableDependentAnimationProperty.get
	}
}
