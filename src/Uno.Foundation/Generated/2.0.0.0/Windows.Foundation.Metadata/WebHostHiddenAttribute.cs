#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation.Metadata
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebHostHiddenAttribute : global::System.Attribute
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public WebHostHiddenAttribute() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Foundation.Metadata.WebHostHiddenAttribute", "WebHostHiddenAttribute.WebHostHiddenAttribute()");
		}
		#endif
		// Forced skipping of method Windows.Foundation.Metadata.WebHostHiddenAttribute.WebHostHiddenAttribute()
	}
}
