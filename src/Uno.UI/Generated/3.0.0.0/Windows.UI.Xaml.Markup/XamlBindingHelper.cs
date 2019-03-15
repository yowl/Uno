#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Markup
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlBindingHelper 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DataTemplateComponentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"DataTemplateComponent", typeof(global::Windows.UI.Xaml.Markup.IDataTemplateComponent), 
			typeof(global::Windows.UI.Xaml.Markup.XamlBindingHelper), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Markup.IDataTemplateComponent)));
		#endif
		// Forced skipping of method Windows.UI.Xaml.Markup.XamlBindingHelper.DataTemplateComponentProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.Markup.IDataTemplateComponent GetDataTemplateComponent( global::Windows.UI.Xaml.DependencyObject element)
		{
			return (global::Windows.UI.Xaml.Markup.IDataTemplateComponent)element.GetValue(DataTemplateComponentProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetDataTemplateComponent( global::Windows.UI.Xaml.DependencyObject element,  global::Windows.UI.Xaml.Markup.IDataTemplateComponent value)
		{
			element.SetValue(DataTemplateComponentProperty, value);
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SuspendRendering(Windows.UI.Xaml.UIElement)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.ResumeRendering(Windows.UI.Xaml.UIElement)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(System.Type, object)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromString(object, Windows.UI.Xaml.DependencyProperty, string)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromBoolean(object, Windows.UI.Xaml.DependencyProperty, bool)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromChar16(object, Windows.UI.Xaml.DependencyProperty, char)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromDateTime(object, Windows.UI.Xaml.DependencyProperty, System.DateTimeOffset)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromDouble(object, Windows.UI.Xaml.DependencyProperty, double)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromInt32(object, Windows.UI.Xaml.DependencyProperty, int)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromUInt32(object, Windows.UI.Xaml.DependencyProperty, uint)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromInt64(object, Windows.UI.Xaml.DependencyProperty, long)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromUInt64(object, Windows.UI.Xaml.DependencyProperty, ulong)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromSingle(object, Windows.UI.Xaml.DependencyProperty, float)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromPoint(object, Windows.UI.Xaml.DependencyProperty, Windows.Foundation.Point)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromRect(object, Windows.UI.Xaml.DependencyProperty, Windows.Foundation.Rect)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromSize(object, Windows.UI.Xaml.DependencyProperty, Windows.Foundation.Size)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromTimeSpan(object, Windows.UI.Xaml.DependencyProperty, System.TimeSpan)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromByte(object, Windows.UI.Xaml.DependencyProperty, byte)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromUri(object, Windows.UI.Xaml.DependencyProperty, System.Uri)
		// Skipping already declared method Windows.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromObject(object, Windows.UI.Xaml.DependencyProperty, object)
	}
}
