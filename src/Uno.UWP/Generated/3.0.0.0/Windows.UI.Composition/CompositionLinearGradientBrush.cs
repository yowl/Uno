#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionLinearGradientBrush : global::Windows.UI.Composition.CompositionGradientBrush
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 StartPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionLinearGradientBrush.StartPoint is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionLinearGradientBrush", "Vector2 CompositionLinearGradientBrush.StartPoint");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 EndPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionLinearGradientBrush.EndPoint is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionLinearGradientBrush", "Vector2 CompositionLinearGradientBrush.EndPoint");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionLinearGradientBrush.EndPoint.get
		// Forced skipping of method Windows.UI.Composition.CompositionLinearGradientBrush.EndPoint.set
		// Forced skipping of method Windows.UI.Composition.CompositionLinearGradientBrush.StartPoint.get
		// Forced skipping of method Windows.UI.Composition.CompositionLinearGradientBrush.StartPoint.set
	}
}
