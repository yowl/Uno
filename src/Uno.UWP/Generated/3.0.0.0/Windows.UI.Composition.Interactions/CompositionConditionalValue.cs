#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionConditionalValue : global::Windows.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.ExpressionAnimation Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation CompositionConditionalValue.Value is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.CompositionConditionalValue", "ExpressionAnimation CompositionConditionalValue.Value");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.ExpressionAnimation Condition
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation CompositionConditionalValue.Condition is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.CompositionConditionalValue", "ExpressionAnimation CompositionConditionalValue.Condition");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Interactions.CompositionConditionalValue.Condition.get
		// Forced skipping of method Windows.UI.Composition.Interactions.CompositionConditionalValue.Condition.set
		// Forced skipping of method Windows.UI.Composition.Interactions.CompositionConditionalValue.Value.get
		// Forced skipping of method Windows.UI.Composition.Interactions.CompositionConditionalValue.Value.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Composition.Interactions.CompositionConditionalValue Create( global::Windows.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member CompositionConditionalValue CompositionConditionalValue.Create(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}
