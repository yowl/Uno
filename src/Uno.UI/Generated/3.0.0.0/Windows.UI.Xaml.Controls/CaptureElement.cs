#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CaptureElement : global::Windows.UI.Xaml.FrameworkElement
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
		public  global::Windows.Media.Capture.MediaCapture Source
		{
			get
			{
				return (global::Windows.Media.Capture.MediaCapture)this.GetValue(SourceProperty);
			}
			set
			{
				this.SetValue(SourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Source", typeof(global::Windows.Media.Capture.MediaCapture), 
			typeof(global::Windows.UI.Xaml.Controls.CaptureElement), 
			new FrameworkPropertyMetadata(default(global::Windows.Media.Capture.MediaCapture)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StretchProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Stretch", typeof(global::Windows.UI.Xaml.Media.Stretch), 
			typeof(global::Windows.UI.Xaml.Controls.CaptureElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Stretch)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CaptureElement() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CaptureElement", "CaptureElement.CaptureElement()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.CaptureElement.CaptureElement()
		// Forced skipping of method Windows.UI.Xaml.Controls.CaptureElement.Source.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CaptureElement.Source.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CaptureElement.Stretch.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CaptureElement.Stretch.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CaptureElement.SourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CaptureElement.StretchProperty.get
	}
}
