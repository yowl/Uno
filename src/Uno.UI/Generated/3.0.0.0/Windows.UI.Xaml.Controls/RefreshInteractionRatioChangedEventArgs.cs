#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RefreshInteractionRatioChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double InteractionRatio
		{
			get
			{
				throw new global::System.NotImplementedException("The member double RefreshInteractionRatioChangedEventArgs.InteractionRatio is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshInteractionRatioChangedEventArgs.InteractionRatio.get
	}
}
