#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Interop
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IBindableIterator 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		object Current
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool HasCurrent
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Interop.IBindableIterator.Current.get
		// Forced skipping of method Windows.UI.Xaml.Interop.IBindableIterator.HasCurrent.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool MoveNext();
		#endif
	}
}
