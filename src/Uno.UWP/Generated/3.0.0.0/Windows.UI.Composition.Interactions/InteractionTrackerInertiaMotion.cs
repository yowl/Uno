#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InteractionTrackerInertiaMotion : global::Windows.UI.Composition.Interactions.InteractionTrackerInertiaModifier
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.ExpressionAnimation Motion
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation InteractionTrackerInertiaMotion.Motion is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion", "ExpressionAnimation InteractionTrackerInertiaMotion.Motion");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.ExpressionAnimation Condition
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation InteractionTrackerInertiaMotion.Condition is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion", "ExpressionAnimation InteractionTrackerInertiaMotion.Condition");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion.Condition.get
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion.Condition.set
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion.Motion.get
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion.Motion.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion Create( global::Windows.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member InteractionTrackerInertiaMotion InteractionTrackerInertiaMotion.Create(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}
