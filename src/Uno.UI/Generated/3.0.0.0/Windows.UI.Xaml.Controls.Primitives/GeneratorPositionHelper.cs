#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GeneratorPositionHelper 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.Controls.Primitives.GeneratorPosition FromIndexAndOffset( int index,  int offset)
		{
			throw new global::System.NotImplementedException("The member GeneratorPosition GeneratorPositionHelper.FromIndexAndOffset(int index, int offset) is not implemented in Uno.");
		}
		#endif
	}
}
