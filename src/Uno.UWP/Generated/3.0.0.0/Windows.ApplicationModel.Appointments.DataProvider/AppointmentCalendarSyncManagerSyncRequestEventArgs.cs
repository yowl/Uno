#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Appointments.DataProvider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppointmentCalendarSyncManagerSyncRequestEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarSyncManagerSyncRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppointmentCalendarSyncManagerSyncRequest AppointmentCalendarSyncManagerSyncRequestEventArgs.Request is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarSyncManagerSyncRequestEventArgs.Request.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral AppointmentCalendarSyncManagerSyncRequestEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
