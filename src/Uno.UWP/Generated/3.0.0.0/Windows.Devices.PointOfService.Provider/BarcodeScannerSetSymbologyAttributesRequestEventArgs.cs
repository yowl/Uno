#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService.Provider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BarcodeScannerSetSymbologyAttributesRequestEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.PointOfService.Provider.BarcodeScannerSetSymbologyAttributesRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member BarcodeScannerSetSymbologyAttributesRequest BarcodeScannerSetSymbologyAttributesRequestEventArgs.Request is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.Provider.BarcodeScannerSetSymbologyAttributesRequestEventArgs.Request.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral BarcodeScannerSetSymbologyAttributesRequestEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
