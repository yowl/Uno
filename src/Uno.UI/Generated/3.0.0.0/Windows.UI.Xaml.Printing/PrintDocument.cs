#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Printing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class PrintDocument : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Printing.IPrintDocumentSource DocumentSource
		{
			get
			{
				return (global::Windows.Graphics.Printing.IPrintDocumentSource)this.GetValue(DocumentSourceProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DocumentSourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"DocumentSource", typeof(global::Windows.Graphics.Printing.IPrintDocumentSource), 
			typeof(global::Windows.UI.Xaml.Printing.PrintDocument), 
			new FrameworkPropertyMetadata(default(global::Windows.Graphics.Printing.IPrintDocumentSource)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Printing.PrintDocument.PrintDocument()
		// Forced skipping of method Windows.UI.Xaml.Printing.PrintDocument.PrintDocument()
		// Forced skipping of method Windows.UI.Xaml.Printing.PrintDocument.DocumentSource.get
		// Forced skipping of method Windows.UI.Xaml.Printing.PrintDocument.Paginate.add
		// Forced skipping of method Windows.UI.Xaml.Printing.PrintDocument.Paginate.remove
		// Forced skipping of method Windows.UI.Xaml.Printing.PrintDocument.GetPreviewPage.add
		// Forced skipping of method Windows.UI.Xaml.Printing.PrintDocument.GetPreviewPage.remove
		// Forced skipping of method Windows.UI.Xaml.Printing.PrintDocument.AddPages.add
		// Forced skipping of method Windows.UI.Xaml.Printing.PrintDocument.AddPages.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void AddPage( global::Windows.UI.Xaml.UIElement pageVisual)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.PrintDocument", "void PrintDocument.AddPage(UIElement pageVisual)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void AddPagesComplete()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.PrintDocument", "void PrintDocument.AddPagesComplete()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetPreviewPageCount( int count,  global::Windows.UI.Xaml.Printing.PreviewPageCountType type)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.PrintDocument", "void PrintDocument.SetPreviewPageCount(int count, PreviewPageCountType type)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetPreviewPage( int pageNumber,  global::Windows.UI.Xaml.UIElement pageVisual)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.PrintDocument", "void PrintDocument.SetPreviewPage(int pageNumber, UIElement pageVisual)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void InvalidatePreview()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.PrintDocument", "void PrintDocument.InvalidatePreview()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Printing.PrintDocument.DocumentSourceProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Printing.AddPagesEventHandler AddPages
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.PrintDocument", "event AddPagesEventHandler PrintDocument.AddPages");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.PrintDocument", "event AddPagesEventHandler PrintDocument.AddPages");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Printing.GetPreviewPageEventHandler GetPreviewPage
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.PrintDocument", "event GetPreviewPageEventHandler PrintDocument.GetPreviewPage");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.PrintDocument", "event GetPreviewPageEventHandler PrintDocument.GetPreviewPage");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Printing.PaginateEventHandler Paginate
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.PrintDocument", "event PaginateEventHandler PrintDocument.Paginate");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Printing.PrintDocument", "event PaginateEventHandler PrintDocument.Paginate");
			}
		}
		#endif
	}
}
