#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Timeline : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double SpeedRatio
		{
			get
			{
				return (double)this.GetValue(SpeedRatioProperty);
			}
			set
			{
				this.SetValue(SpeedRatioProperty, value);
			}
		}
		#endif
		// Skipping already declared property RepeatBehavior
		// Skipping already declared property FillBehavior
		// Skipping already declared property Duration
		// Skipping already declared property BeginTime
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AutoReverse
		{
			get
			{
				return (bool)this.GetValue(AutoReverseProperty);
			}
			set
			{
				this.SetValue(AutoReverseProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool AllowDependentAnimations
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool Timeline.AllowDependentAnimations is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.Timeline", "bool Timeline.AllowDependentAnimations");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AutoReverseProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AutoReverse", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Media.Animation.Timeline), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property BeginTimeProperty
		// Skipping already declared property DurationProperty
		// Skipping already declared property FillBehaviorProperty
		// Skipping already declared property RepeatBehaviorProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SpeedRatioProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SpeedRatio", typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Animation.Timeline), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Media.Animation.Timeline.Timeline()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.Timeline()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.AutoReverse.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.AutoReverse.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.BeginTime.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.BeginTime.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.Duration.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.Duration.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.SpeedRatio.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.SpeedRatio.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.FillBehavior.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.FillBehavior.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.RepeatBehavior.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.RepeatBehavior.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.Completed.add
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.Completed.remove
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.AllowDependentAnimations.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.AllowDependentAnimations.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.AutoReverseProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.BeginTimeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.DurationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.SpeedRatioProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.FillBehaviorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.Timeline.RepeatBehaviorProperty.get
		// Skipping already declared event Windows.UI.Xaml.Media.Animation.Timeline.Completed
	}
}
