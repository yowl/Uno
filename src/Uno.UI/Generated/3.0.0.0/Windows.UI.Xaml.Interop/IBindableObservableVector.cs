#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Interop
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IBindableObservableVector : global::System.Collections.IList,global::System.Collections.IEnumerable
	{
		// Forced skipping of method Windows.UI.Xaml.Interop.IBindableObservableVector.VectorChanged.add
		// Forced skipping of method Windows.UI.Xaml.Interop.IBindableObservableVector.VectorChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		 event global::Windows.UI.Xaml.Interop.BindableVectorChangedEventHandler VectorChanged;
		#endif
	}
}
