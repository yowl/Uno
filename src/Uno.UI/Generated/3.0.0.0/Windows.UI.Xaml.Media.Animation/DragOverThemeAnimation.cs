#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DragOverThemeAnimation : global::Windows.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ToOffset
		{
			get
			{
				return (double)this.GetValue(ToOffsetProperty);
			}
			set
			{
				this.SetValue(ToOffsetProperty, value);
			}
		}
		#endif
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
		public  global::Windows.UI.Xaml.Controls.Primitives.AnimationDirection Direction
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Primitives.AnimationDirection)this.GetValue(DirectionProperty);
			}
			set
			{
				this.SetValue(DirectionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DirectionProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Direction", typeof(global::Windows.UI.Xaml.Controls.Primitives.AnimationDirection), 
			typeof(global::Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.Primitives.AnimationDirection)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TargetNameProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TargetName", typeof(string), 
			typeof(global::Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ToOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ToOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public DragOverThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation", "DragOverThemeAnimation.DragOverThemeAnimation()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation.DragOverThemeAnimation()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation.TargetName.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation.TargetName.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation.ToOffset.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation.ToOffset.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation.Direction.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation.Direction.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation.TargetNameProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation.ToOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation.DirectionProperty.get
	}
}
