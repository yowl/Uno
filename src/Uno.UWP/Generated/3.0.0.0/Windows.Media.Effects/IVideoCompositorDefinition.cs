#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IVideoCompositorDefinition 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		string ActivatableClassId
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.Collections.IPropertySet Properties
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Media.Effects.IVideoCompositorDefinition.ActivatableClassId.get
		// Forced skipping of method Windows.Media.Effects.IVideoCompositorDefinition.Properties.get
	}
}
