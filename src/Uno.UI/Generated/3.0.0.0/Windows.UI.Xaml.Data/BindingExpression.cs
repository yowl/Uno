#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Data
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class BindingExpression : global::Windows.UI.Xaml.Data.BindingExpressionBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object DataItem
		{
			get
			{
				throw new global::System.NotImplementedException("The member object BindingExpression.DataItem is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property ParentBinding
		// Forced skipping of method Windows.UI.Xaml.Data.BindingExpression.DataItem.get
		// Forced skipping of method Windows.UI.Xaml.Data.BindingExpression.ParentBinding.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void UpdateSource()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Data.BindingExpression", "void BindingExpression.UpdateSource()");
		}
		#endif
	}
}
