#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ChoosingItemContainerEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Primitives.SelectorItem ItemContainer
		{
			get
			{
				throw new global::System.NotImplementedException("The member SelectorItem ChoosingItemContainerEventArgs.ItemContainer is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs", "SelectorItem ChoosingItemContainerEventArgs.ItemContainer");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsContainerPrepared
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ChoosingItemContainerEventArgs.IsContainerPrepared is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs", "bool ChoosingItemContainerEventArgs.IsContainerPrepared");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Item
		{
			get
			{
				throw new global::System.NotImplementedException("The member object ChoosingItemContainerEventArgs.Item is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int ItemIndex
		{
			get
			{
				throw new global::System.NotImplementedException("The member int ChoosingItemContainerEventArgs.ItemIndex is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ChoosingItemContainerEventArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs", "ChoosingItemContainerEventArgs.ChoosingItemContainerEventArgs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs.ChoosingItemContainerEventArgs()
		// Forced skipping of method Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs.ItemIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs.Item.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs.ItemContainer.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs.ItemContainer.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs.IsContainerPrepared.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs.IsContainerPrepared.set
	}
}
