#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ItemAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.AutomationPeer,global::Windows.UI.Xaml.Automation.Provider.IVirtualizedItemProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Item
		{
			get
			{
				throw new global::System.NotImplementedException("The member object ItemAutomationPeer.Item is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer ItemsControlAutomationPeer
		{
			get
			{
				throw new global::System.NotImplementedException("The member ItemsControlAutomationPeer ItemAutomationPeer.ItemsControlAutomationPeer is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ItemAutomationPeer( object item,  global::Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer parent) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer", "ItemAutomationPeer.ItemAutomationPeer(object item, ItemsControlAutomationPeer parent)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer.ItemAutomationPeer(object, Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer)
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer.Item.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer.ItemsControlAutomationPeer.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Realize()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer", "void ItemAutomationPeer.Realize()");
		}
		#endif
		// Processing: Windows.UI.Xaml.Automation.Provider.IVirtualizedItemProvider
	}
}
