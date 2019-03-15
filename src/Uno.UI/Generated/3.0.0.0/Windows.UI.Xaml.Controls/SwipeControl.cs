#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SwipeControl : global::Windows.UI.Xaml.Controls.ContentControl
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.SwipeItems TopItems
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.SwipeItems)this.GetValue(TopItemsProperty);
			}
			set
			{
				this.SetValue(TopItemsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.SwipeItems RightItems
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.SwipeItems)this.GetValue(RightItemsProperty);
			}
			set
			{
				this.SetValue(RightItemsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.SwipeItems LeftItems
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.SwipeItems)this.GetValue(LeftItemsProperty);
			}
			set
			{
				this.SetValue(LeftItemsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.SwipeItems BottomItems
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.SwipeItems)this.GetValue(BottomItemsProperty);
			}
			set
			{
				this.SetValue(BottomItemsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty BottomItemsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"BottomItems", typeof(global::Windows.UI.Xaml.Controls.SwipeItems), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeControl), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.SwipeItems)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty LeftItemsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"LeftItems", typeof(global::Windows.UI.Xaml.Controls.SwipeItems), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeControl), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.SwipeItems)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty RightItemsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"RightItems", typeof(global::Windows.UI.Xaml.Controls.SwipeItems), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeControl), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.SwipeItems)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TopItemsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TopItems", typeof(global::Windows.UI.Xaml.Controls.SwipeItems), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeControl), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.SwipeItems)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SwipeControl() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SwipeControl", "SwipeControl.SwipeControl()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.SwipeControl()
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.LeftItems.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.LeftItems.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.RightItems.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.RightItems.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.TopItems.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.TopItems.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.BottomItems.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.BottomItems.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Close()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SwipeControl", "void SwipeControl.Close()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.LeftItemsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.RightItemsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.TopItemsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeControl.BottomItemsProperty.get
	}
}
