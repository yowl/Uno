#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MenuBarItemAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer,global::Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider,global::Windows.UI.Xaml.Automation.Provider.IInvokeProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Automation.ExpandCollapseState ExpandCollapseState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpandCollapseState MenuBarItemAutomationPeer.ExpandCollapseState is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MenuBarItemAutomationPeer( global::Windows.UI.Xaml.Controls.MenuBarItem owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.MenuBarItemAutomationPeer", "MenuBarItemAutomationPeer.MenuBarItemAutomationPeer(MenuBarItem owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.MenuBarItemAutomationPeer.MenuBarItemAutomationPeer(Windows.UI.Xaml.Controls.MenuBarItem)
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.MenuBarItemAutomationPeer.ExpandCollapseState.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Collapse()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.MenuBarItemAutomationPeer", "void MenuBarItemAutomationPeer.Collapse()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Expand()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.MenuBarItemAutomationPeer", "void MenuBarItemAutomationPeer.Expand()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Invoke()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.MenuBarItemAutomationPeer", "void MenuBarItemAutomationPeer.Invoke()");
		}
		#endif
		// Processing: Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider
		// Processing: Windows.UI.Xaml.Automation.Provider.IInvokeProvider
	}
}
