#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class TransformCollection : global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.Transform>,global::System.Collections.Generic.IEnumerable<global::Windows.UI.Xaml.Media.Transform>
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint TransformCollection.Size is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.Media.TransformCollection.TransformCollection()
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.TransformCollection()
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.GetAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.Size.get
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.GetView()
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.IndexOf(Windows.UI.Xaml.Media.Transform, out uint)
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.SetAt(uint, Windows.UI.Xaml.Media.Transform)
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.InsertAt(uint, Windows.UI.Xaml.Media.Transform)
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.RemoveAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.Append(Windows.UI.Xaml.Media.Transform)
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.RemoveAtEnd()
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.Clear()
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.GetMany(uint, Windows.UI.Xaml.Media.Transform[])
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.ReplaceAll(Windows.UI.Xaml.Media.Transform[])
		// Forced skipping of method Windows.UI.Xaml.Media.TransformCollection.First()
		// Processing: System.Collections.Generic.IList<Windows.UI.Xaml.Media.Transform>
		// Skipping already implement System.Collections.Generic.IList<Windows.UI.Xaml.Media.Transform>.this[int]
		// Processing: System.Collections.Generic.ICollection<Windows.UI.Xaml.Media.Transform>
		// Skipping already implement System.Collections.Generic.ICollection<Windows.UI.Xaml.Media.Transform>.Count
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
		// Processing: System.Collections.Generic.IEnumerable<Windows.UI.Xaml.Media.Transform>
		// Processing: System.Collections.IEnumerable
	}
}
