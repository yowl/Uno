#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ConnectedAnimation 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsScaleAnimationEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ConnectedAnimation.IsScaleAnimationEnabled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.ConnectedAnimation", "bool ConnectedAnimation.IsScaleAnimationEnabled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Animation.ConnectedAnimationConfiguration Configuration
		{
			get
			{
				throw new global::System.NotImplementedException("The member ConnectedAnimationConfiguration ConnectedAnimation.Configuration is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.ConnectedAnimation", "ConnectedAnimationConfiguration ConnectedAnimation.Configuration");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ConnectedAnimation.Completed.add
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ConnectedAnimation.Completed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool TryStart( global::Windows.UI.Xaml.UIElement destination)
		{
			throw new global::System.NotImplementedException("The member bool ConnectedAnimation.TryStart(UIElement destination) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Cancel()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.ConnectedAnimation", "void ConnectedAnimation.Cancel()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ConnectedAnimation.IsScaleAnimationEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ConnectedAnimation.IsScaleAnimationEnabled.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool TryStart( global::Windows.UI.Xaml.UIElement destination,  global::System.Collections.Generic.IEnumerable<global::Windows.UI.Xaml.UIElement> coordinatedElements)
		{
			throw new global::System.NotImplementedException("The member bool ConnectedAnimation.TryStart(UIElement destination, IEnumerable<UIElement> coordinatedElements) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetAnimationComponent( global::Windows.UI.Xaml.Media.Animation.ConnectedAnimationComponent component,  global::Windows.UI.Composition.ICompositionAnimationBase animation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.ConnectedAnimation", "void ConnectedAnimation.SetAnimationComponent(ConnectedAnimationComponent component, ICompositionAnimationBase animation)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ConnectedAnimation.Configuration.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ConnectedAnimation.Configuration.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Media.Animation.ConnectedAnimation, object> Completed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.ConnectedAnimation", "event TypedEventHandler<ConnectedAnimation, object> ConnectedAnimation.Completed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.ConnectedAnimation", "event TypedEventHandler<ConnectedAnimation, object> ConnectedAnimation.Completed");
			}
		}
		#endif
	}
}
