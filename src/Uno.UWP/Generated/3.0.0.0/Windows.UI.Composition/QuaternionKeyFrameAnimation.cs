#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class QuaternionKeyFrameAnimation : global::Windows.UI.Composition.KeyFrameAnimation
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void InsertKeyFrame( float normalizedProgressKey,  global::System.Numerics.Quaternion value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.QuaternionKeyFrameAnimation", "void QuaternionKeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, Quaternion value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void InsertKeyFrame( float normalizedProgressKey,  global::System.Numerics.Quaternion value,  global::Windows.UI.Composition.CompositionEasingFunction easingFunction)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.QuaternionKeyFrameAnimation", "void QuaternionKeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, Quaternion value, CompositionEasingFunction easingFunction)");
		}
		#endif
	}
}
