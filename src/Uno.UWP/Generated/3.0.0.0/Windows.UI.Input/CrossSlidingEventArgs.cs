#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CrossSlidingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Input.CrossSlidingState CrossSlidingState
		{
			get
			{
				throw new global::System.NotImplementedException("The member CrossSlidingState CrossSlidingEventArgs.CrossSlidingState is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Input.PointerDeviceType PointerDeviceType
		{
			get
			{
				throw new global::System.NotImplementedException("The member PointerDeviceType CrossSlidingEventArgs.PointerDeviceType is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point Position
		{
			get
			{
				throw new global::System.NotImplementedException("The member Point CrossSlidingEventArgs.Position is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Input.CrossSlidingEventArgs.PointerDeviceType.get
		// Forced skipping of method Windows.UI.Input.CrossSlidingEventArgs.Position.get
		// Forced skipping of method Windows.UI.Input.CrossSlidingEventArgs.CrossSlidingState.get
	}
}
