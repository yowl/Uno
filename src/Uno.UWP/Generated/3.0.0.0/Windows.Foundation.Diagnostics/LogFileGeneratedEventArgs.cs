#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation.Diagnostics
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LogFileGeneratedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Storage.StorageFile File
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFile LogFileGeneratedEventArgs.File is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs.File.get
	}
}
