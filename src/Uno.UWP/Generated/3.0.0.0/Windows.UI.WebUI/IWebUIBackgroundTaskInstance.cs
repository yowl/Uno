#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IWebUIBackgroundTaskInstance 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool Succeeded
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Windows.UI.WebUI.IWebUIBackgroundTaskInstance.Succeeded.get
		// Forced skipping of method Windows.UI.WebUI.IWebUIBackgroundTaskInstance.Succeeded.set
	}
}
