#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LinearPointKeyFrame : global::Windows.UI.Xaml.Media.Animation.PointKeyFrame
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public LinearPointKeyFrame() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.LinearPointKeyFrame", "LinearPointKeyFrame.LinearPointKeyFrame()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.LinearPointKeyFrame.LinearPointKeyFrame()
	}
}
