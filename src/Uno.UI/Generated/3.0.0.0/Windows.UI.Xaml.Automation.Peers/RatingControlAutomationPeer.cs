#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RatingControlAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RatingControlAutomationPeer( global::Windows.UI.Xaml.Controls.RatingControl owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.RatingControlAutomationPeer", "RatingControlAutomationPeer.RatingControlAutomationPeer(RatingControl owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.RatingControlAutomationPeer.RatingControlAutomationPeer(Windows.UI.Xaml.Controls.RatingControl)
	}
}
