#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppointmentsProviderAddAppointmentActivatedEventArgs : global::Windows.ApplicationModel.Activation.IAppointmentsProviderAddAppointmentActivatedEventArgs,global::Windows.ApplicationModel.Activation.IAppointmentsProviderActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind AppointmentsProviderAddAppointmentActivatedEventArgs.Kind is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState AppointmentsProviderAddAppointmentActivatedEventArgs.PreviousExecutionState is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen AppointmentsProviderAddAppointmentActivatedEventArgs.SplashScreen is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User AppointmentsProviderAddAppointmentActivatedEventArgs.User is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Verb
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AppointmentsProviderAddAppointmentActivatedEventArgs.Verb is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Appointments.AppointmentsProvider.AddAppointmentOperation AddAppointmentOperation
		{
			get
			{
				throw new global::System.NotImplementedException("The member AddAppointmentOperation AppointmentsProviderAddAppointmentActivatedEventArgs.AddAppointmentOperation is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.AppointmentsProviderAddAppointmentActivatedEventArgs.AddAppointmentOperation.get
		// Forced skipping of method Windows.ApplicationModel.Activation.AppointmentsProviderAddAppointmentActivatedEventArgs.Verb.get
		// Forced skipping of method Windows.ApplicationModel.Activation.AppointmentsProviderAddAppointmentActivatedEventArgs.Kind.get
		// Forced skipping of method Windows.ApplicationModel.Activation.AppointmentsProviderAddAppointmentActivatedEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.ApplicationModel.Activation.AppointmentsProviderAddAppointmentActivatedEventArgs.SplashScreen.get
		// Forced skipping of method Windows.ApplicationModel.Activation.AppointmentsProviderAddAppointmentActivatedEventArgs.User.get
		// Processing: Windows.ApplicationModel.Activation.IAppointmentsProviderAddAppointmentActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IAppointmentsProviderActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	}
}
