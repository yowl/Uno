#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.StartScreen
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VisualElementsRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.StartScreen.VisualElementsRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member VisualElementsRequest VisualElementsRequestedEventArgs.Request is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.StartScreen.VisualElementsRequestedEventArgs.Request.get
	}
}
