#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AccessKeyInvokedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AccessKeyInvokedEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs", "bool AccessKeyInvokedEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public AccessKeyInvokedEventArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs", "AccessKeyInvokedEventArgs.AccessKeyInvokedEventArgs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs.AccessKeyInvokedEventArgs()
		// Forced skipping of method Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs.Handled.get
		// Forced skipping of method Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs.Handled.set
	}
}
