#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BluetoothLEAdvertisementWatcherTrigger : global::Windows.ApplicationModel.Background.IBackgroundTrigger
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter SignalStrengthFilter
		{
			get
			{
				throw new global::System.NotImplementedException("The member BluetoothSignalStrengthFilter BluetoothLEAdvertisementWatcherTrigger.SignalStrengthFilter is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger", "BluetoothSignalStrengthFilter BluetoothLEAdvertisementWatcherTrigger.SignalStrengthFilter");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFilter AdvertisementFilter
		{
			get
			{
				throw new global::System.NotImplementedException("The member BluetoothLEAdvertisementFilter BluetoothLEAdvertisementWatcherTrigger.AdvertisementFilter is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger", "BluetoothLEAdvertisementFilter BluetoothLEAdvertisementWatcherTrigger.AdvertisementFilter");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan MaxOutOfRangeTimeout
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan BluetoothLEAdvertisementWatcherTrigger.MaxOutOfRangeTimeout is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan MaxSamplingInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan BluetoothLEAdvertisementWatcherTrigger.MaxSamplingInterval is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan MinOutOfRangeTimeout
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan BluetoothLEAdvertisementWatcherTrigger.MinOutOfRangeTimeout is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan MinSamplingInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan BluetoothLEAdvertisementWatcherTrigger.MinSamplingInterval is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public BluetoothLEAdvertisementWatcherTrigger() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger", "BluetoothLEAdvertisementWatcherTrigger.BluetoothLEAdvertisementWatcherTrigger()");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger.BluetoothLEAdvertisementWatcherTrigger()
		// Forced skipping of method Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger.MinSamplingInterval.get
		// Forced skipping of method Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger.MaxSamplingInterval.get
		// Forced skipping of method Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger.MinOutOfRangeTimeout.get
		// Forced skipping of method Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger.MaxOutOfRangeTimeout.get
		// Forced skipping of method Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger.SignalStrengthFilter.get
		// Forced skipping of method Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger.SignalStrengthFilter.set
		// Forced skipping of method Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger.AdvertisementFilter.get
		// Forced skipping of method Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger.AdvertisementFilter.set
		// Processing: Windows.ApplicationModel.Background.IBackgroundTrigger
	}
}
