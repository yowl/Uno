#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Data.Text
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	public delegate void WordSegmentsTokenizingHandler(global::System.Collections.Generic.IEnumerable<global::Windows.Data.Text.WordSegment> @precedingWords, global::System.Collections.Generic.IEnumerable<global::Windows.Data.Text.WordSegment> @words);
	#endif
}
