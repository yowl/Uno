#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RepositionThemeAnimation : global::Windows.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string TargetName
		{
			get
			{
				return (string)this.GetValue(TargetNameProperty);
			}
			set
			{
				this.SetValue(TargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double FromVerticalOffset
		{
			get
			{
				return (double)this.GetValue(FromVerticalOffsetProperty);
			}
			set
			{
				this.SetValue(FromVerticalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double FromHorizontalOffset
		{
			get
			{
				return (double)this.GetValue(FromHorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(FromHorizontalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FromHorizontalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"FromHorizontalOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FromVerticalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"FromVerticalOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TargetNameProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TargetName", typeof(string), 
			typeof(global::Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RepositionThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation", "RepositionThemeAnimation.RepositionThemeAnimation()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation.RepositionThemeAnimation()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation.TargetName.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation.TargetName.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation.FromHorizontalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation.FromHorizontalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation.FromVerticalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation.FromVerticalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation.TargetNameProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation.FromHorizontalOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation.FromVerticalOffsetProperty.get
	}
}
