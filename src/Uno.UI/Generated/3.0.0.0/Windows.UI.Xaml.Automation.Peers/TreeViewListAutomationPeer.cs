#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TreeViewListAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TreeViewListAutomationPeer( global::Windows.UI.Xaml.Controls.TreeViewList owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.TreeViewListAutomationPeer", "TreeViewListAutomationPeer.TreeViewListAutomationPeer(TreeViewList owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.TreeViewListAutomationPeer.TreeViewListAutomationPeer(Windows.UI.Xaml.Controls.TreeViewList)
	}
}
