#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.SerialCommunication
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PinChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.SerialCommunication.SerialPinChange PinChange
		{
			get
			{
				throw new global::System.NotImplementedException("The member SerialPinChange PinChangedEventArgs.PinChange is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.SerialCommunication.PinChangedEventArgs.PinChange.get
	}
}
