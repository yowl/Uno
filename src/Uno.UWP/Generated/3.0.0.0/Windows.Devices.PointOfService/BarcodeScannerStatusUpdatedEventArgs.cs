#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BarcodeScannerStatusUpdatedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint ExtendedStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint BarcodeScannerStatusUpdatedEventArgs.ExtendedStatus is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.PointOfService.BarcodeScannerStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member BarcodeScannerStatus BarcodeScannerStatusUpdatedEventArgs.Status is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.BarcodeScannerStatusUpdatedEventArgs.Status.get
		// Forced skipping of method Windows.Devices.PointOfService.BarcodeScannerStatusUpdatedEventArgs.ExtendedStatus.get
	}
}
