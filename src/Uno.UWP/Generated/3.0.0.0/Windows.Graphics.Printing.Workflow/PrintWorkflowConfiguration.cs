#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing.Workflow
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PrintWorkflowConfiguration 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string JobTitle
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PrintWorkflowConfiguration.JobTitle is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string SessionId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PrintWorkflowConfiguration.SessionId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string SourceAppDisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PrintWorkflowConfiguration.SourceAppDisplayName is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Graphics.Printing.Workflow.PrintWorkflowConfiguration.SourceAppDisplayName.get
		// Forced skipping of method Windows.Graphics.Printing.Workflow.PrintWorkflowConfiguration.JobTitle.get
		// Forced skipping of method Windows.Graphics.Printing.Workflow.PrintWorkflowConfiguration.SessionId.get
	}
}
