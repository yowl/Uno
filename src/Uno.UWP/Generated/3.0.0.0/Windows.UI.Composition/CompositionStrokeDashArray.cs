#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionStrokeDashArray : global::Windows.UI.Composition.CompositionObject,global::System.Collections.Generic.IList<float>,global::System.Collections.Generic.IEnumerable<float>
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint CompositionStrokeDashArray.Size is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.GetAt(uint)
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.Size.get
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.GetView()
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.IndexOf(float, out uint)
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.SetAt(uint, float)
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.InsertAt(uint, float)
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.RemoveAt(uint)
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.Append(float)
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.RemoveAtEnd()
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.Clear()
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.GetMany(uint, float[])
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.ReplaceAll(float[])
		// Forced skipping of method Windows.UI.Composition.CompositionStrokeDashArray.First()
		// Processing: System.Collections.Generic.IList<float>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<float>
		[global::Uno.NotImplemented]
		public int IndexOf( float item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<float>
		[global::Uno.NotImplemented]
		public void Insert( int index,  float item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<float>
		[global::Uno.NotImplemented]
		public void RemoveAt( int index)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public float this[int index]
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
		// Processing: System.Collections.Generic.ICollection<float>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<float>
		[global::Uno.NotImplemented]
		public void Add( float item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<float>
		[global::Uno.NotImplemented]
		public void Clear()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<float>
		[global::Uno.NotImplemented]
		public bool Contains( float item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<float>
		[global::Uno.NotImplemented]
		public void CopyTo( float[] array,  int arrayIndex)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<float>
		[global::Uno.NotImplemented]
		public bool Remove( float item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public int Count
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
		// Processing: System.Collections.Generic.IEnumerable<float>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IEnumerable<float>
		[global::Uno.NotImplemented]
		public global::System.Collections.Generic.IEnumerator<float> GetEnumerator()
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
