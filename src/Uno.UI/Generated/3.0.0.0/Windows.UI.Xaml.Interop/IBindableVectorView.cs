#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Interop
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IBindableVectorView : global::System.Collections.IEnumerable
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		uint Size
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		object GetAt( uint index);
		#endif
		// Forced skipping of method Windows.UI.Xaml.Interop.IBindableVectorView.Size.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IndexOf( object value, out uint index);
		#endif
	}
}
