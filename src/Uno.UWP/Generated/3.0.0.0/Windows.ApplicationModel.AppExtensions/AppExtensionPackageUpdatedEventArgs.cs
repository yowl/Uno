#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.AppExtensions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppExtensionPackageUpdatedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string AppExtensionName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AppExtensionPackageUpdatedEventArgs.AppExtensionName is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.AppExtensions.AppExtension> Extensions
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<AppExtension> AppExtensionPackageUpdatedEventArgs.Extensions is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Package Package
		{
			get
			{
				throw new global::System.NotImplementedException("The member Package AppExtensionPackageUpdatedEventArgs.Package is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatedEventArgs.AppExtensionName.get
		// Forced skipping of method Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatedEventArgs.Package.get
		// Forced skipping of method Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatedEventArgs.Extensions.get
	}
}
