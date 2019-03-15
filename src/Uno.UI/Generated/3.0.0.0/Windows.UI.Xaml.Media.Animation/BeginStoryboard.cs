#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BeginStoryboard : global::Windows.UI.Xaml.TriggerAction
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Animation.Storyboard Storyboard
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.GetValue(StoryboardProperty);
			}
			set
			{
				this.SetValue(StoryboardProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StoryboardProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Storyboard", typeof(global::Windows.UI.Xaml.Media.Animation.Storyboard), 
			typeof(global::Windows.UI.Xaml.Media.Animation.BeginStoryboard), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Animation.Storyboard)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public BeginStoryboard() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.BeginStoryboard", "BeginStoryboard.BeginStoryboard()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.BeginStoryboard.BeginStoryboard()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.BeginStoryboard.Storyboard.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.BeginStoryboard.Storyboard.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.BeginStoryboard.StoryboardProperty.get
	}
}
