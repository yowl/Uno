#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SceneAnalyzedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Core.SceneAnalysisEffectFrame ResultFrame
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneAnalysisEffectFrame SceneAnalyzedEventArgs.ResultFrame is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Core.SceneAnalyzedEventArgs.ResultFrame.get
	}
}
