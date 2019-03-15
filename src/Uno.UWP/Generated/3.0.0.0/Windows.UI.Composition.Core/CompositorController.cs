#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositorController : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Compositor Compositor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Compositor CompositorController.Compositor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CompositorController() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Core.CompositorController", "CompositorController.CompositorController()");
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Core.CompositorController.CompositorController()
		// Forced skipping of method Windows.UI.Composition.Core.CompositorController.Compositor.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Commit()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Core.CompositorController", "void CompositorController.Commit()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncAction EnsurePreviousCommitCompletedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction CompositorController.EnsurePreviousCommitCompletedAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Core.CompositorController.CommitNeeded.add
		// Forced skipping of method Windows.UI.Composition.Core.CompositorController.CommitNeeded.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Core.CompositorController", "void CompositorController.Dispose()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Composition.Core.CompositorController, object> CommitNeeded
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Core.CompositorController", "event TypedEventHandler<CompositorController, object> CompositorController.CommitNeeded");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Core.CompositorController", "event TypedEventHandler<CompositorController, object> CompositorController.CommitNeeded");
			}
		}
		#endif
		// Processing: System.IDisposable
	}
}
