#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarCustomPen : global::Windows.UI.Xaml.DependencyObject
	{
		// Skipping already declared method Windows.UI.Xaml.Controls.InkToolbarCustomPen.InkToolbarCustomPen()
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomPen.InkToolbarCustomPen()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Input.Inking.InkDrawingAttributes CreateInkDrawingAttributes( global::Windows.UI.Xaml.Media.Brush brush,  double strokeWidth)
		{
			throw new global::System.NotImplementedException("The member InkDrawingAttributes InkToolbarCustomPen.CreateInkDrawingAttributes(Brush brush, double strokeWidth) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Windows.UI.Input.Inking.InkDrawingAttributes CreateInkDrawingAttributesCore( global::Windows.UI.Xaml.Media.Brush brush,  double strokeWidth)
		{
			throw new global::System.NotImplementedException("The member InkDrawingAttributes InkToolbarCustomPen.CreateInkDrawingAttributesCore(Brush brush, double strokeWidth) is not implemented in Uno.");
		}
		#endif
	}
}
