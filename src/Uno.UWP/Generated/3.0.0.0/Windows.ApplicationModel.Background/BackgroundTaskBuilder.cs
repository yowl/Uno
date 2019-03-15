#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BackgroundTaskBuilder 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string TaskEntryPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member string BackgroundTaskBuilder.TaskEntryPoint is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskBuilder", "string BackgroundTaskBuilder.TaskEntryPoint");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string BackgroundTaskBuilder.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskBuilder", "string BackgroundTaskBuilder.Name");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CancelOnConditionLoss
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool BackgroundTaskBuilder.CancelOnConditionLoss is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskBuilder", "bool BackgroundTaskBuilder.CancelOnConditionLoss");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsNetworkRequested
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool BackgroundTaskBuilder.IsNetworkRequested is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskBuilder", "bool BackgroundTaskBuilder.IsNetworkRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup TaskGroup
		{
			get
			{
				throw new global::System.NotImplementedException("The member BackgroundTaskRegistrationGroup BackgroundTaskBuilder.TaskGroup is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskBuilder", "BackgroundTaskRegistrationGroup BackgroundTaskBuilder.TaskGroup");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public BackgroundTaskBuilder() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskBuilder", "BackgroundTaskBuilder.BackgroundTaskBuilder()");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskBuilder.BackgroundTaskBuilder()
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskBuilder.TaskEntryPoint.set
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskBuilder.TaskEntryPoint.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetTrigger( global::Windows.ApplicationModel.Background.IBackgroundTrigger trigger)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskBuilder", "void BackgroundTaskBuilder.SetTrigger(IBackgroundTrigger trigger)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void AddCondition( global::Windows.ApplicationModel.Background.IBackgroundCondition condition)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskBuilder", "void BackgroundTaskBuilder.AddCondition(IBackgroundCondition condition)");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskBuilder.Name.set
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskBuilder.Name.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Background.BackgroundTaskRegistration Register()
		{
			throw new global::System.NotImplementedException("The member BackgroundTaskRegistration BackgroundTaskBuilder.Register() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskBuilder.CancelOnConditionLoss.set
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskBuilder.CancelOnConditionLoss.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskBuilder.IsNetworkRequested.set
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskBuilder.IsNetworkRequested.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskBuilder.TaskGroup.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskBuilder.TaskGroup.set
	}
}
