#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapElementsLayer : global::Windows.UI.Xaml.Controls.Maps.MapLayer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.Maps.MapElement> MapElements
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.Maps.MapElement>)this.GetValue(MapElementsProperty);
			}
			set
			{
				this.SetValue(MapElementsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MapElementsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MapElements", typeof(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.Maps.MapElement>), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElementsLayer), 
			new FrameworkPropertyMetadata(default(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.Maps.MapElement>)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapElementsLayer() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElementsLayer", "MapElementsLayer.MapElementsLayer()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapElementsLayer()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapElements.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapElements.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapElementClick.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapElementClick.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapElementPointerEntered.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapElementPointerEntered.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapElementPointerExited.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapElementPointerExited.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapContextRequested.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapContextRequested.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElementsLayer.MapElementsProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.Maps.MapElementsLayer, global::Windows.UI.Xaml.Controls.Maps.MapElementsLayerContextRequestedEventArgs> MapContextRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElementsLayer", "event TypedEventHandler<MapElementsLayer, MapElementsLayerContextRequestedEventArgs> MapElementsLayer.MapContextRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElementsLayer", "event TypedEventHandler<MapElementsLayer, MapElementsLayerContextRequestedEventArgs> MapElementsLayer.MapContextRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.Maps.MapElementsLayer, global::Windows.UI.Xaml.Controls.Maps.MapElementsLayerClickEventArgs> MapElementClick
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElementsLayer", "event TypedEventHandler<MapElementsLayer, MapElementsLayerClickEventArgs> MapElementsLayer.MapElementClick");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElementsLayer", "event TypedEventHandler<MapElementsLayer, MapElementsLayerClickEventArgs> MapElementsLayer.MapElementClick");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.Maps.MapElementsLayer, global::Windows.UI.Xaml.Controls.Maps.MapElementsLayerPointerEnteredEventArgs> MapElementPointerEntered
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElementsLayer", "event TypedEventHandler<MapElementsLayer, MapElementsLayerPointerEnteredEventArgs> MapElementsLayer.MapElementPointerEntered");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElementsLayer", "event TypedEventHandler<MapElementsLayer, MapElementsLayerPointerEnteredEventArgs> MapElementsLayer.MapElementPointerEntered");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.Maps.MapElementsLayer, global::Windows.UI.Xaml.Controls.Maps.MapElementsLayerPointerExitedEventArgs> MapElementPointerExited
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElementsLayer", "event TypedEventHandler<MapElementsLayer, MapElementsLayerPointerExitedEventArgs> MapElementsLayer.MapElementPointerExited");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElementsLayer", "event TypedEventHandler<MapElementsLayer, MapElementsLayerPointerExitedEventArgs> MapElementsLayer.MapElementPointerExited");
			}
		}
		#endif
	}
}
