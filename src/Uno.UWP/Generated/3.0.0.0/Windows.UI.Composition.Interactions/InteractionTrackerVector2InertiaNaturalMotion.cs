#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InteractionTrackerVector2InertiaNaturalMotion : global::Windows.UI.Composition.Interactions.InteractionTrackerVector2InertiaModifier
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Vector2NaturalMotionAnimation NaturalMotion
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2NaturalMotionAnimation InteractionTrackerVector2InertiaNaturalMotion.NaturalMotion is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.InteractionTrackerVector2InertiaNaturalMotion", "Vector2NaturalMotionAnimation InteractionTrackerVector2InertiaNaturalMotion.NaturalMotion");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.ExpressionAnimation Condition
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation InteractionTrackerVector2InertiaNaturalMotion.Condition is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.InteractionTrackerVector2InertiaNaturalMotion", "ExpressionAnimation InteractionTrackerVector2InertiaNaturalMotion.Condition");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionTrackerVector2InertiaNaturalMotion.Condition.get
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionTrackerVector2InertiaNaturalMotion.Condition.set
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionTrackerVector2InertiaNaturalMotion.NaturalMotion.get
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionTrackerVector2InertiaNaturalMotion.NaturalMotion.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Composition.Interactions.InteractionTrackerVector2InertiaNaturalMotion Create( global::Windows.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member InteractionTrackerVector2InertiaNaturalMotion InteractionTrackerVector2InertiaNaturalMotion.Create(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}
