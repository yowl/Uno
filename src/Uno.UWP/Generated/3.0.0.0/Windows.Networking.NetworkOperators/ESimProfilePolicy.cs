#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ESimProfilePolicy 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanDelete
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ESimProfilePolicy.CanDelete is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanDisable
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ESimProfilePolicy.CanDisable is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsManagedByEnterprise
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ESimProfilePolicy.IsManagedByEnterprise is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimProfilePolicy.CanDelete.get
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimProfilePolicy.CanDisable.get
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimProfilePolicy.IsManagedByEnterprise.get
	}
}
