#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BarcodeScannerImagePreviewReceivedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Storage.Streams.IRandomAccessStreamWithContentType Preview
		{
			get
			{
				throw new global::System.NotImplementedException("The member IRandomAccessStreamWithContentType BarcodeScannerImagePreviewReceivedEventArgs.Preview is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.BarcodeScannerImagePreviewReceivedEventArgs.Preview.get
	}
}
