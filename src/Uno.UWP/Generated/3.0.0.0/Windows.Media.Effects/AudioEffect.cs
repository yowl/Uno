#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AudioEffect 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Effects.AudioEffectType AudioEffectType
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioEffectType AudioEffect.AudioEffectType is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Effects.AudioEffect.AudioEffectType.get
	}
}
