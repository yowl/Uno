#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ResourceDictionary : global::Windows.UI.Xaml.DependencyObject,global::System.Collections.Generic.IDictionary<object, object>,global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<object, object>>
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint ResourceDictionary.Size is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property Source
		// Skipping already declared property MergedDictionaries
		// Skipping already declared property ThemeDictionaries
		// Skipping already declared method Windows.UI.Xaml.ResourceDictionary.ResourceDictionary()
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.ResourceDictionary()
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.Source.get
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.Source.set
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.MergedDictionaries.get
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.ThemeDictionaries.get
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.Lookup(object)
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.Size.get
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.HasKey(object)
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.GetView()
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.Insert(object, object)
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.Remove(object)
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.Clear()
		// Forced skipping of method Windows.UI.Xaml.ResourceDictionary.First()
		// Processing: System.Collections.Generic.IDictionary<object, object>
		// Skipping already implement System.Collections.Generic.IDictionary<object, object>.this[object]
		// Skipping already implement System.Collections.Generic.IDictionary<object, object>.Keys
		// Skipping already implement System.Collections.Generic.IDictionary<object, object>.Values
		// Processing: System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object, object>>
		// Skipping already implement System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object, object>>.Count
		// Skipping already implement System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object, object>>.IsReadOnly
		// Processing: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>>
		// Processing: System.Collections.IEnumerable
	}
}
