#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionCommitBatch : global::Windows.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsActive
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CompositionCommitBatch.IsActive is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsEnded
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CompositionCommitBatch.IsEnded is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionCommitBatch.IsActive.get
		// Forced skipping of method Windows.UI.Composition.CompositionCommitBatch.IsEnded.get
		// Forced skipping of method Windows.UI.Composition.CompositionCommitBatch.Completed.add
		// Forced skipping of method Windows.UI.Composition.CompositionCommitBatch.Completed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<object, global::Windows.UI.Composition.CompositionBatchCompletedEventArgs> Completed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionCommitBatch", "event TypedEventHandler<object, CompositionBatchCompletedEventArgs> CompositionCommitBatch.Completed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionCommitBatch", "event TypedEventHandler<object, CompositionBatchCompletedEventArgs> CompositionCommitBatch.Completed");
			}
		}
		#endif
	}
}
