#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TimePickerSelectedValueChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan? NewTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan? TimePickerSelectedValueChangedEventArgs.NewTime is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan? OldTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan? TimePickerSelectedValueChangedEventArgs.OldTime is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TimePickerSelectedValueChangedEventArgs.OldTime.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TimePickerSelectedValueChangedEventArgs.NewTime.get
	}
}
