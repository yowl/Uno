#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SearchBox : global::Windows.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool SearchHistoryEnabled
		{
			get
			{
				return (bool)this.GetValue(SearchHistoryEnabledProperty);
			}
			set
			{
				this.SetValue(SearchHistoryEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string SearchHistoryContext
		{
			get
			{
				return (string)this.GetValue(SearchHistoryContextProperty);
			}
			set
			{
				this.SetValue(SearchHistoryContextProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string QueryText
		{
			get
			{
				return (string)this.GetValue(QueryTextProperty);
			}
			set
			{
				this.SetValue(QueryTextProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string PlaceholderText
		{
			get
			{
				return (string)this.GetValue(PlaceholderTextProperty);
			}
			set
			{
				this.SetValue(PlaceholderTextProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool FocusOnKeyboardInput
		{
			get
			{
				return (bool)this.GetValue(FocusOnKeyboardInputProperty);
			}
			set
			{
				this.SetValue(FocusOnKeyboardInputProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool ChooseSuggestionOnEnter
		{
			get
			{
				return (bool)this.GetValue(ChooseSuggestionOnEnterProperty);
			}
			set
			{
				this.SetValue(ChooseSuggestionOnEnterProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ChooseSuggestionOnEnterProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ChooseSuggestionOnEnter", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.SearchBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FocusOnKeyboardInputProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"FocusOnKeyboardInput", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.SearchBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PlaceholderTextProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PlaceholderText", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.SearchBox), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty QueryTextProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"QueryText", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.SearchBox), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SearchHistoryContextProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SearchHistoryContext", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.SearchBox), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SearchHistoryEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SearchHistoryEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.SearchBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SearchBox() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "SearchBox.SearchBox()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.SearchBox()
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.SearchHistoryEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.SearchHistoryEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.SearchHistoryContext.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.SearchHistoryContext.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.PlaceholderText.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.PlaceholderText.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.QueryText.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.QueryText.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.FocusOnKeyboardInput.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.FocusOnKeyboardInput.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.ChooseSuggestionOnEnter.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.ChooseSuggestionOnEnter.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.QueryChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.QueryChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.SuggestionsRequested.add
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.SuggestionsRequested.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.QuerySubmitted.add
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.QuerySubmitted.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.ResultSuggestionChosen.add
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.ResultSuggestionChosen.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.PrepareForFocusOnKeyboardInput.add
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.PrepareForFocusOnKeyboardInput.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetLocalContentSuggestionSettings( global::Windows.ApplicationModel.Search.LocalContentSuggestionSettings settings)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "void SearchBox.SetLocalContentSuggestionSettings(LocalContentSuggestionSettings settings)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.SearchHistoryEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.SearchHistoryContextProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.PlaceholderTextProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.QueryTextProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.FocusOnKeyboardInputProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SearchBox.ChooseSuggestionOnEnterProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.SearchBox, global::Windows.UI.Xaml.RoutedEventArgs> PrepareForFocusOnKeyboardInput
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "event TypedEventHandler<SearchBox, RoutedEventArgs> SearchBox.PrepareForFocusOnKeyboardInput");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "event TypedEventHandler<SearchBox, RoutedEventArgs> SearchBox.PrepareForFocusOnKeyboardInput");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.SearchBox, global::Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs> QueryChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "event TypedEventHandler<SearchBox, SearchBoxQueryChangedEventArgs> SearchBox.QueryChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "event TypedEventHandler<SearchBox, SearchBoxQueryChangedEventArgs> SearchBox.QueryChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.SearchBox, global::Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs> QuerySubmitted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "event TypedEventHandler<SearchBox, SearchBoxQuerySubmittedEventArgs> SearchBox.QuerySubmitted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "event TypedEventHandler<SearchBox, SearchBoxQuerySubmittedEventArgs> SearchBox.QuerySubmitted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.SearchBox, global::Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs> ResultSuggestionChosen
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "event TypedEventHandler<SearchBox, SearchBoxResultSuggestionChosenEventArgs> SearchBox.ResultSuggestionChosen");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "event TypedEventHandler<SearchBox, SearchBoxResultSuggestionChosenEventArgs> SearchBox.ResultSuggestionChosen");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.SearchBox, global::Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs> SuggestionsRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "event TypedEventHandler<SearchBox, SearchBoxSuggestionsRequestedEventArgs> SearchBox.SuggestionsRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SearchBox", "event TypedEventHandler<SearchBox, SearchBoxSuggestionsRequestedEventArgs> SearchBox.SuggestionsRequested");
			}
		}
		#endif
	}
}
