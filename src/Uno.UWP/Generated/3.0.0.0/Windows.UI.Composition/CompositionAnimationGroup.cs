#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionAnimationGroup : global::Windows.UI.Composition.CompositionObject,global::System.Collections.Generic.IEnumerable<global::Windows.UI.Composition.CompositionAnimation>,global::Windows.UI.Composition.ICompositionAnimationBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int Count
		{
			get
			{
				throw new global::System.NotImplementedException("The member int CompositionAnimationGroup.Count is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionAnimationGroup.Count.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Add( global::Windows.UI.Composition.CompositionAnimation value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionAnimationGroup", "void CompositionAnimationGroup.Add(CompositionAnimation value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Remove( global::Windows.UI.Composition.CompositionAnimation value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionAnimationGroup", "void CompositionAnimationGroup.Remove(CompositionAnimation value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void RemoveAll()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionAnimationGroup", "void CompositionAnimationGroup.RemoveAll()");
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionAnimationGroup.First()
		// Processing: System.Collections.Generic.IEnumerable<Windows.UI.Composition.CompositionAnimation>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IEnumerable<Windows.UI.Composition.CompositionAnimation>
		[global::Uno.NotImplemented]
		public global::System.Collections.Generic.IEnumerator<global::Windows.UI.Composition.CompositionAnimation> GetEnumerator()
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
		// Processing: Windows.UI.Composition.ICompositionAnimationBase
	}
}
