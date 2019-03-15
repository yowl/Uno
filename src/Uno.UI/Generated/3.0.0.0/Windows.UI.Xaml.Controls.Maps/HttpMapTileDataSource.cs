#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HttpMapTileDataSource : global::Windows.UI.Xaml.Controls.Maps.MapTileDataSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string UriFormatString
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HttpMapTileDataSource.UriFormatString is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource", "string HttpMapTileDataSource.UriFormatString");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AllowCaching
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool HttpMapTileDataSource.AllowCaching is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource", "bool HttpMapTileDataSource.AllowCaching");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IDictionary<string, string> AdditionalRequestHeaders
		{
			get
			{
				throw new global::System.NotImplementedException("The member IDictionary<string, string> HttpMapTileDataSource.AdditionalRequestHeaders is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public HttpMapTileDataSource() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource", "HttpMapTileDataSource.HttpMapTileDataSource()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource.HttpMapTileDataSource()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public HttpMapTileDataSource( string uriFormatString) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource", "HttpMapTileDataSource.HttpMapTileDataSource(string uriFormatString)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource.HttpMapTileDataSource(string)
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource.UriFormatString.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource.UriFormatString.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource.AdditionalRequestHeaders.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource.AllowCaching.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource.AllowCaching.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource.UriRequested.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource.UriRequested.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource, global::Windows.UI.Xaml.Controls.Maps.MapTileUriRequestedEventArgs> UriRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource", "event TypedEventHandler<HttpMapTileDataSource, MapTileUriRequestedEventArgs> HttpMapTileDataSource.UriRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource", "event TypedEventHandler<HttpMapTileDataSource, MapTileUriRequestedEventArgs> HttpMapTileDataSource.UriRequested");
			}
		}
		#endif
	}
}
