#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GridViewHeaderItemAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.ListViewBaseHeaderItemAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public GridViewHeaderItemAutomationPeer( global::Windows.UI.Xaml.Controls.GridViewHeaderItem owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.GridViewHeaderItemAutomationPeer", "GridViewHeaderItemAutomationPeer.GridViewHeaderItemAutomationPeer(GridViewHeaderItem owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.GridViewHeaderItemAutomationPeer.GridViewHeaderItemAutomationPeer(Windows.UI.Xaml.Controls.GridViewHeaderItem)
	}
}
