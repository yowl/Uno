#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaElementAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MediaElementAutomationPeer( global::Windows.UI.Xaml.Controls.MediaElement owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.MediaElementAutomationPeer", "MediaElementAutomationPeer.MediaElementAutomationPeer(MediaElement owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.MediaElementAutomationPeer.MediaElementAutomationPeer(Windows.UI.Xaml.Controls.MediaElement)
	}
}
