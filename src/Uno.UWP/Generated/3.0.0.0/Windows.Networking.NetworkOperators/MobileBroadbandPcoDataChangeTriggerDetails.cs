#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MobileBroadbandPcoDataChangeTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Networking.NetworkOperators.MobileBroadbandPco UpdatedData
		{
			get
			{
				throw new global::System.NotImplementedException("The member MobileBroadbandPco MobileBroadbandPcoDataChangeTriggerDetails.UpdatedData is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandPcoDataChangeTriggerDetails.UpdatedData.get
	}
}
