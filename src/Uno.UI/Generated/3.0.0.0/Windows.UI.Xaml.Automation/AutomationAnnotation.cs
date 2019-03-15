#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class AutomationAnnotation : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Automation.AnnotationType Type
		{
			get
			{
				return (global::Windows.UI.Xaml.Automation.AnnotationType)this.GetValue(TypeProperty);
			}
			set
			{
				this.SetValue(TypeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.UIElement Element
		{
			get
			{
				return (global::Windows.UI.Xaml.UIElement)this.GetValue(ElementProperty);
			}
			set
			{
				this.SetValue(ElementProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ElementProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Element", typeof(global::Windows.UI.Xaml.UIElement), 
			typeof(global::Windows.UI.Xaml.Automation.AutomationAnnotation), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TypeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Type", typeof(global::Windows.UI.Xaml.Automation.AnnotationType), 
			typeof(global::Windows.UI.Xaml.Automation.AutomationAnnotation), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Automation.AnnotationType)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public AutomationAnnotation( global::Windows.UI.Xaml.Automation.AnnotationType type) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.AutomationAnnotation", "AutomationAnnotation.AutomationAnnotation(AnnotationType type)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.AutomationAnnotation.AutomationAnnotation(Windows.UI.Xaml.Automation.AnnotationType)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public AutomationAnnotation( global::Windows.UI.Xaml.Automation.AnnotationType type,  global::Windows.UI.Xaml.UIElement element) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.AutomationAnnotation", "AutomationAnnotation.AutomationAnnotation(AnnotationType type, UIElement element)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.AutomationAnnotation.AutomationAnnotation(Windows.UI.Xaml.Automation.AnnotationType, Windows.UI.Xaml.UIElement)
		// Skipping already declared method Windows.UI.Xaml.Automation.AutomationAnnotation.AutomationAnnotation()
		// Forced skipping of method Windows.UI.Xaml.Automation.AutomationAnnotation.AutomationAnnotation()
		// Forced skipping of method Windows.UI.Xaml.Automation.AutomationAnnotation.Type.get
		// Forced skipping of method Windows.UI.Xaml.Automation.AutomationAnnotation.Type.set
		// Forced skipping of method Windows.UI.Xaml.Automation.AutomationAnnotation.Element.get
		// Forced skipping of method Windows.UI.Xaml.Automation.AutomationAnnotation.Element.set
		// Forced skipping of method Windows.UI.Xaml.Automation.AutomationAnnotation.TypeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Automation.AutomationAnnotation.ElementProperty.get
	}
}
