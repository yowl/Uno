#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DataTemplateKey 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object DataType
		{
			get
			{
				throw new global::System.NotImplementedException("The member object DataTemplateKey.DataType is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.DataTemplateKey", "object DataTemplateKey.DataType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public DataTemplateKey() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.DataTemplateKey", "DataTemplateKey.DataTemplateKey()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.DataTemplateKey.DataTemplateKey()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public DataTemplateKey( object dataType) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.DataTemplateKey", "DataTemplateKey.DataTemplateKey(object dataType)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.DataTemplateKey.DataTemplateKey(object)
		// Forced skipping of method Windows.UI.Xaml.DataTemplateKey.DataType.get
		// Forced skipping of method Windows.UI.Xaml.DataTemplateKey.DataType.set
	}
}
