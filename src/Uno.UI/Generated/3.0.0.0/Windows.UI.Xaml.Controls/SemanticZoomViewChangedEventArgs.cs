#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SemanticZoomViewChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.SemanticZoomLocation SourceItem
		{
			get
			{
				throw new global::System.NotImplementedException("The member SemanticZoomLocation SemanticZoomViewChangedEventArgs.SourceItem is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs", "SemanticZoomLocation SemanticZoomViewChangedEventArgs.SourceItem");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsSourceZoomedInView
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SemanticZoomViewChangedEventArgs.IsSourceZoomedInView is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs", "bool SemanticZoomViewChangedEventArgs.IsSourceZoomedInView");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.SemanticZoomLocation DestinationItem
		{
			get
			{
				throw new global::System.NotImplementedException("The member SemanticZoomLocation SemanticZoomViewChangedEventArgs.DestinationItem is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs", "SemanticZoomLocation SemanticZoomViewChangedEventArgs.DestinationItem");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SemanticZoomViewChangedEventArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs", "SemanticZoomViewChangedEventArgs.SemanticZoomViewChangedEventArgs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs.SemanticZoomViewChangedEventArgs()
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs.IsSourceZoomedInView.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs.IsSourceZoomedInView.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs.SourceItem.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs.SourceItem.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs.DestinationItem.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs.DestinationItem.set
	}
}
