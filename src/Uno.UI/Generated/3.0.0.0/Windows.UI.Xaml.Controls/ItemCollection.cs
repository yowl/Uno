#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ItemCollection : global::Windows.Foundation.Collections.IObservableVector<object>,global::System.Collections.Generic.IList<object>,global::System.Collections.Generic.IEnumerable<object>
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint ItemCollection.Size is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.VectorChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.VectorChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.GetAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.Size.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.GetView()
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.IndexOf(object, out uint)
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.SetAt(uint, object)
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.InsertAt(uint, object)
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.RemoveAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.Append(object)
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.RemoveAtEnd()
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.Clear()
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.GetMany(uint, object[])
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.ReplaceAll(object[])
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemCollection.First()
		// Skipping already declared event Windows.UI.Xaml.Controls.ItemCollection.VectorChanged
		// Processing: Windows.Foundation.Collections.IObservableVector<object>
		// Processing: System.Collections.Generic.IList<object>
		// Skipping already implement System.Collections.Generic.IList<object>.this[int]
		// Processing: System.Collections.Generic.ICollection<object>
		// Skipping already implement System.Collections.Generic.ICollection<object>.Count
		// Skipping already implement System.Collections.Generic.ICollection<object>.IsReadOnly
		// Processing: System.Collections.Generic.IEnumerable<object>
		// Processing: System.Collections.IEnumerable
	}
}
