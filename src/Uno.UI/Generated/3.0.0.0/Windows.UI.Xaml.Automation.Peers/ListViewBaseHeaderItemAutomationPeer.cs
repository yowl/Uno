#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ListViewBaseHeaderItemAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected ListViewBaseHeaderItemAutomationPeer( global::Windows.UI.Xaml.Controls.ListViewBaseHeaderItem owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ListViewBaseHeaderItemAutomationPeer", "ListViewBaseHeaderItemAutomationPeer.ListViewBaseHeaderItemAutomationPeer(ListViewBaseHeaderItem owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ListViewBaseHeaderItemAutomationPeer.ListViewBaseHeaderItemAutomationPeer(Windows.UI.Xaml.Controls.ListViewBaseHeaderItem)
	}
}
