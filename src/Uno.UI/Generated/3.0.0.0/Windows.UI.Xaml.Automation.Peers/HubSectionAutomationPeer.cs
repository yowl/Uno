#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HubSectionAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer,global::Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public HubSectionAutomationPeer( global::Windows.UI.Xaml.Controls.HubSection owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.HubSectionAutomationPeer", "HubSectionAutomationPeer.HubSectionAutomationPeer(HubSection owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.HubSectionAutomationPeer.HubSectionAutomationPeer(Windows.UI.Xaml.Controls.HubSection)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ScrollIntoView()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.HubSectionAutomationPeer", "void HubSectionAutomationPeer.ScrollIntoView()");
		}
		#endif
		// Processing: Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
	}
}
