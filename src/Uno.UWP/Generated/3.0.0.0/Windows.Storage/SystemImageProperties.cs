#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SystemImageProperties 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string HorizontalSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member string SystemImageProperties.HorizontalSize is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string VerticalSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member string SystemImageProperties.VerticalSize is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Storage.SystemImageProperties.HorizontalSize.get
		// Forced skipping of method Windows.Storage.SystemImageProperties.VerticalSize.get
	}
}
