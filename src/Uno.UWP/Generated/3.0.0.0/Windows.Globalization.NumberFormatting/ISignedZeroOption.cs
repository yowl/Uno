#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Globalization.NumberFormatting
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ISignedZeroOption 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsZeroSigned
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Windows.Globalization.NumberFormatting.ISignedZeroOption.IsZeroSigned.get
		// Forced skipping of method Windows.Globalization.NumberFormatting.ISignedZeroOption.IsZeroSigned.set
	}
}
