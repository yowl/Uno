#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ListBoxItemDataAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer,global::Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ListBoxItemDataAutomationPeer( object item,  global::Windows.UI.Xaml.Automation.Peers.ListBoxAutomationPeer parent) : base(item, parent)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ListBoxItemDataAutomationPeer", "ListBoxItemDataAutomationPeer.ListBoxItemDataAutomationPeer(object item, ListBoxAutomationPeer parent)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ListBoxItemDataAutomationPeer.ListBoxItemDataAutomationPeer(object, Windows.UI.Xaml.Automation.Peers.ListBoxAutomationPeer)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ScrollIntoView()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ListBoxItemDataAutomationPeer", "void ListBoxItemDataAutomationPeer.ScrollIntoView()");
		}
		#endif
		// Processing: Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
	}
}
