#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TextCompositionEndedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int Length
		{
			get
			{
				throw new global::System.NotImplementedException("The member int TextCompositionEndedEventArgs.Length is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int StartIndex
		{
			get
			{
				throw new global::System.NotImplementedException("The member int TextCompositionEndedEventArgs.StartIndex is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs.StartIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs.Length.get
	}
}
