#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Appointments.DataProvider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppointmentDataProviderTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Appointments.DataProvider.AppointmentDataProviderConnection Connection
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppointmentDataProviderConnection AppointmentDataProviderTriggerDetails.Connection is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Appointments.DataProvider.AppointmentDataProviderTriggerDetails.Connection.get
	}
}
