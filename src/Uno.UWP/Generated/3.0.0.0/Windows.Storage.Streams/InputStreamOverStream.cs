#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Streams
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InputStreamOverStream : global::Windows.Storage.Streams.IInputStream,global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Storage.Streams.IBuffer, uint> ReadAsync( global::Windows.Storage.Streams.IBuffer buffer,  uint count,  global::Windows.Storage.Streams.InputStreamOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<IBuffer, uint> InputStreamOverStream.ReadAsync(IBuffer buffer, uint count, InputStreamOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Streams.InputStreamOverStream", "void InputStreamOverStream.Dispose()");
		}
		#endif
		// Processing: Windows.Storage.Streams.IInputStream
		// Processing: System.IDisposable
	}
}
