#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Vector2KeyFrameAnimation : global::Windows.UI.Composition.KeyFrameAnimation
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void InsertKeyFrame( float normalizedProgressKey,  global::System.Numerics.Vector2 value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Vector2KeyFrameAnimation", "void Vector2KeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, Vector2 value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void InsertKeyFrame( float normalizedProgressKey,  global::System.Numerics.Vector2 value,  global::Windows.UI.Composition.CompositionEasingFunction easingFunction)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Vector2KeyFrameAnimation", "void Vector2KeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, Vector2 value, CompositionEasingFunction easingFunction)");
		}
		#endif
	}
}
