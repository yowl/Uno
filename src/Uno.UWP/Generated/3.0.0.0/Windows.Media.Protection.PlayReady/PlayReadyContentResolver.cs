#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Protection.PlayReady
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PlayReadyContentResolver 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest ServiceRequest( global::Windows.Media.Protection.PlayReady.PlayReadyContentHeader contentHeader)
		{
			throw new global::System.NotImplementedException("The member IPlayReadyServiceRequest PlayReadyContentResolver.ServiceRequest(PlayReadyContentHeader contentHeader) is not implemented in Uno.");
		}
		#endif
	}
}
