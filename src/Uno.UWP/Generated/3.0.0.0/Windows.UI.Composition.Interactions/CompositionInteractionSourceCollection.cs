#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionInteractionSourceCollection : global::Windows.UI.Composition.CompositionObject,global::System.Collections.Generic.IEnumerable<global::Windows.UI.Composition.Interactions.ICompositionInteractionSource>
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int Count
		{
			get
			{
				throw new global::System.NotImplementedException("The member int CompositionInteractionSourceCollection.Count is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Interactions.CompositionInteractionSourceCollection.Count.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Add( global::Windows.UI.Composition.Interactions.ICompositionInteractionSource value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.CompositionInteractionSourceCollection", "void CompositionInteractionSourceCollection.Add(ICompositionInteractionSource value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Remove( global::Windows.UI.Composition.Interactions.ICompositionInteractionSource value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.CompositionInteractionSourceCollection", "void CompositionInteractionSourceCollection.Remove(ICompositionInteractionSource value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void RemoveAll()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.CompositionInteractionSourceCollection", "void CompositionInteractionSourceCollection.RemoveAll()");
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Interactions.CompositionInteractionSourceCollection.First()
		// Processing: System.Collections.Generic.IEnumerable<Windows.UI.Composition.Interactions.ICompositionInteractionSource>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IEnumerable<Windows.UI.Composition.Interactions.ICompositionInteractionSource>
		[global::Uno.NotImplemented]
		public global::System.Collections.Generic.IEnumerator<global::Windows.UI.Composition.Interactions.ICompositionInteractionSource> GetEnumerator()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		// Processing: System.Collections.IEnumerable
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.IEnumerable
		[global::Uno.NotImplemented]
		 global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
	}
}
