#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation.Metadata
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CreateFromStringAttribute : global::System.Attribute
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CreateFromStringAttribute() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Foundation.Metadata.CreateFromStringAttribute", "CreateFromStringAttribute.CreateFromStringAttribute()");
		}
		#endif
		// Forced skipping of method Windows.Foundation.Metadata.CreateFromStringAttribute.CreateFromStringAttribute()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  string MethodName;
		#endif
	}
}
