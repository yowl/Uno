#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Vector3Transition 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan Duration
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan Vector3Transition.Duration is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Vector3Transition", "TimeSpan Vector3Transition.Duration");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Vector3TransitionComponents Components
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3TransitionComponents Vector3Transition.Components is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Vector3Transition", "Vector3TransitionComponents Vector3Transition.Components");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public Vector3Transition() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Vector3Transition", "Vector3Transition.Vector3Transition()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Vector3Transition.Vector3Transition()
		// Forced skipping of method Windows.UI.Xaml.Vector3Transition.Duration.get
		// Forced skipping of method Windows.UI.Xaml.Vector3Transition.Duration.set
		// Forced skipping of method Windows.UI.Xaml.Vector3Transition.Components.get
		// Forced skipping of method Windows.UI.Xaml.Vector3Transition.Components.set
	}
}
