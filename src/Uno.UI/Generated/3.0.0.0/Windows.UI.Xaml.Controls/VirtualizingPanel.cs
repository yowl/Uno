#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class VirtualizingPanel : global::Windows.UI.Xaml.Controls.Panel
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.ItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				throw new global::System.NotImplementedException("The member ItemContainerGenerator VirtualizingPanel.ItemContainerGenerator is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.VirtualizingPanel.ItemContainerGenerator.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected  void AddInternalChild( global::Windows.UI.Xaml.UIElement child)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.VirtualizingPanel", "void VirtualizingPanel.AddInternalChild(UIElement child)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected  void InsertInternalChild( int index,  global::Windows.UI.Xaml.UIElement child)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.VirtualizingPanel", "void VirtualizingPanel.InsertInternalChild(int index, UIElement child)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected  void RemoveInternalChildRange( int index,  int range)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.VirtualizingPanel", "void VirtualizingPanel.RemoveInternalChildRange(int index, int range)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnItemsChanged( object sender,  global::Windows.UI.Xaml.Controls.Primitives.ItemsChangedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.VirtualizingPanel", "void VirtualizingPanel.OnItemsChanged(object sender, ItemsChangedEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnClearChildren()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.VirtualizingPanel", "void VirtualizingPanel.OnClearChildren()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void BringIndexIntoView( int index)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.VirtualizingPanel", "void VirtualizingPanel.BringIndexIntoView(int index)");
		}
		#endif
	}
}
