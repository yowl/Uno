#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollBarAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ScrollBarAutomationPeer( global::Windows.UI.Xaml.Controls.Primitives.ScrollBar owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ScrollBarAutomationPeer", "ScrollBarAutomationPeer.ScrollBarAutomationPeer(ScrollBar owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ScrollBarAutomationPeer.ScrollBarAutomationPeer(Windows.UI.Xaml.Controls.Primitives.ScrollBar)
	}
}
