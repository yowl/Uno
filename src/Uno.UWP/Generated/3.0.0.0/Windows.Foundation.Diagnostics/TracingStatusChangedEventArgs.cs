#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation.Diagnostics
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TracingStatusChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Enabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool TracingStatusChangedEventArgs.Enabled is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Diagnostics.CausalityTraceLevel TraceLevel
		{
			get
			{
				throw new global::System.NotImplementedException("The member CausalityTraceLevel TracingStatusChangedEventArgs.TraceLevel is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Foundation.Diagnostics.TracingStatusChangedEventArgs.Enabled.get
		// Forced skipping of method Windows.Foundation.Diagnostics.TracingStatusChangedEventArgs.TraceLevel.get
	}
}
