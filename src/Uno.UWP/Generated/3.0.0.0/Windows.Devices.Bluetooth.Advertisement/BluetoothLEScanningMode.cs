#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.Advertisement
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public   enum BluetoothLEScanningMode 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		Passive,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		Active,
		#endif
	}
	#endif
}
