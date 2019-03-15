#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollContentPresenter 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object ScrollOwner
		{
			get
			{
				throw new global::System.NotImplementedException("The member object ScrollContentPresenter.ScrollOwner is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "object ScrollContentPresenter.ScrollOwner");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanVerticallyScroll
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ScrollContentPresenter.CanVerticallyScroll is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "bool ScrollContentPresenter.CanVerticallyScroll");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanHorizontallyScroll
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ScrollContentPresenter.CanHorizontallyScroll is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "bool ScrollContentPresenter.CanHorizontallyScroll");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ExtentHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollContentPresenter.ExtentHeight is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ExtentWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollContentPresenter.ExtentWidth is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double HorizontalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollContentPresenter.HorizontalOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double VerticalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollContentPresenter.VerticalOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ViewportHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollContentPresenter.ViewportHeight is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ViewportWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollContentPresenter.ViewportWidth is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool SizesContentToTemplatedParent
		{
			get
			{
				return (bool)this.GetValue(SizesContentToTemplatedParentProperty);
			}
			set
			{
				this.SetValue(SizesContentToTemplatedParentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanContentRenderOutsideBounds
		{
			get
			{
				return (bool)this.GetValue(CanContentRenderOutsideBoundsProperty);
			}
			set
			{
				this.SetValue(CanContentRenderOutsideBoundsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CanContentRenderOutsideBoundsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CanContentRenderOutsideBounds", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ScrollContentPresenter), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SizesContentToTemplatedParentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SizesContentToTemplatedParent", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ScrollContentPresenter), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.ScrollContentPresenter.ScrollContentPresenter()
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.ScrollContentPresenter()
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.CanVerticallyScroll.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.CanVerticallyScroll.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.CanHorizontallyScroll.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.CanHorizontallyScroll.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.ExtentWidth.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.ExtentHeight.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.ViewportWidth.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.ViewportHeight.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.HorizontalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.VerticalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.ScrollOwner.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.ScrollOwner.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void LineUp()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.LineUp()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void LineDown()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.LineDown()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void LineLeft()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.LineLeft()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void LineRight()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.LineRight()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PageUp()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.PageUp()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PageDown()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.PageDown()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PageLeft()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.PageLeft()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PageRight()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.PageRight()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void MouseWheelUp()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.MouseWheelUp()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void MouseWheelDown()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.MouseWheelDown()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void MouseWheelLeft()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.MouseWheelLeft()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void MouseWheelRight()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.MouseWheelRight()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetHorizontalOffset( double offset)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.SetHorizontalOffset(double offset)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetVerticalOffset( double offset)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ScrollContentPresenter", "void ScrollContentPresenter.SetVerticalOffset(double offset)");
		}
		#endif
		#if false || false || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Rect MakeVisible( global::Windows.UI.Xaml.UIElement visual,  global::Windows.Foundation.Rect rectangle)
		{
			throw new global::System.NotImplementedException("The member Rect ScrollContentPresenter.MakeVisible(UIElement visual, Rect rectangle) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.CanContentRenderOutsideBounds.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.CanContentRenderOutsideBounds.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.SizesContentToTemplatedParent.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.SizesContentToTemplatedParent.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.CanContentRenderOutsideBoundsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ScrollContentPresenter.SizesContentToTemplatedParentProperty.get
	}
}
