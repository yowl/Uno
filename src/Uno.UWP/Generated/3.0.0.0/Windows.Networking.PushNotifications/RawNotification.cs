#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.PushNotifications
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RawNotification 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Content
		{
			get
			{
				throw new global::System.NotImplementedException("The member string RawNotification.Content is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string ChannelId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string RawNotification.ChannelId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyDictionary<string, string> Headers
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, string> RawNotification.Headers is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.PushNotifications.RawNotification.Content.get
		// Forced skipping of method Windows.Networking.PushNotifications.RawNotification.Headers.get
		// Forced skipping of method Windows.Networking.PushNotifications.RawNotification.ChannelId.get
	}
}
