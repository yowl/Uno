#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing.Workflow
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PrintWorkflowSpoolStreamContent 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Storage.Streams.IInputStream GetInputStream()
		{
			throw new global::System.NotImplementedException("The member IInputStream PrintWorkflowSpoolStreamContent.GetInputStream() is not implemented in Uno.");
		}
		#endif
	}
}
