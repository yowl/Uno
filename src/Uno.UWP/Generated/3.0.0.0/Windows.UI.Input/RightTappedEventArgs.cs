#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RightTappedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Input.PointerDeviceType PointerDeviceType
		{
			get
			{
				throw new global::System.NotImplementedException("The member PointerDeviceType RightTappedEventArgs.PointerDeviceType is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point Position
		{
			get
			{
				throw new global::System.NotImplementedException("The member Point RightTappedEventArgs.Position is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Input.RightTappedEventArgs.PointerDeviceType.get
		// Forced skipping of method Windows.UI.Input.RightTappedEventArgs.Position.get
	}
}
