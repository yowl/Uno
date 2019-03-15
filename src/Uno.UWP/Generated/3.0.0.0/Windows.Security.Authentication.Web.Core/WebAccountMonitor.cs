#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Web.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebAccountMonitor 
	{
		// Forced skipping of method Windows.Security.Authentication.Web.Core.WebAccountMonitor.Updated.add
		// Forced skipping of method Windows.Security.Authentication.Web.Core.WebAccountMonitor.Updated.remove
		// Forced skipping of method Windows.Security.Authentication.Web.Core.WebAccountMonitor.Removed.add
		// Forced skipping of method Windows.Security.Authentication.Web.Core.WebAccountMonitor.Removed.remove
		// Forced skipping of method Windows.Security.Authentication.Web.Core.WebAccountMonitor.DefaultSignInAccountChanged.add
		// Forced skipping of method Windows.Security.Authentication.Web.Core.WebAccountMonitor.DefaultSignInAccountChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Security.Authentication.Web.Core.WebAccountMonitor, object> DefaultSignInAccountChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Security.Authentication.Web.Core.WebAccountMonitor", "event TypedEventHandler<WebAccountMonitor, object> WebAccountMonitor.DefaultSignInAccountChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Security.Authentication.Web.Core.WebAccountMonitor", "event TypedEventHandler<WebAccountMonitor, object> WebAccountMonitor.DefaultSignInAccountChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Security.Authentication.Web.Core.WebAccountMonitor, global::Windows.Security.Authentication.Web.Core.WebAccountEventArgs> Removed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Security.Authentication.Web.Core.WebAccountMonitor", "event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> WebAccountMonitor.Removed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Security.Authentication.Web.Core.WebAccountMonitor", "event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> WebAccountMonitor.Removed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Security.Authentication.Web.Core.WebAccountMonitor, global::Windows.Security.Authentication.Web.Core.WebAccountEventArgs> Updated
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Security.Authentication.Web.Core.WebAccountMonitor", "event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> WebAccountMonitor.Updated");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Security.Authentication.Web.Core.WebAccountMonitor", "event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> WebAccountMonitor.Updated");
			}
		}
		#endif
	}
}
