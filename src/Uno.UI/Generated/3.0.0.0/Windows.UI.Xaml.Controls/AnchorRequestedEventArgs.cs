#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AnchorRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.UIElement Anchor
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement AnchorRequestedEventArgs.Anchor is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.AnchorRequestedEventArgs", "UIElement AnchorRequestedEventArgs.Anchor");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.UIElement> AnchorCandidates
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<UIElement> AnchorRequestedEventArgs.AnchorCandidates is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.AnchorRequestedEventArgs.Anchor.get
		// Forced skipping of method Windows.UI.Xaml.Controls.AnchorRequestedEventArgs.Anchor.set
		// Forced skipping of method Windows.UI.Xaml.Controls.AnchorRequestedEventArgs.AnchorCandidates.get
	}
}
