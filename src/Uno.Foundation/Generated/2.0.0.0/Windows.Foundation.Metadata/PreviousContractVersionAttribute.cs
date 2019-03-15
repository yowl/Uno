#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation.Metadata
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PreviousContractVersionAttribute : global::System.Attribute
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public PreviousContractVersionAttribute( string contract,  uint versionLow,  uint versionHigh,  string newContract) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Foundation.Metadata.PreviousContractVersionAttribute", "PreviousContractVersionAttribute.PreviousContractVersionAttribute(string contract, uint versionLow, uint versionHigh, string newContract)");
		}
		#endif
		// Forced skipping of method Windows.Foundation.Metadata.PreviousContractVersionAttribute.PreviousContractVersionAttribute(string, uint, uint, string)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public PreviousContractVersionAttribute( string contract,  uint versionLow,  uint versionHigh) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Foundation.Metadata.PreviousContractVersionAttribute", "PreviousContractVersionAttribute.PreviousContractVersionAttribute(string contract, uint versionLow, uint versionHigh)");
		}
		#endif
		// Forced skipping of method Windows.Foundation.Metadata.PreviousContractVersionAttribute.PreviousContractVersionAttribute(string, uint, uint)
	}
}
