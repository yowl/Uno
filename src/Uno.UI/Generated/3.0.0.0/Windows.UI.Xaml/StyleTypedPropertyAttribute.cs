#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class StyleTypedPropertyAttribute : global::System.Attribute
	{
		// Skipping already declared method Windows.UI.Xaml.StyleTypedPropertyAttribute.StyleTypedPropertyAttribute()
		// Forced skipping of method Windows.UI.Xaml.StyleTypedPropertyAttribute.StyleTypedPropertyAttribute()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  string Property;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  global::System.Type StyleTargetType;
		#endif
	}
}
