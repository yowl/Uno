#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ToastActivatedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Arguments
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ToastActivatedEventArgs.Arguments is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Notifications.ToastActivatedEventArgs.Arguments.get
	}
}
