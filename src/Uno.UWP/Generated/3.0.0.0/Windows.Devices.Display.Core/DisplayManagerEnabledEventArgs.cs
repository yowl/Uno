#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Display.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DisplayManagerEnabledEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DisplayManagerEnabledEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayManagerEnabledEventArgs", "bool DisplayManagerEnabledEventArgs.Handled");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Display.Core.DisplayManagerEnabledEventArgs.Handled.get
		// Forced skipping of method Windows.Devices.Display.Core.DisplayManagerEnabledEventArgs.Handled.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral DisplayManagerEnabledEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
