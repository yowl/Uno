#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Data.Html
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HtmlUtilities 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static string ConvertToText( string html)
		{
			throw new global::System.NotImplementedException("The member string HtmlUtilities.ConvertToText(string html) is not implemented in Uno.");
		}
		#endif
	}
}
