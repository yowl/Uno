#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ITextChildProvider 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple TextContainer
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Xaml.Automation.Provider.ITextRangeProvider TextRange
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.ITextChildProvider.TextContainer.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.ITextChildProvider.TextRange.get
	}
}
