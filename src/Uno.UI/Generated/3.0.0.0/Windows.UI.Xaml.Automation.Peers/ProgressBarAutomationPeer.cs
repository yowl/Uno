#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ProgressBarAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ProgressBarAutomationPeer( global::Windows.UI.Xaml.Controls.ProgressBar owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ProgressBarAutomationPeer", "ProgressBarAutomationPeer.ProgressBarAutomationPeer(ProgressBar owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ProgressBarAutomationPeer.ProgressBarAutomationPeer(Windows.UI.Xaml.Controls.ProgressBar)
	}
}
