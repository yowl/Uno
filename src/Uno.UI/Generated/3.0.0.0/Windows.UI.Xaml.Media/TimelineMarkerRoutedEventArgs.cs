#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TimelineMarkerRoutedEventArgs : global::Windows.UI.Xaml.RoutedEventArgs
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.TimelineMarker Marker
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimelineMarker TimelineMarkerRoutedEventArgs.Marker is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs", "TimelineMarker TimelineMarkerRoutedEventArgs.Marker");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TimelineMarkerRoutedEventArgs() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs", "TimelineMarkerRoutedEventArgs.TimelineMarkerRoutedEventArgs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs.TimelineMarkerRoutedEventArgs()
		// Forced skipping of method Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs.Marker.get
		// Forced skipping of method Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs.Marker.set
	}
}
