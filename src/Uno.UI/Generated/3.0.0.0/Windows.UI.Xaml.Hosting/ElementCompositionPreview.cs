#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Hosting
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ElementCompositionPreview 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetImplicitShowAnimation( global::Windows.UI.Xaml.UIElement element,  global::Windows.UI.Composition.ICompositionAnimationBase animation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Hosting.ElementCompositionPreview", "void ElementCompositionPreview.SetImplicitShowAnimation(UIElement element, ICompositionAnimationBase animation)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetImplicitHideAnimation( global::Windows.UI.Xaml.UIElement element,  global::Windows.UI.Composition.ICompositionAnimationBase animation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Hosting.ElementCompositionPreview", "void ElementCompositionPreview.SetImplicitHideAnimation(UIElement element, ICompositionAnimationBase animation)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetIsTranslationEnabled( global::Windows.UI.Xaml.UIElement element,  bool value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Hosting.ElementCompositionPreview", "void ElementCompositionPreview.SetIsTranslationEnabled(UIElement element, bool value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Composition.CompositionPropertySet GetPointerPositionPropertySet( global::Windows.UI.Xaml.UIElement targetElement)
		{
			throw new global::System.NotImplementedException("The member CompositionPropertySet ElementCompositionPreview.GetPointerPositionPropertySet(UIElement targetElement) is not implemented in Uno.");
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.Hosting.ElementCompositionPreview.GetElementVisual(Windows.UI.Xaml.UIElement)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Composition.Visual GetElementChildVisual( global::Windows.UI.Xaml.UIElement element)
		{
			throw new global::System.NotImplementedException("The member Visual ElementCompositionPreview.GetElementChildVisual(UIElement element) is not implemented in Uno.");
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.Hosting.ElementCompositionPreview.SetElementChildVisual(Windows.UI.Xaml.UIElement, Windows.UI.Composition.Visual)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Composition.CompositionPropertySet GetScrollViewerManipulationPropertySet( global::Windows.UI.Xaml.Controls.ScrollViewer scrollViewer)
		{
			throw new global::System.NotImplementedException("The member CompositionPropertySet ElementCompositionPreview.GetScrollViewerManipulationPropertySet(ScrollViewer scrollViewer) is not implemented in Uno.");
		}
		#endif
	}
}
