#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SelectionPatternIdentifiers 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.Automation.AutomationProperty CanSelectMultipleProperty
		{
			get
			{
				throw new global::System.NotImplementedException("The member AutomationProperty SelectionPatternIdentifiers.CanSelectMultipleProperty is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.Automation.AutomationProperty IsSelectionRequiredProperty
		{
			get
			{
				throw new global::System.NotImplementedException("The member AutomationProperty SelectionPatternIdentifiers.IsSelectionRequiredProperty is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.Automation.AutomationProperty SelectionProperty
		{
			get
			{
				throw new global::System.NotImplementedException("The member AutomationProperty SelectionPatternIdentifiers.SelectionProperty is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.SelectionPatternIdentifiers.CanSelectMultipleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Automation.SelectionPatternIdentifiers.IsSelectionRequiredProperty.get
		// Forced skipping of method Windows.UI.Xaml.Automation.SelectionPatternIdentifiers.SelectionProperty.get
	}
}
