#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PickerFlyoutBase : global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TitleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"Title", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.PickerFlyoutBase), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected PickerFlyoutBase() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Primitives.PickerFlyoutBase", "PickerFlyoutBase.PickerFlyoutBase()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.PickerFlyoutBase.PickerFlyoutBase()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnConfirmed()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Primitives.PickerFlyoutBase", "void PickerFlyoutBase.OnConfirmed()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual bool ShouldShowConfirmationButtons()
		{
			throw new global::System.NotImplementedException("The member bool PickerFlyoutBase.ShouldShowConfirmationButtons() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.PickerFlyoutBase.TitleProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static string GetTitle( global::Windows.UI.Xaml.DependencyObject element)
		{
			return (string)element.GetValue(TitleProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetTitle( global::Windows.UI.Xaml.DependencyObject element,  string value)
		{
			element.SetValue(TitleProperty, value);
		}
		#endif
	}
}
