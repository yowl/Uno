#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaTransportControlsAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MediaTransportControlsAutomationPeer( global::Windows.UI.Xaml.Controls.MediaTransportControls owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.MediaTransportControlsAutomationPeer", "MediaTransportControlsAutomationPeer.MediaTransportControlsAutomationPeer(MediaTransportControls owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.MediaTransportControlsAutomationPeer.MediaTransportControlsAutomationPeer(Windows.UI.Xaml.Controls.MediaTransportControls)
	}
}
