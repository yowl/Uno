#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InteractionSourceConfiguration : global::Windows.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Interactions.InteractionSourceRedirectionMode ScaleSourceMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member InteractionSourceRedirectionMode InteractionSourceConfiguration.ScaleSourceMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.InteractionSourceConfiguration", "InteractionSourceRedirectionMode InteractionSourceConfiguration.ScaleSourceMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Interactions.InteractionSourceRedirectionMode PositionYSourceMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member InteractionSourceRedirectionMode InteractionSourceConfiguration.PositionYSourceMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.InteractionSourceConfiguration", "InteractionSourceRedirectionMode InteractionSourceConfiguration.PositionYSourceMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Interactions.InteractionSourceRedirectionMode PositionXSourceMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member InteractionSourceRedirectionMode InteractionSourceConfiguration.PositionXSourceMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.InteractionSourceConfiguration", "InteractionSourceRedirectionMode InteractionSourceConfiguration.PositionXSourceMode");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionXSourceMode.get
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionXSourceMode.set
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionYSourceMode.get
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionYSourceMode.set
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.ScaleSourceMode.get
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.ScaleSourceMode.set
	}
}
