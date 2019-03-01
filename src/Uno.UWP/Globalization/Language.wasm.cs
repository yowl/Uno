#if __WASM__
using System.Globalization;

namespace Windows.Globalization
{
	public partial class Language 
	{
		public static string CurrentInputMethodLanguageTag => "en-GB";
	}
}
#endif
