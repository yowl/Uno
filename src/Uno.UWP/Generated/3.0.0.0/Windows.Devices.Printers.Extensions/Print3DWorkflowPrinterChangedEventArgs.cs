#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Printers.Extensions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Print3DWorkflowPrinterChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string NewDeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string Print3DWorkflowPrinterChangedEventArgs.NewDeviceId is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Printers.Extensions.Print3DWorkflowPrinterChangedEventArgs.NewDeviceId.get
	}
}
