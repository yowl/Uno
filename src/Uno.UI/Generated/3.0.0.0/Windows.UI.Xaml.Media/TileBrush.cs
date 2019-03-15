#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TileBrush : global::Windows.UI.Xaml.Media.Brush
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Stretch Stretch
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Stretch)this.GetValue(StretchProperty);
			}
			set
			{
				this.SetValue(StretchProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.AlignmentY AlignmentY
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.AlignmentY)this.GetValue(AlignmentYProperty);
			}
			set
			{
				this.SetValue(AlignmentYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.AlignmentX AlignmentX
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.AlignmentX)this.GetValue(AlignmentXProperty);
			}
			set
			{
				this.SetValue(AlignmentXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AlignmentXProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AlignmentX", typeof(global::Windows.UI.Xaml.Media.AlignmentX), 
			typeof(global::Windows.UI.Xaml.Media.TileBrush), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.AlignmentX)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AlignmentYProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AlignmentY", typeof(global::Windows.UI.Xaml.Media.AlignmentY), 
			typeof(global::Windows.UI.Xaml.Media.TileBrush), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.AlignmentY)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StretchProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Stretch", typeof(global::Windows.UI.Xaml.Media.Stretch), 
			typeof(global::Windows.UI.Xaml.Media.TileBrush), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Stretch)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected TileBrush() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.TileBrush", "TileBrush.TileBrush()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.TileBrush.TileBrush()
		// Forced skipping of method Windows.UI.Xaml.Media.TileBrush.AlignmentX.get
		// Forced skipping of method Windows.UI.Xaml.Media.TileBrush.AlignmentX.set
		// Forced skipping of method Windows.UI.Xaml.Media.TileBrush.AlignmentY.get
		// Forced skipping of method Windows.UI.Xaml.Media.TileBrush.AlignmentY.set
		// Forced skipping of method Windows.UI.Xaml.Media.TileBrush.Stretch.get
		// Forced skipping of method Windows.UI.Xaml.Media.TileBrush.Stretch.set
		// Forced skipping of method Windows.UI.Xaml.Media.TileBrush.AlignmentXProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.TileBrush.AlignmentYProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.TileBrush.StretchProperty.get
	}
}
