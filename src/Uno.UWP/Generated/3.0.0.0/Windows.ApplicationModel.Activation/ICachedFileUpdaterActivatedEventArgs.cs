#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ICachedFileUpdaterActivatedEventArgs : global::Windows.ApplicationModel.Activation.IActivatedEventArgs
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Storage.Provider.CachedFileUpdaterUI CachedFileUpdaterUI
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.ICachedFileUpdaterActivatedEventArgs.CachedFileUpdaterUI.get
	}
}
