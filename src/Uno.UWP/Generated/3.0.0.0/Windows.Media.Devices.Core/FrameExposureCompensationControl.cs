#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FrameExposureCompensationControl 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float? Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member float? FrameExposureCompensationControl.Value is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.Core.FrameExposureCompensationControl", "float? FrameExposureCompensationControl.Value");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Devices.Core.FrameExposureCompensationControl.Value.get
		// Forced skipping of method Windows.Media.Devices.Core.FrameExposureCompensationControl.Value.set
	}
}
