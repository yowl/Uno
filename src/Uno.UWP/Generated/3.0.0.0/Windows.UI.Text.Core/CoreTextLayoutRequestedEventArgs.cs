#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Text.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreTextLayoutRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Text.Core.CoreTextLayoutRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreTextLayoutRequest CoreTextLayoutRequestedEventArgs.Request is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Text.Core.CoreTextLayoutRequestedEventArgs.Request.get
	}
}
