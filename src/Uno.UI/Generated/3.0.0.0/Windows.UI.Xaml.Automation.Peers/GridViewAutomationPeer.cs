#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GridViewAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public GridViewAutomationPeer( global::Windows.UI.Xaml.Controls.GridView owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.GridViewAutomationPeer", "GridViewAutomationPeer.GridViewAutomationPeer(GridView owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.GridViewAutomationPeer.GridViewAutomationPeer(Windows.UI.Xaml.Controls.GridView)
	}
}
