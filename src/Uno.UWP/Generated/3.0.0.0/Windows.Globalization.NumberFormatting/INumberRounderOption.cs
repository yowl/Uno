#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Globalization.NumberFormatting
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface INumberRounderOption 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Globalization.NumberFormatting.INumberRounder NumberRounder
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Windows.Globalization.NumberFormatting.INumberRounderOption.NumberRounder.get
		// Forced skipping of method Windows.Globalization.NumberFormatting.INumberRounderOption.NumberRounder.set
	}
}
