#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Imaging
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlRenderingBackgroundTask 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected XamlRenderingBackgroundTask() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Imaging.XamlRenderingBackgroundTask", "XamlRenderingBackgroundTask.XamlRenderingBackgroundTask()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Imaging.XamlRenderingBackgroundTask.XamlRenderingBackgroundTask()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnRun( global::Windows.ApplicationModel.Background.IBackgroundTaskInstance taskInstance)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Imaging.XamlRenderingBackgroundTask", "void XamlRenderingBackgroundTask.OnRun(IBackgroundTaskInstance taskInstance)");
		}
		#endif
	}
}
