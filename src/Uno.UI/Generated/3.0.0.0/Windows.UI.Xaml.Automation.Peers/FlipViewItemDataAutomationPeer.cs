#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FlipViewItemDataAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer,global::Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public FlipViewItemDataAutomationPeer( object item,  global::Windows.UI.Xaml.Automation.Peers.FlipViewAutomationPeer parent) : base(item, parent)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.FlipViewItemDataAutomationPeer", "FlipViewItemDataAutomationPeer.FlipViewItemDataAutomationPeer(object item, FlipViewAutomationPeer parent)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.FlipViewItemDataAutomationPeer.FlipViewItemDataAutomationPeer(object, Windows.UI.Xaml.Automation.Peers.FlipViewAutomationPeer)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ScrollIntoView()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.FlipViewItemDataAutomationPeer", "void FlipViewItemDataAutomationPeer.ScrollIntoView()");
		}
		#endif
		// Processing: Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
	}
}
