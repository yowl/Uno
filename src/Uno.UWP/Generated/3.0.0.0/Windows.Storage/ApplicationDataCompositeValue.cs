#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ApplicationDataCompositeValue : global::Windows.Foundation.Collections.IPropertySet,global::Windows.Foundation.Collections.IObservableMap<string, object>,global::System.Collections.Generic.IDictionary<string, object>,global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint ApplicationDataCompositeValue.Size is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ApplicationDataCompositeValue() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.ApplicationDataCompositeValue", "ApplicationDataCompositeValue.ApplicationDataCompositeValue()");
		}
		#endif
		// Forced skipping of method Windows.Storage.ApplicationDataCompositeValue.ApplicationDataCompositeValue()
		// Forced skipping of method Windows.Storage.ApplicationDataCompositeValue.MapChanged.add
		// Forced skipping of method Windows.Storage.ApplicationDataCompositeValue.MapChanged.remove
		// Forced skipping of method Windows.Storage.ApplicationDataCompositeValue.Lookup(string)
		// Forced skipping of method Windows.Storage.ApplicationDataCompositeValue.Size.get
		// Forced skipping of method Windows.Storage.ApplicationDataCompositeValue.HasKey(string)
		// Forced skipping of method Windows.Storage.ApplicationDataCompositeValue.GetView()
		// Forced skipping of method Windows.Storage.ApplicationDataCompositeValue.Insert(string, object)
		// Forced skipping of method Windows.Storage.ApplicationDataCompositeValue.Remove(string)
		// Forced skipping of method Windows.Storage.ApplicationDataCompositeValue.Clear()
		// Forced skipping of method Windows.Storage.ApplicationDataCompositeValue.First()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.Collections.MapChangedEventHandler<string, object> MapChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.ApplicationDataCompositeValue", "event MapChangedEventHandler<string, object> ApplicationDataCompositeValue.MapChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.ApplicationDataCompositeValue", "event MapChangedEventHandler<string, object> ApplicationDataCompositeValue.MapChanged");
			}
		}
		#endif
		// Processing: Windows.Foundation.Collections.IPropertySet
		// Processing: Windows.Foundation.Collections.IObservableMap<string, object>
		// Processing: System.Collections.Generic.IDictionary<string, object>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IDictionary<string, object>
		[global::Uno.NotImplemented]
		public void Add( string key,  object value)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IDictionary<string, object>
		[global::Uno.NotImplemented]
		public bool ContainsKey( string key)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IDictionary<string, object>
		[global::Uno.NotImplemented]
		public bool Remove( string key)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IDictionary<string, object>
		[global::Uno.NotImplemented]
		public bool TryGetValue( string key, out object value)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public object this[string key]
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
		public global::System.Collections.Generic.ICollection<string> Keys
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
		public global::System.Collections.Generic.ICollection<object> Values
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
		// Processing: System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>
		[global::Uno.NotImplemented]
		public void Add( global::System.Collections.Generic.KeyValuePair<string, object> item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>
		[global::Uno.NotImplemented]
		public void Clear()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>
		[global::Uno.NotImplemented]
		public bool Contains( global::System.Collections.Generic.KeyValuePair<string, object> item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>
		[global::Uno.NotImplemented]
		public void CopyTo( global::System.Collections.Generic.KeyValuePair<string, object>[] array,  int arrayIndex)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>
		[global::Uno.NotImplemented]
		public bool Remove( global::System.Collections.Generic.KeyValuePair<string, object> item)
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
		// Processing: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>
		[global::Uno.NotImplemented]
		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator()
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
