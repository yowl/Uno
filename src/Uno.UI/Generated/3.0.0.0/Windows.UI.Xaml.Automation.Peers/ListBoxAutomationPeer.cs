#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ListBoxAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ListBoxAutomationPeer( global::Windows.UI.Xaml.Controls.ListBox owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ListBoxAutomationPeer", "ListBoxAutomationPeer.ListBoxAutomationPeer(ListBox owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ListBoxAutomationPeer.ListBoxAutomationPeer(Windows.UI.Xaml.Controls.ListBox)
	}
}
