#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AutomationProviderRequestedEventArgs : global::Windows.UI.Core.ICoreWindowEventArgs
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object AutomationProvider
		{
			get
			{
				throw new global::System.NotImplementedException("The member object AutomationProviderRequestedEventArgs.AutomationProvider is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Core.AutomationProviderRequestedEventArgs", "object AutomationProviderRequestedEventArgs.AutomationProvider");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AutomationProviderRequestedEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Core.AutomationProviderRequestedEventArgs", "bool AutomationProviderRequestedEventArgs.Handled");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Core.AutomationProviderRequestedEventArgs.AutomationProvider.get
		// Forced skipping of method Windows.UI.Core.AutomationProviderRequestedEventArgs.AutomationProvider.set
		// Forced skipping of method Windows.UI.Core.AutomationProviderRequestedEventArgs.Handled.get
		// Forced skipping of method Windows.UI.Core.AutomationProviderRequestedEventArgs.Handled.set
		// Processing: Windows.UI.Core.ICoreWindowEventArgs
	}
}
