#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppBarButtonAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.ButtonAutomationPeer,global::Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Automation.ExpandCollapseState ExpandCollapseState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpandCollapseState AppBarButtonAutomationPeer.ExpandCollapseState is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public AppBarButtonAutomationPeer( global::Windows.UI.Xaml.Controls.AppBarButton owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.AppBarButtonAutomationPeer", "AppBarButtonAutomationPeer.AppBarButtonAutomationPeer(AppBarButton owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.AppBarButtonAutomationPeer.AppBarButtonAutomationPeer(Windows.UI.Xaml.Controls.AppBarButton)
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.AppBarButtonAutomationPeer.ExpandCollapseState.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Collapse()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.AppBarButtonAutomationPeer", "void AppBarButtonAutomationPeer.Collapse()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Expand()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.AppBarButtonAutomationPeer", "void AppBarButtonAutomationPeer.Expand()");
		}
		#endif
		// Processing: Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider
	}
}
