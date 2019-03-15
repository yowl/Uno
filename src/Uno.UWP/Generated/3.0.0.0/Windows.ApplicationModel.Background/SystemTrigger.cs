#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SystemTrigger : global::Windows.ApplicationModel.Background.IBackgroundTrigger
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool OneShot
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SystemTrigger.OneShot is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Background.SystemTriggerType TriggerType
		{
			get
			{
				throw new global::System.NotImplementedException("The member SystemTriggerType SystemTrigger.TriggerType is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SystemTrigger( global::Windows.ApplicationModel.Background.SystemTriggerType triggerType,  bool oneShot) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.SystemTrigger", "SystemTrigger.SystemTrigger(SystemTriggerType triggerType, bool oneShot)");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.SystemTrigger.SystemTrigger(Windows.ApplicationModel.Background.SystemTriggerType, bool)
		// Forced skipping of method Windows.ApplicationModel.Background.SystemTrigger.OneShot.get
		// Forced skipping of method Windows.ApplicationModel.Background.SystemTrigger.TriggerType.get
		// Processing: Windows.ApplicationModel.Background.IBackgroundTrigger
	}
}
