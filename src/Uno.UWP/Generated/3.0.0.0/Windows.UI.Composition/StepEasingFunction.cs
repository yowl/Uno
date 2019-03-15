#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StepEasingFunction : global::Windows.UI.Composition.CompositionEasingFunction
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int StepCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member int StepEasingFunction.StepCount is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.StepEasingFunction", "int StepEasingFunction.StepCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsInitialStepSingleFrame
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool StepEasingFunction.IsInitialStepSingleFrame is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.StepEasingFunction", "bool StepEasingFunction.IsInitialStepSingleFrame");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsFinalStepSingleFrame
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool StepEasingFunction.IsFinalStepSingleFrame is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.StepEasingFunction", "bool StepEasingFunction.IsFinalStepSingleFrame");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int InitialStep
		{
			get
			{
				throw new global::System.NotImplementedException("The member int StepEasingFunction.InitialStep is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.StepEasingFunction", "int StepEasingFunction.InitialStep");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int FinalStep
		{
			get
			{
				throw new global::System.NotImplementedException("The member int StepEasingFunction.FinalStep is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.StepEasingFunction", "int StepEasingFunction.FinalStep");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.StepEasingFunction.FinalStep.get
		// Forced skipping of method Windows.UI.Composition.StepEasingFunction.FinalStep.set
		// Forced skipping of method Windows.UI.Composition.StepEasingFunction.InitialStep.get
		// Forced skipping of method Windows.UI.Composition.StepEasingFunction.InitialStep.set
		// Forced skipping of method Windows.UI.Composition.StepEasingFunction.IsFinalStepSingleFrame.get
		// Forced skipping of method Windows.UI.Composition.StepEasingFunction.IsFinalStepSingleFrame.set
		// Forced skipping of method Windows.UI.Composition.StepEasingFunction.IsInitialStepSingleFrame.get
		// Forced skipping of method Windows.UI.Composition.StepEasingFunction.IsInitialStepSingleFrame.set
		// Forced skipping of method Windows.UI.Composition.StepEasingFunction.StepCount.get
		// Forced skipping of method Windows.UI.Composition.StepEasingFunction.StepCount.set
	}
}
