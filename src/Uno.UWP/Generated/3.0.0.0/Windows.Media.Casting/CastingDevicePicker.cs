#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Casting
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CastingDevicePicker 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Enumeration.DevicePickerAppearance Appearance
		{
			get
			{
				throw new global::System.NotImplementedException("The member DevicePickerAppearance CastingDevicePicker.Appearance is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Casting.CastingDevicePickerFilter Filter
		{
			get
			{
				throw new global::System.NotImplementedException("The member CastingDevicePickerFilter CastingDevicePicker.Filter is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CastingDevicePicker() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Casting.CastingDevicePicker", "CastingDevicePicker.CastingDevicePicker()");
		}
		#endif
		// Forced skipping of method Windows.Media.Casting.CastingDevicePicker.CastingDevicePicker()
		// Forced skipping of method Windows.Media.Casting.CastingDevicePicker.Filter.get
		// Forced skipping of method Windows.Media.Casting.CastingDevicePicker.Appearance.get
		// Forced skipping of method Windows.Media.Casting.CastingDevicePicker.CastingDeviceSelected.add
		// Forced skipping of method Windows.Media.Casting.CastingDevicePicker.CastingDeviceSelected.remove
		// Forced skipping of method Windows.Media.Casting.CastingDevicePicker.CastingDevicePickerDismissed.add
		// Forced skipping of method Windows.Media.Casting.CastingDevicePicker.CastingDevicePickerDismissed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Show( global::Windows.Foundation.Rect selection)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Casting.CastingDevicePicker", "void CastingDevicePicker.Show(Rect selection)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Show( global::Windows.Foundation.Rect selection,  global::Windows.UI.Popups.Placement preferredPlacement)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Casting.CastingDevicePicker", "void CastingDevicePicker.Show(Rect selection, Placement preferredPlacement)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Hide()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Casting.CastingDevicePicker", "void CastingDevicePicker.Hide()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Casting.CastingDevicePicker, object> CastingDevicePickerDismissed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Casting.CastingDevicePicker", "event TypedEventHandler<CastingDevicePicker, object> CastingDevicePicker.CastingDevicePickerDismissed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Casting.CastingDevicePicker", "event TypedEventHandler<CastingDevicePicker, object> CastingDevicePicker.CastingDevicePickerDismissed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Casting.CastingDevicePicker, global::Windows.Media.Casting.CastingDeviceSelectedEventArgs> CastingDeviceSelected
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Casting.CastingDevicePicker", "event TypedEventHandler<CastingDevicePicker, CastingDeviceSelectedEventArgs> CastingDevicePicker.CastingDeviceSelected");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Casting.CastingDevicePicker", "event TypedEventHandler<CastingDevicePicker, CastingDeviceSelectedEventArgs> CastingDevicePicker.CastingDeviceSelected");
			}
		}
		#endif
	}
}
