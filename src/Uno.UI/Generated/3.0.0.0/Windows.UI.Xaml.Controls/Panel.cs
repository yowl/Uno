#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Panel : global::Windows.UI.Xaml.FrameworkElement
	{
		// Skipping already declared property ChildrenTransitions
		// Skipping already declared property Background
		// Skipping already declared property Children
		// Skipping already declared property IsItemsHost
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.BrushTransition BackgroundTransition
		{
			get
			{
				throw new global::System.NotImplementedException("The member BrushTransition Panel.BackgroundTransition is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Panel", "BrushTransition Panel.BackgroundTransition");
			}
		}
		#endif
		// Skipping already declared property BackgroundProperty
		// Skipping already declared property ChildrenTransitionsProperty
		// Skipping already declared property IsItemsHostProperty
		// Skipping already declared method Windows.UI.Xaml.Controls.Panel.Panel()
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.Panel()
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.Children.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.Background.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.Background.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.IsItemsHost.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.ChildrenTransitions.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.ChildrenTransitions.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.BackgroundTransition.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.BackgroundTransition.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.BackgroundProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.IsItemsHostProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Panel.ChildrenTransitionsProperty.get
	}
}
