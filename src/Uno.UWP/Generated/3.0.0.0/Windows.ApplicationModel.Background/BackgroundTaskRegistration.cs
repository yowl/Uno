#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BackgroundTaskRegistration : global::Windows.ApplicationModel.Background.IBackgroundTaskRegistration,global::Windows.ApplicationModel.Background.IBackgroundTaskRegistration2,global::Windows.ApplicationModel.Background.IBackgroundTaskRegistration3
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string BackgroundTaskRegistration.Name is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Guid TaskId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid BackgroundTaskRegistration.TaskId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Background.IBackgroundTrigger Trigger
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBackgroundTrigger BackgroundTaskRegistration.Trigger is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup TaskGroup
		{
			get
			{
				throw new global::System.NotImplementedException("The member BackgroundTaskRegistrationGroup BackgroundTaskRegistration.TaskGroup is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::System.Collections.Generic.IReadOnlyDictionary<global::System.Guid, global::Windows.ApplicationModel.Background.IBackgroundTaskRegistration> AllTasks
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<Guid, IBackgroundTaskRegistration> BackgroundTaskRegistration.AllTasks is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::System.Collections.Generic.IReadOnlyDictionary<string, global::Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup> AllTaskGroups
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, BackgroundTaskRegistrationGroup> BackgroundTaskRegistration.AllTaskGroups is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.TaskId.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Name.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Progress.add
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Progress.remove
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Completed.add
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Completed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Unregister( bool cancelTask)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskRegistration", "void BackgroundTaskRegistration.Unregister(bool cancelTask)");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Trigger.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.TaskGroup.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.AllTaskGroups.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup GetTaskGroup( string groupId)
		{
			throw new global::System.NotImplementedException("The member BackgroundTaskRegistrationGroup BackgroundTaskRegistration.GetTaskGroup(string groupId) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.AllTasks.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.ApplicationModel.Background.BackgroundTaskCompletedEventHandler Completed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskRegistration", "event BackgroundTaskCompletedEventHandler BackgroundTaskRegistration.Completed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskRegistration", "event BackgroundTaskCompletedEventHandler BackgroundTaskRegistration.Completed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.ApplicationModel.Background.BackgroundTaskProgressEventHandler Progress
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskRegistration", "event BackgroundTaskProgressEventHandler BackgroundTaskRegistration.Progress");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskRegistration", "event BackgroundTaskProgressEventHandler BackgroundTaskRegistration.Progress");
			}
		}
		#endif
		// Processing: Windows.ApplicationModel.Background.IBackgroundTaskRegistration
		// Processing: Windows.ApplicationModel.Background.IBackgroundTaskRegistration2
		// Processing: Windows.ApplicationModel.Background.IBackgroundTaskRegistration3
	}
}
