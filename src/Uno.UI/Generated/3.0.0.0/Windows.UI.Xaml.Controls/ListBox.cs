#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ListBox : global::Windows.UI.Xaml.Controls.Primitives.Selector
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.SelectionMode SelectionMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.SelectionMode)this.GetValue(SelectionModeProperty);
			}
			set
			{
				this.SetValue(SelectionModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<object> SelectedItems
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<object> ListBox.SelectedItems is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool SingleSelectionFollowsFocus
		{
			get
			{
				return (bool)this.GetValue(SingleSelectionFollowsFocusProperty);
			}
			set
			{
				this.SetValue(SingleSelectionFollowsFocusProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SelectionModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SelectionMode", typeof(global::Windows.UI.Xaml.Controls.SelectionMode), 
			typeof(global::Windows.UI.Xaml.Controls.ListBox), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.SelectionMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SingleSelectionFollowsFocusProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SingleSelectionFollowsFocus", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.ListBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ListBox() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ListBox", "ListBox.ListBox()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ListBox.ListBox()
		// Forced skipping of method Windows.UI.Xaml.Controls.ListBox.SelectedItems.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListBox.SelectionMode.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListBox.SelectionMode.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ScrollIntoView( object item)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ListBox", "void ListBox.ScrollIntoView(object item)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SelectAll()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ListBox", "void ListBox.SelectAll()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ListBox.SingleSelectionFollowsFocus.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListBox.SingleSelectionFollowsFocus.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ListBox.SingleSelectionFollowsFocusProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListBox.SelectionModeProperty.get
	}
}
