#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Accelerometer 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint ReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Accelerometer.ReportInterval is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Accelerometer", "uint Accelerometer.ReportInterval");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint MinimumReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Accelerometer.MinimumReportInterval is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Display.DisplayOrientations ReadingTransform
		{
			get
			{
				throw new global::System.NotImplementedException("The member DisplayOrientations Accelerometer.ReadingTransform is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Accelerometer", "DisplayOrientations Accelerometer.ReadingTransform");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint ReportLatency
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Accelerometer.ReportLatency is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Accelerometer", "uint Accelerometer.ReportLatency");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint MaxBatchSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Accelerometer.MaxBatchSize is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Sensors.AccelerometerReadingType ReadingType
		{
			get
			{
				throw new global::System.NotImplementedException("The member AccelerometerReadingType Accelerometer.ReadingType is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string Accelerometer.DeviceId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Sensors.AccelerometerReading GetCurrentReading()
		{
			throw new global::System.NotImplementedException("The member AccelerometerReading Accelerometer.GetCurrentReading() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.MinimumReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.ReportInterval.set
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.ReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.ReadingChanged.add
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.ReadingChanged.remove
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.Shaken.add
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.Shaken.remove
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.DeviceId.get
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.ReadingTransform.set
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.ReadingTransform.get
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.ReportLatency.set
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.ReportLatency.get
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.MaxBatchSize.get
		// Forced skipping of method Windows.Devices.Sensors.Accelerometer.ReadingType.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.Accelerometer> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Accelerometer> Accelerometer.FromIdAsync(string deviceId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static string GetDeviceSelector( global::Windows.Devices.Sensors.AccelerometerReadingType readingType)
		{
			throw new global::System.NotImplementedException("The member string Accelerometer.GetDeviceSelector(AccelerometerReadingType readingType) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Devices.Sensors.Accelerometer GetDefault( global::Windows.Devices.Sensors.AccelerometerReadingType readingType)
		{
			throw new global::System.NotImplementedException("The member Accelerometer Accelerometer.GetDefault(AccelerometerReadingType readingType) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Devices.Sensors.Accelerometer GetDefault()
		{
			throw new global::System.NotImplementedException("The member Accelerometer Accelerometer.GetDefault() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Sensors.Accelerometer, global::Windows.Devices.Sensors.AccelerometerReadingChangedEventArgs> ReadingChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Accelerometer", "event TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs> Accelerometer.ReadingChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Accelerometer", "event TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs> Accelerometer.ReadingChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Sensors.Accelerometer, global::Windows.Devices.Sensors.AccelerometerShakenEventArgs> Shaken
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Accelerometer", "event TypedEventHandler<Accelerometer, AccelerometerShakenEventArgs> Accelerometer.Shaken");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Accelerometer", "event TypedEventHandler<Accelerometer, AccelerometerShakenEventArgs> Accelerometer.Shaken");
			}
		}
		#endif
	}
}
