#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.HumanInterfaceDevice
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HidOutputReport 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Storage.Streams.IBuffer Data
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer HidOutputReport.Data is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.HumanInterfaceDevice.HidOutputReport", "IBuffer HidOutputReport.Data");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  ushort Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort HidOutputReport.Id is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidOutputReport.Id.get
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidOutputReport.Data.get
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidOutputReport.Data.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.HumanInterfaceDevice.HidBooleanControl GetBooleanControl( ushort usagePage,  ushort usageId)
		{
			throw new global::System.NotImplementedException("The member HidBooleanControl HidOutputReport.GetBooleanControl(ushort usagePage, ushort usageId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.HumanInterfaceDevice.HidBooleanControl GetBooleanControlByDescription( global::Windows.Devices.HumanInterfaceDevice.HidBooleanControlDescription controlDescription)
		{
			throw new global::System.NotImplementedException("The member HidBooleanControl HidOutputReport.GetBooleanControlByDescription(HidBooleanControlDescription controlDescription) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.HumanInterfaceDevice.HidNumericControl GetNumericControl( ushort usagePage,  ushort usageId)
		{
			throw new global::System.NotImplementedException("The member HidNumericControl HidOutputReport.GetNumericControl(ushort usagePage, ushort usageId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.HumanInterfaceDevice.HidNumericControl GetNumericControlByDescription( global::Windows.Devices.HumanInterfaceDevice.HidNumericControlDescription controlDescription)
		{
			throw new global::System.NotImplementedException("The member HidNumericControl HidOutputReport.GetNumericControlByDescription(HidNumericControlDescription controlDescription) is not implemented in Uno.");
		}
		#endif
	}
}
