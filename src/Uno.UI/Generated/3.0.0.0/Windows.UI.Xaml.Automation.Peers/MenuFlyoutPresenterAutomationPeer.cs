#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MenuFlyoutPresenterAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MenuFlyoutPresenterAutomationPeer( global::Windows.UI.Xaml.Controls.MenuFlyoutPresenter owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.MenuFlyoutPresenterAutomationPeer", "MenuFlyoutPresenterAutomationPeer.MenuFlyoutPresenterAutomationPeer(MenuFlyoutPresenter owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.MenuFlyoutPresenterAutomationPeer.MenuFlyoutPresenterAutomationPeer(Windows.UI.Xaml.Controls.MenuFlyoutPresenter)
	}
}
