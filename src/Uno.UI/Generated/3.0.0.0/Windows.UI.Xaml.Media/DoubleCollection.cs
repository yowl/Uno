#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DoubleCollection : global::System.Collections.Generic.IList<double>,global::System.Collections.Generic.IEnumerable<double>
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint DoubleCollection.Size is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.Media.DoubleCollection.DoubleCollection()
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.DoubleCollection()
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.GetAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.Size.get
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.GetView()
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.IndexOf(double, out uint)
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.SetAt(uint, double)
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.InsertAt(uint, double)
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.RemoveAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.Append(double)
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.RemoveAtEnd()
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.Clear()
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.GetMany(uint, double[])
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.ReplaceAll(double[])
		// Forced skipping of method Windows.UI.Xaml.Media.DoubleCollection.First()
		// Processing: System.Collections.Generic.IList<double>
		// Skipping already implement System.Collections.Generic.IList<double>.this[int]
		// Processing: System.Collections.Generic.ICollection<double>
		// Skipping already implement System.Collections.Generic.ICollection<double>.Count
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public bool IsReadOnly
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
		// Processing: System.Collections.Generic.IEnumerable<double>
		// Processing: System.Collections.IEnumerable
	}
}
