#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScalarTransition 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan Duration
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan ScalarTransition.Duration is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.ScalarTransition", "TimeSpan ScalarTransition.Duration");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ScalarTransition() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.ScalarTransition", "ScalarTransition.ScalarTransition()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.ScalarTransition.ScalarTransition()
		// Forced skipping of method Windows.UI.Xaml.ScalarTransition.Duration.get
		// Forced skipping of method Windows.UI.Xaml.ScalarTransition.Duration.set
	}
}
