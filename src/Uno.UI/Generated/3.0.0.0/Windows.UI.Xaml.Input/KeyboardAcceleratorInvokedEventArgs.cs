#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class KeyboardAcceleratorInvokedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool KeyboardAcceleratorInvokedEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs", "bool KeyboardAcceleratorInvokedEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.DependencyObject Element
		{
			get
			{
				throw new global::System.NotImplementedException("The member DependencyObject KeyboardAcceleratorInvokedEventArgs.Element is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Input.KeyboardAccelerator KeyboardAccelerator
		{
			get
			{
				throw new global::System.NotImplementedException("The member KeyboardAccelerator KeyboardAcceleratorInvokedEventArgs.KeyboardAccelerator is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs.Handled.get
		// Forced skipping of method Windows.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs.Handled.set
		// Forced skipping of method Windows.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs.Element.get
		// Forced skipping of method Windows.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs.KeyboardAccelerator.get
	}
}
