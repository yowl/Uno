#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class PointCollection : global::System.Collections.Generic.IList<global::Windows.Foundation.Point>,global::System.Collections.Generic.IEnumerable<global::Windows.Foundation.Point>
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint PointCollection.Size is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.Media.PointCollection.PointCollection()
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.PointCollection()
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.GetAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.Size.get
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.GetView()
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.IndexOf(Windows.Foundation.Point, out uint)
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.SetAt(uint, Windows.Foundation.Point)
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.InsertAt(uint, Windows.Foundation.Point)
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.RemoveAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.Append(Windows.Foundation.Point)
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.RemoveAtEnd()
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.Clear()
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.GetMany(uint, Windows.Foundation.Point[])
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.ReplaceAll(Windows.Foundation.Point[])
		// Forced skipping of method Windows.UI.Xaml.Media.PointCollection.First()
		// Processing: System.Collections.Generic.IList<Windows.Foundation.Point>
		// Skipping already implement System.Collections.Generic.IList<Windows.Foundation.Point>.this[int]
		// Processing: System.Collections.Generic.ICollection<Windows.Foundation.Point>
		// Skipping already implement System.Collections.Generic.ICollection<Windows.Foundation.Point>.Count
		// Skipping already implement System.Collections.Generic.ICollection<Windows.Foundation.Point>.IsReadOnly
		// Processing: System.Collections.Generic.IEnumerable<Windows.Foundation.Point>
		// Processing: System.Collections.IEnumerable
	}
}
