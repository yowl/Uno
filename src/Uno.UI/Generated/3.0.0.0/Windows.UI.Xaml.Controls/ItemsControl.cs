#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ItemsControl : global::Windows.UI.Xaml.Controls.Control,global::Windows.UI.Xaml.Controls.IItemContainerMapping
	{
		// Skipping already declared property ItemsSource
		// Skipping already declared property ItemsPanel
		// Skipping already declared property ItemTemplateSelector
		// Skipping already declared property ItemTemplate
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Animation.TransitionCollection ItemContainerTransitions
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Animation.TransitionCollection)this.GetValue(ItemContainerTransitionsProperty);
			}
			set
			{
				this.SetValue(ItemContainerTransitionsProperty, value);
			}
		}
		#endif
		// Skipping already declared property ItemContainerStyleSelector
		// Skipping already declared property ItemContainerStyle
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.GroupStyleSelector GroupStyleSelector
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.GroupStyleSelector)this.GetValue(GroupStyleSelectorProperty);
			}
			set
			{
				this.SetValue(GroupStyleSelectorProperty, value);
			}
		}
		#endif
		// Skipping already declared property DisplayMemberPath
		// Skipping already declared property GroupStyle
		// Skipping already declared property IsGrouping
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.ItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				throw new global::System.NotImplementedException("The member ItemContainerGenerator ItemsControl.ItemContainerGenerator is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property Items
		// Skipping already declared property ItemsPanelRoot
		// Skipping already declared property DisplayMemberPathProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty GroupStyleSelectorProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"GroupStyleSelector", typeof(global::Windows.UI.Xaml.Controls.GroupStyleSelector), 
			typeof(global::Windows.UI.Xaml.Controls.ItemsControl), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.GroupStyleSelector)));
		#endif
		// Skipping already declared property IsGroupingProperty
		// Skipping already declared property ItemContainerStyleProperty
		// Skipping already declared property ItemContainerStyleSelectorProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ItemContainerTransitionsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ItemContainerTransitions", typeof(global::Windows.UI.Xaml.Media.Animation.TransitionCollection), 
			typeof(global::Windows.UI.Xaml.Controls.ItemsControl), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Animation.TransitionCollection)));
		#endif
		// Skipping already declared property ItemTemplateProperty
		// Skipping already declared property ItemTemplateSelectorProperty
		// Skipping already declared property ItemsPanelProperty
		// Skipping already declared property ItemsSourceProperty
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.ItemsControl()
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemsControl()
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemsSource.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemsSource.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.Items.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemTemplateSelector.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemTemplateSelector.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemsPanel.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemsPanel.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.DisplayMemberPath.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.DisplayMemberPath.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemContainerStyle.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemContainerStyle.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemContainerStyleSelector.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemContainerStyleSelector.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemContainerGenerator.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemContainerTransitions.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemContainerTransitions.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.GroupStyle.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.GroupStyleSelector.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.GroupStyleSelector.set
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.IsGrouping.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemsPanelRoot.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.DependencyObject GroupHeaderContainerFromItemContainer( global::Windows.UI.Xaml.DependencyObject itemContainer)
		{
			throw new global::System.NotImplementedException("The member DependencyObject ItemsControl.GroupHeaderContainerFromItemContainer(DependencyObject itemContainer) is not implemented in Uno.");
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.IsItemItsOwnContainerOverride(object)
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.GetContainerForItemOverride()
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.ClearContainerForItemOverride(Windows.UI.Xaml.DependencyObject, object)
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.PrepareContainerForItemOverride(Windows.UI.Xaml.DependencyObject, object)
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.OnItemsChanged(object)
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.OnItemContainerStyleChanged(Windows.UI.Xaml.Style, Windows.UI.Xaml.Style)
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.OnItemContainerStyleSelectorChanged(Windows.UI.Xaml.Controls.StyleSelector, Windows.UI.Xaml.Controls.StyleSelector)
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.OnItemTemplateChanged(Windows.UI.Xaml.DataTemplate, Windows.UI.Xaml.DataTemplate)
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.OnItemTemplateSelectorChanged(Windows.UI.Xaml.Controls.DataTemplateSelector, Windows.UI.Xaml.Controls.DataTemplateSelector)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnGroupStyleSelectorChanged( global::Windows.UI.Xaml.Controls.GroupStyleSelector oldGroupStyleSelector,  global::Windows.UI.Xaml.Controls.GroupStyleSelector newGroupStyleSelector)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ItemsControl", "void ItemsControl.OnGroupStyleSelectorChanged(GroupStyleSelector oldGroupStyleSelector, GroupStyleSelector newGroupStyleSelector)");
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.ItemFromContainer(Windows.UI.Xaml.DependencyObject)
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.ContainerFromItem(object)
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.IndexFromContainer(Windows.UI.Xaml.DependencyObject)
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.ContainerFromIndex(int)
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemsSourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemTemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemTemplateSelectorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemsPanelProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.DisplayMemberPathProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemContainerStyleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemContainerStyleSelectorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.ItemContainerTransitionsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.GroupStyleSelectorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ItemsControl.IsGroupingProperty.get
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.GetItemsOwner(Windows.UI.Xaml.DependencyObject)
		// Skipping already declared method Windows.UI.Xaml.Controls.ItemsControl.ItemsControlFromItemContainer(Windows.UI.Xaml.DependencyObject)
		// Processing: Windows.UI.Xaml.Controls.IItemContainerMapping
	}
}
