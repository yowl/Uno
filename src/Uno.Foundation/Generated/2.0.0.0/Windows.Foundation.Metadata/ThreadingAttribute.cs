#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation.Metadata
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ThreadingAttribute : global::System.Attribute
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ThreadingAttribute( global::Windows.Foundation.Metadata.ThreadingModel model) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Foundation.Metadata.ThreadingAttribute", "ThreadingAttribute.ThreadingAttribute(ThreadingModel model)");
		}
		#endif
		// Forced skipping of method Windows.Foundation.Metadata.ThreadingAttribute.ThreadingAttribute(Windows.Foundation.Metadata.ThreadingModel)
	}
}
