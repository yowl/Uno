#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ListPickerFlyout : global::Windows.UI.Xaml.Controls.Primitives.PickerFlyoutBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.ListPickerFlyoutSelectionMode SelectionMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ListPickerFlyoutSelectionMode)this.GetValue(SelectionModeProperty);
			}
			set
			{
				this.SetValue(SelectionModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string SelectedValuePath
		{
			get
			{
				return (string)this.GetValue(SelectedValuePathProperty);
			}
			set
			{
				this.SetValue(SelectedValuePathProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object SelectedValue
		{
			get
			{
				return (object)this.GetValue(SelectedValueProperty);
			}
			set
			{
				this.SetValue(SelectedValueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object SelectedItem
		{
			get
			{
				return (object)this.GetValue(SelectedItemProperty);
			}
			set
			{
				this.SetValue(SelectedItemProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int SelectedIndex
		{
			get
			{
				return (int)this.GetValue(SelectedIndexProperty);
			}
			set
			{
				this.SetValue(SelectedIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object ItemsSource
		{
			get
			{
				return (object)this.GetValue(ItemsSourceProperty);
			}
			set
			{
				this.SetValue(ItemsSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.DataTemplate ItemTemplate
		{
			get
			{
				return (global::Windows.UI.Xaml.DataTemplate)this.GetValue(ItemTemplateProperty);
			}
			set
			{
				this.SetValue(ItemTemplateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string DisplayMemberPath
		{
			get
			{
				return (string)this.GetValue(DisplayMemberPathProperty);
			}
			set
			{
				this.SetValue(DisplayMemberPathProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<object> SelectedItems
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<object> ListPickerFlyout.SelectedItems is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DisplayMemberPathProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"DisplayMemberPath", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.ListPickerFlyout), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ItemTemplateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ItemTemplate", typeof(global::Windows.UI.Xaml.DataTemplate), 
			typeof(global::Windows.UI.Xaml.Controls.ListPickerFlyout), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ItemsSourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ItemsSource", typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.ListPickerFlyout), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SelectedIndexProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SelectedIndex", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.ListPickerFlyout), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SelectedItemProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SelectedItem", typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.ListPickerFlyout), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SelectedValuePathProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SelectedValuePath", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.ListPickerFlyout), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SelectedValueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SelectedValue", typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.ListPickerFlyout), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SelectionModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SelectionMode", typeof(global::Windows.UI.Xaml.Controls.ListPickerFlyoutSelectionMode), 
			typeof(global::Windows.UI.Xaml.Controls.ListPickerFlyout), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.ListPickerFlyoutSelectionMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ListPickerFlyout() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ListPickerFlyout", "ListPickerFlyout.ListPickerFlyout()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.ListPickerFlyout()
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.ItemsSource.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.ItemsSource.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.ItemTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.ItemTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.DisplayMemberPath.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.DisplayMemberPath.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectionMode.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectionMode.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedIndex.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedItem.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedItem.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedValue.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedValue.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedValuePath.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedValuePath.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedItems.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.ItemsPicked.add
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.ItemsPicked.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<object>> ShowAtAsync( global::Windows.UI.Xaml.FrameworkElement target)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<object>> ListPickerFlyout.ShowAtAsync(FrameworkElement target) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.ItemsSourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.ItemTemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.DisplayMemberPathProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectionModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedIndexProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedItemProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedValueProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ListPickerFlyout.SelectedValuePathProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.ListPickerFlyout, global::Windows.UI.Xaml.Controls.ItemsPickedEventArgs> ItemsPicked
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ListPickerFlyout", "event TypedEventHandler<ListPickerFlyout, ItemsPickedEventArgs> ListPickerFlyout.ItemsPicked");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ListPickerFlyout", "event TypedEventHandler<ListPickerFlyout, ItemsPickedEventArgs> ListPickerFlyout.ItemsPicked");
			}
		}
		#endif
	}
}
