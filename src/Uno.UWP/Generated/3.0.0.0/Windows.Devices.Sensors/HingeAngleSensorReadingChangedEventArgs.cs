#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HingeAngleSensorReadingChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Sensors.HingeAngleReading Reading
		{
			get
			{
				throw new global::System.NotImplementedException("The member HingeAngleReading HingeAngleSensorReadingChangedEventArgs.Reading is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.HingeAngleSensorReadingChangedEventArgs.Reading.get
	}
}
