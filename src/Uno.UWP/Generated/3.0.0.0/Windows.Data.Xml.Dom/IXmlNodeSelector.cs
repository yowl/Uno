#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Data.Xml.Dom
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IXmlNodeSelector 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Data.Xml.Dom.IXmlNode SelectSingleNode( string xpath);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Data.Xml.Dom.XmlNodeList SelectNodes( string xpath);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Data.Xml.Dom.IXmlNode SelectSingleNodeNS( string xpath,  object namespaces);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Data.Xml.Dom.XmlNodeList SelectNodesNS( string xpath,  object namespaces);
		#endif
	}
}
