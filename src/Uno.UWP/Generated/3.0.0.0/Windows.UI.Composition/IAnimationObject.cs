#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IAnimationObject 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void PopulatePropertyInfo( string propertyName,  global::Windows.UI.Composition.AnimationPropertyInfo propertyInfo);
		#endif
	}
}
