#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TileActivatedInfo 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Notifications.ShownTileNotification> RecentlyShownNotifications
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<ShownTileNotification> TileActivatedInfo.RecentlyShownNotifications is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.TileActivatedInfo.RecentlyShownNotifications.get
	}
}
