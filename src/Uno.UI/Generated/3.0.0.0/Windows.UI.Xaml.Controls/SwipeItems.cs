#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SwipeItems : global::Windows.UI.Xaml.DependencyObject,global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.SwipeItem>,global::System.Collections.Generic.IEnumerable<global::Windows.UI.Xaml.Controls.SwipeItem>
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint SwipeItems.Size is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.SwipeMode Mode
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.SwipeMode)this.GetValue(ModeProperty);
			}
			set
			{
				this.SetValue(ModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Mode", typeof(global::Windows.UI.Xaml.Controls.SwipeMode), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeItems), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.SwipeMode)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.SwipeItems.SwipeItems()
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.SwipeItems()
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.Mode.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.Mode.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.GetAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.Size.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.GetView()
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.IndexOf(Windows.UI.Xaml.Controls.SwipeItem, out uint)
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.SetAt(uint, Windows.UI.Xaml.Controls.SwipeItem)
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.InsertAt(uint, Windows.UI.Xaml.Controls.SwipeItem)
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.RemoveAt(uint)
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.Append(Windows.UI.Xaml.Controls.SwipeItem)
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.RemoveAtEnd()
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.Clear()
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.GetMany(uint, Windows.UI.Xaml.Controls.SwipeItem[])
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.ReplaceAll(Windows.UI.Xaml.Controls.SwipeItem[])
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.First()
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItems.ModeProperty.get
		// Processing: System.Collections.Generic.IList<Windows.UI.Xaml.Controls.SwipeItem>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<Windows.UI.Xaml.Controls.SwipeItem>
		[global::Uno.NotImplemented]
		public int IndexOf( global::Windows.UI.Xaml.Controls.SwipeItem item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<Windows.UI.Xaml.Controls.SwipeItem>
		[global::Uno.NotImplemented]
		public void Insert( int index,  global::Windows.UI.Xaml.Controls.SwipeItem item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<Windows.UI.Xaml.Controls.SwipeItem>
		[global::Uno.NotImplemented]
		public void RemoveAt( int index)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public global::Windows.UI.Xaml.Controls.SwipeItem this[int index]
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
		// Processing: System.Collections.Generic.ICollection<Windows.UI.Xaml.Controls.SwipeItem>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Windows.UI.Xaml.Controls.SwipeItem>
		[global::Uno.NotImplemented]
		public void Add( global::Windows.UI.Xaml.Controls.SwipeItem item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Windows.UI.Xaml.Controls.SwipeItem>
		[global::Uno.NotImplemented]
		public void Clear()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Windows.UI.Xaml.Controls.SwipeItem>
		[global::Uno.NotImplemented]
		public bool Contains( global::Windows.UI.Xaml.Controls.SwipeItem item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Windows.UI.Xaml.Controls.SwipeItem>
		[global::Uno.NotImplemented]
		public void CopyTo( global::Windows.UI.Xaml.Controls.SwipeItem[] array,  int arrayIndex)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Windows.UI.Xaml.Controls.SwipeItem>
		[global::Uno.NotImplemented]
		public bool Remove( global::Windows.UI.Xaml.Controls.SwipeItem item)
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
		// Processing: System.Collections.Generic.IEnumerable<Windows.UI.Xaml.Controls.SwipeItem>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IEnumerable<Windows.UI.Xaml.Controls.SwipeItem>
		[global::Uno.NotImplemented]
		public global::System.Collections.Generic.IEnumerator<global::Windows.UI.Xaml.Controls.SwipeItem> GetEnumerator()
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
