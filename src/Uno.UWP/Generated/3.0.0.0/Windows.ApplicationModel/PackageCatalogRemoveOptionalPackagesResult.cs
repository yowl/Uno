#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PackageCatalogRemoveOptionalPackagesResult 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception PackageCatalogRemoveOptionalPackagesResult.ExtendedError is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Package> PackagesRemoved
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<Package> PackageCatalogRemoveOptionalPackagesResult.PackagesRemoved is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.PackageCatalogRemoveOptionalPackagesResult.PackagesRemoved.get
		// Forced skipping of method Windows.ApplicationModel.PackageCatalogRemoveOptionalPackagesResult.ExtendedError.get
	}
}
