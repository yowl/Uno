#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Diagnostics.DevicePortal
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DevicePortalConnectionClosedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionClosedReason Reason
		{
			get
			{
				throw new global::System.NotImplementedException("The member DevicePortalConnectionClosedReason DevicePortalConnectionClosedEventArgs.Reason is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionClosedEventArgs.Reason.get
	}
}
