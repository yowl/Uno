#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SensorDataThresholdTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string SensorDataThresholdTriggerDetails.DeviceId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Sensors.SensorType SensorType
		{
			get
			{
				throw new global::System.NotImplementedException("The member SensorType SensorDataThresholdTriggerDetails.SensorType is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.SensorDataThresholdTriggerDetails.DeviceId.get
		// Forced skipping of method Windows.Devices.Sensors.SensorDataThresholdTriggerDetails.SensorType.get
	}
}
