#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TextBoxSelectionChangingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool TextBoxSelectionChangingEventArgs.Cancel is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.TextBoxSelectionChangingEventArgs", "bool TextBoxSelectionChangingEventArgs.Cancel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int SelectionLength
		{
			get
			{
				throw new global::System.NotImplementedException("The member int TextBoxSelectionChangingEventArgs.SelectionLength is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int SelectionStart
		{
			get
			{
				throw new global::System.NotImplementedException("The member int TextBoxSelectionChangingEventArgs.SelectionStart is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TextBoxSelectionChangingEventArgs.SelectionStart.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TextBoxSelectionChangingEventArgs.SelectionLength.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TextBoxSelectionChangingEventArgs.Cancel.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TextBoxSelectionChangingEventArgs.Cancel.set
	}
}
