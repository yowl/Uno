#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MobileBroadbandRadioStateChangeTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.NetworkOperators.MobileBroadbandRadioStateChange> RadioStateChanges
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<MobileBroadbandRadioStateChange> MobileBroadbandRadioStateChangeTriggerDetails.RadioStateChanges is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandRadioStateChangeTriggerDetails.RadioStateChanges.get
	}
}
