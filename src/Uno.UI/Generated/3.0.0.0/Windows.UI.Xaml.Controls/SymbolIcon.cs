#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || NET461 || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SymbolIcon : global::Windows.UI.Xaml.Controls.IconElement
	{
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Symbol Symbol
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Symbol)this.GetValue(SymbolProperty);
			}
			set
			{
				this.SetValue(SymbolProperty, value);
			}
		}
		#endif
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SymbolProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Symbol", typeof(global::Windows.UI.Xaml.Controls.Symbol), 
			typeof(global::Windows.UI.Xaml.Controls.SymbolIcon), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.Symbol)));
		#endif
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public SymbolIcon( global::Windows.UI.Xaml.Controls.Symbol symbol) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SymbolIcon", "SymbolIcon.SymbolIcon(Symbol symbol)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SymbolIcon.SymbolIcon(Windows.UI.Xaml.Controls.Symbol)
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public SymbolIcon() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SymbolIcon", "SymbolIcon.SymbolIcon()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SymbolIcon.SymbolIcon()
		// Forced skipping of method Windows.UI.Xaml.Controls.SymbolIcon.Symbol.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SymbolIcon.Symbol.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SymbolIcon.SymbolProperty.get
	}
}
