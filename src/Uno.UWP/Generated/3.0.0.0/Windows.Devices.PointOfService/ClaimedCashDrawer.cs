#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ClaimedCashDrawer : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.PointOfService.CashDrawerCloseAlarm CloseAlarm
		{
			get
			{
				throw new global::System.NotImplementedException("The member CashDrawerCloseAlarm ClaimedCashDrawer.CloseAlarm is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ClaimedCashDrawer.DeviceId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsDrawerOpen
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ClaimedCashDrawer.IsDrawerOpen is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ClaimedCashDrawer.IsEnabled is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.ClaimedCashDrawer.DeviceId.get
		// Forced skipping of method Windows.Devices.PointOfService.ClaimedCashDrawer.IsEnabled.get
		// Forced skipping of method Windows.Devices.PointOfService.ClaimedCashDrawer.IsDrawerOpen.get
		// Forced skipping of method Windows.Devices.PointOfService.ClaimedCashDrawer.CloseAlarm.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<bool> OpenDrawerAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ClaimedCashDrawer.OpenDrawerAsync() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<bool> EnableAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ClaimedCashDrawer.EnableAsync() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<bool> DisableAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ClaimedCashDrawer.DisableAsync() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<bool> RetainDeviceAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ClaimedCashDrawer.RetainDeviceAsync() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<bool> ResetStatisticsAsync( global::System.Collections.Generic.IEnumerable<string> statisticsCategories)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ClaimedCashDrawer.ResetStatisticsAsync(IEnumerable<string> statisticsCategories) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<bool> UpdateStatisticsAsync( global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>> statistics)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ClaimedCashDrawer.UpdateStatisticsAsync(IEnumerable<KeyValuePair<string, string>> statistics) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.ClaimedCashDrawer.ReleaseDeviceRequested.add
		// Forced skipping of method Windows.Devices.PointOfService.ClaimedCashDrawer.ReleaseDeviceRequested.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.PointOfService.ClaimedCashDrawer", "void ClaimedCashDrawer.Dispose()");
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.ClaimedCashDrawer.Closed.add
		// Forced skipping of method Windows.Devices.PointOfService.ClaimedCashDrawer.Closed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.PointOfService.ClaimedCashDrawer, object> ReleaseDeviceRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.PointOfService.ClaimedCashDrawer", "event TypedEventHandler<ClaimedCashDrawer, object> ClaimedCashDrawer.ReleaseDeviceRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.PointOfService.ClaimedCashDrawer", "event TypedEventHandler<ClaimedCashDrawer, object> ClaimedCashDrawer.ReleaseDeviceRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.PointOfService.ClaimedCashDrawer, global::Windows.Devices.PointOfService.ClaimedCashDrawerClosedEventArgs> Closed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.PointOfService.ClaimedCashDrawer", "event TypedEventHandler<ClaimedCashDrawer, ClaimedCashDrawerClosedEventArgs> ClaimedCashDrawer.Closed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.PointOfService.ClaimedCashDrawer", "event TypedEventHandler<ClaimedCashDrawer, ClaimedCashDrawerClosedEventArgs> ClaimedCashDrawer.Closed");
			}
		}
		#endif
		// Processing: System.IDisposable
	}
}
