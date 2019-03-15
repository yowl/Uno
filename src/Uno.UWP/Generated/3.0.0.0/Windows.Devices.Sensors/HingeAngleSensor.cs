#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HingeAngleSensor 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ReportThresholdInDegrees
		{
			get
			{
				throw new global::System.NotImplementedException("The member double HingeAngleSensor.ReportThresholdInDegrees is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.HingeAngleSensor", "double HingeAngleSensor.ReportThresholdInDegrees");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HingeAngleSensor.DeviceId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double MinReportThresholdInDegrees
		{
			get
			{
				throw new global::System.NotImplementedException("The member double HingeAngleSensor.MinReportThresholdInDegrees is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.HingeAngleReading> GetCurrentReadingAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<HingeAngleReading> HingeAngleSensor.GetCurrentReadingAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.HingeAngleSensor.DeviceId.get
		// Forced skipping of method Windows.Devices.Sensors.HingeAngleSensor.MinReportThresholdInDegrees.get
		// Forced skipping of method Windows.Devices.Sensors.HingeAngleSensor.ReportThresholdInDegrees.get
		// Forced skipping of method Windows.Devices.Sensors.HingeAngleSensor.ReportThresholdInDegrees.set
		// Forced skipping of method Windows.Devices.Sensors.HingeAngleSensor.ReadingChanged.add
		// Forced skipping of method Windows.Devices.Sensors.HingeAngleSensor.ReadingChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static string GetDeviceSelector()
		{
			throw new global::System.NotImplementedException("The member string HingeAngleSensor.GetDeviceSelector() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.HingeAngleSensor> GetDefaultAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<HingeAngleSensor> HingeAngleSensor.GetDefaultAsync() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.HingeAngleSensor> GetRelatedToAdjacentPanelsAsync( string firstPanelId,  string secondPanelId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<HingeAngleSensor> HingeAngleSensor.GetRelatedToAdjacentPanelsAsync(string firstPanelId, string secondPanelId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.HingeAngleSensor> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<HingeAngleSensor> HingeAngleSensor.FromIdAsync(string deviceId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Sensors.HingeAngleSensor, global::Windows.Devices.Sensors.HingeAngleSensorReadingChangedEventArgs> ReadingChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.HingeAngleSensor", "event TypedEventHandler<HingeAngleSensor, HingeAngleSensorReadingChangedEventArgs> HingeAngleSensor.ReadingChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.HingeAngleSensor", "event TypedEventHandler<HingeAngleSensor, HingeAngleSensorReadingChangedEventArgs> HingeAngleSensor.ReadingChanged");
			}
		}
		#endif
	}
}
