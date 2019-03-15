#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Text
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ITextCharacterFormat 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FormatEffect AllCaps
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Color BackgroundColor
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FormatEffect Bold
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FontStretch FontStretch
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FontStyle FontStyle
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Color ForegroundColor
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FormatEffect Hidden
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FormatEffect Italic
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		float Kerning
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		string LanguageTag
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.LinkType LinkType
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		string Name
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FormatEffect Outline
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		float Position
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FormatEffect ProtectedText
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		float Size
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FormatEffect SmallCaps
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		float Spacing
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FormatEffect Strikethrough
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FormatEffect Subscript
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.FormatEffect Superscript
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.TextScript TextScript
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.UnderlineType Underline
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		int Weight
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.AllCaps.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.AllCaps.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.BackgroundColor.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.BackgroundColor.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Bold.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Bold.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.FontStretch.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.FontStretch.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.FontStyle.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.FontStyle.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.ForegroundColor.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.ForegroundColor.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Hidden.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Hidden.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Italic.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Italic.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Kerning.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Kerning.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.LanguageTag.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.LanguageTag.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.LinkType.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Name.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Name.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Outline.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Outline.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Position.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Position.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.ProtectedText.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.ProtectedText.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Size.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Size.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.SmallCaps.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.SmallCaps.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Spacing.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Spacing.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Strikethrough.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Strikethrough.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Subscript.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Subscript.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Superscript.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Superscript.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.TextScript.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.TextScript.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Underline.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Underline.set
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Weight.get
		// Forced skipping of method Windows.UI.Text.ITextCharacterFormat.Weight.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetClone( global::Windows.UI.Text.ITextCharacterFormat value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.UI.Text.ITextCharacterFormat GetClone();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsEqual( global::Windows.UI.Text.ITextCharacterFormat format);
		#endif
	}
}
