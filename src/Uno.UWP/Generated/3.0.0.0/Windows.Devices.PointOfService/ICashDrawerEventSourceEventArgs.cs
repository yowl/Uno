#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ICashDrawerEventSourceEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Devices.PointOfService.CashDrawer CashDrawer
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.ICashDrawerEventSourceEventArgs.CashDrawer.get
	}
}
