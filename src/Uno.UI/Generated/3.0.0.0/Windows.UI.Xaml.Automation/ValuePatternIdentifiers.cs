#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ValuePatternIdentifiers 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.Automation.AutomationProperty IsReadOnlyProperty
		{
			get
			{
				throw new global::System.NotImplementedException("The member AutomationProperty ValuePatternIdentifiers.IsReadOnlyProperty is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.Automation.AutomationProperty ValueProperty
		{
			get
			{
				throw new global::System.NotImplementedException("The member AutomationProperty ValuePatternIdentifiers.ValueProperty is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.ValuePatternIdentifiers.IsReadOnlyProperty.get
		// Forced skipping of method Windows.UI.Xaml.Automation.ValuePatternIdentifiers.ValueProperty.get
	}
}
