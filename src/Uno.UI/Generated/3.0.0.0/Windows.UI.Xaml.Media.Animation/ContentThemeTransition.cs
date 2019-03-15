#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContentThemeTransition : global::Windows.UI.Xaml.Media.Animation.Transition
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
		public static global::Windows.UI.Xaml.DependencyProperty HorizontalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HorizontalOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Animation.ContentThemeTransition), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty VerticalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"VerticalOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Animation.ContentThemeTransition), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ContentThemeTransition() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.ContentThemeTransition", "ContentThemeTransition.ContentThemeTransition()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContentThemeTransition.ContentThemeTransition()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContentThemeTransition.HorizontalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContentThemeTransition.HorizontalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContentThemeTransition.VerticalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContentThemeTransition.VerticalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContentThemeTransition.HorizontalOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ContentThemeTransition.VerticalOffsetProperty.get
	}
}
