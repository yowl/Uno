#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.DataTransfer
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DataPackage 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.DataTransfer.DataPackageOperation RequestedOperation
		{
			get
			{
				throw new global::System.NotImplementedException("The member DataPackageOperation DataPackage.RequestedOperation is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "DataPackageOperation DataPackage.RequestedOperation");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.DataTransfer.DataPackagePropertySet Properties
		{
			get
			{
				throw new global::System.NotImplementedException("The member DataPackagePropertySet DataPackage.Properties is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IDictionary<string, global::Windows.Storage.Streams.RandomAccessStreamReference> ResourceMap
		{
			get
			{
				throw new global::System.NotImplementedException("The member IDictionary<string, RandomAccessStreamReference> DataPackage.ResourceMap is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared method Windows.ApplicationModel.DataTransfer.DataPackage.DataPackage()
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataPackage.DataPackage()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.DataTransfer.DataPackageView GetView()
		{
			throw new global::System.NotImplementedException("The member DataPackageView DataPackage.GetView() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataPackage.Properties.get
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataPackage.RequestedOperation.get
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataPackage.RequestedOperation.set
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataPackage.OperationCompleted.add
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataPackage.OperationCompleted.remove
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataPackage.Destroyed.add
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataPackage.Destroyed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetData( string formatId,  object value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "void DataPackage.SetData(string formatId, object value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetDataProvider( string formatId,  global::Windows.ApplicationModel.DataTransfer.DataProviderHandler delayRenderer)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "void DataPackage.SetDataProvider(string formatId, DataProviderHandler delayRenderer)");
		}
		#endif
		#if false || false || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetText( string value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "void DataPackage.SetText(string value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetUri( global::System.Uri value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "void DataPackage.SetUri(Uri value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetHtmlFormat( string value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "void DataPackage.SetHtmlFormat(string value)");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataPackage.ResourceMap.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetRtf( string value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "void DataPackage.SetRtf(string value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetBitmap( global::Windows.Storage.Streams.RandomAccessStreamReference value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "void DataPackage.SetBitmap(RandomAccessStreamReference value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetStorageItems( global::System.Collections.Generic.IEnumerable<global::Windows.Storage.IStorageItem> value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "void DataPackage.SetStorageItems(IEnumerable<IStorageItem> value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetStorageItems( global::System.Collections.Generic.IEnumerable<global::Windows.Storage.IStorageItem> value,  bool readOnly)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "void DataPackage.SetStorageItems(IEnumerable<IStorageItem> value, bool readOnly)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetApplicationLink( global::System.Uri value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "void DataPackage.SetApplicationLink(Uri value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetWebLink( global::System.Uri value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "void DataPackage.SetWebLink(Uri value)");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataPackage.ShareCompleted.add
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataPackage.ShareCompleted.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.DataTransfer.DataPackage, object> Destroyed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "event TypedEventHandler<DataPackage, object> DataPackage.Destroyed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "event TypedEventHandler<DataPackage, object> DataPackage.Destroyed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.DataTransfer.DataPackage, global::Windows.ApplicationModel.DataTransfer.OperationCompletedEventArgs> OperationCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "event TypedEventHandler<DataPackage, OperationCompletedEventArgs> DataPackage.OperationCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "event TypedEventHandler<DataPackage, OperationCompletedEventArgs> DataPackage.OperationCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.DataTransfer.DataPackage, global::Windows.ApplicationModel.DataTransfer.ShareCompletedEventArgs> ShareCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "event TypedEventHandler<DataPackage, ShareCompletedEventArgs> DataPackage.ShareCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataPackage", "event TypedEventHandler<DataPackage, ShareCompletedEventArgs> DataPackage.ShareCompleted");
			}
		}
		#endif
	}
}
