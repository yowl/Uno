#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Documents
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class BlockCollection : global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Documents.Block>,global::System.Collections.Generic.IEnumerable<global::Windows.UI.Xaml.Documents.Block>
	{
		// Skipping already declared property Size
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.GetAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.Size.get
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.GetView()
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.IndexOf(Windows.UI.Xaml.Documents.Block, out uint)
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.SetAt(uint, Windows.UI.Xaml.Documents.Block)
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.InsertAt(uint, Windows.UI.Xaml.Documents.Block)
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.RemoveAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.Append(Windows.UI.Xaml.Documents.Block)
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.RemoveAtEnd()
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.Clear()
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.GetMany(uint, Windows.UI.Xaml.Documents.Block[])
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.ReplaceAll(Windows.UI.Xaml.Documents.Block[])
		// Forced skipping of method Windows.UI.Xaml.Documents.BlockCollection.First()
		// Processing: System.Collections.Generic.IList<Windows.UI.Xaml.Documents.Block>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public global::Windows.UI.Xaml.Documents.Block this[int index]
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}
		#endif
		// Processing: System.Collections.Generic.ICollection<Windows.UI.Xaml.Documents.Block>
		// Skipping already implement System.Collections.Generic.ICollection<Windows.UI.Xaml.Documents.Block>.Count
		// Skipping already implement System.Collections.Generic.ICollection<Windows.UI.Xaml.Documents.Block>.IsReadOnly
		// Processing: System.Collections.Generic.IEnumerable<Windows.UI.Xaml.Documents.Block>
		// Processing: System.Collections.IEnumerable
	}
}
