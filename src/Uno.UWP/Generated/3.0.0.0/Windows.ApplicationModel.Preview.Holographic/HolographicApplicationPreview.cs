#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Preview.Holographic
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HolographicApplicationPreview 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool IsCurrentViewPresentedOnHolographicDisplay()
		{
			throw new global::System.NotImplementedException("The member bool HolographicApplicationPreview.IsCurrentViewPresentedOnHolographicDisplay() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool IsHolographicActivation( global::Windows.ApplicationModel.Activation.IActivatedEventArgs activatedEventArgs)
		{
			throw new global::System.NotImplementedException("The member bool HolographicApplicationPreview.IsHolographicActivation(IActivatedEventArgs activatedEventArgs) is not implemented in Uno.");
		}
		#endif
	}
}
