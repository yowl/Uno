#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Diagnostics
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SystemMemoryUsage 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.Diagnostics.SystemMemoryUsageReport GetReport()
		{
			throw new global::System.NotImplementedException("The member SystemMemoryUsageReport SystemMemoryUsage.GetReport() is not implemented in Uno.");
		}
		#endif
	}
}
