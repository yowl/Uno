#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RedirectVisual : global::Windows.UI.Composition.ContainerVisual
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Visual Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member Visual RedirectVisual.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.RedirectVisual", "Visual RedirectVisual.Source");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.RedirectVisual.Source.get
		// Forced skipping of method Windows.UI.Composition.RedirectVisual.Source.set
	}
}
