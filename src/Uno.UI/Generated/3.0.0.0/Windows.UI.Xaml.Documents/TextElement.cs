#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Documents
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class TextElement : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Language
		{
			get
			{
				return (string)this.GetValue(LanguageProperty);
			}
			set
			{
				this.SetValue(LanguageProperty, value);
			}
		}
		#endif
		// Skipping already declared property Foreground
		// Skipping already declared property FontWeight
		// Skipping already declared property FontStyle
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Text.FontStretch FontStretch
		{
			get
			{
				return (global::Windows.UI.Text.FontStretch)this.GetValue(FontStretchProperty);
			}
			set
			{
				this.SetValue(FontStretchProperty, value);
			}
		}
		#endif
		// Skipping already declared property FontSize
		// Skipping already declared property FontFamily
		// Skipping already declared property CharacterSpacing
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Documents.TextPointer ContentEnd
		{
			get
			{
				throw new global::System.NotImplementedException("The member TextPointer TextElement.ContentEnd is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Documents.TextPointer ContentStart
		{
			get
			{
				throw new global::System.NotImplementedException("The member TextPointer TextElement.ContentStart is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Documents.TextPointer ElementEnd
		{
			get
			{
				throw new global::System.NotImplementedException("The member TextPointer TextElement.ElementEnd is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Documents.TextPointer ElementStart
		{
			get
			{
				throw new global::System.NotImplementedException("The member TextPointer TextElement.ElementStart is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property Name
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsTextScaleFactorEnabled
		{
			get
			{
				return (bool)this.GetValue(IsTextScaleFactorEnabledProperty);
			}
			set
			{
				this.SetValue(IsTextScaleFactorEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool ExitDisplayModeOnAccessKeyInvoked
		{
			get
			{
				return (bool)this.GetValue(ExitDisplayModeOnAccessKeyInvokedProperty);
			}
			set
			{
				this.SetValue(ExitDisplayModeOnAccessKeyInvokedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AllowFocusOnInteraction
		{
			get
			{
				return (bool)this.GetValue(AllowFocusOnInteractionProperty);
			}
			set
			{
				this.SetValue(AllowFocusOnInteractionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string AccessKey
		{
			get
			{
				return (string)this.GetValue(AccessKeyProperty);
			}
			set
			{
				this.SetValue(AccessKeyProperty, value);
			}
		}
		#endif
		// Skipping already declared property TextDecorations
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double KeyTipVerticalOffset
		{
			get
			{
				return (double)this.GetValue(KeyTipVerticalOffsetProperty);
			}
			set
			{
				this.SetValue(KeyTipVerticalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Input.KeyTipPlacementMode KeyTipPlacementMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.KeyTipPlacementMode)this.GetValue(KeyTipPlacementModeProperty);
			}
			set
			{
				this.SetValue(KeyTipPlacementModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double KeyTipHorizontalOffset
		{
			get
			{
				return (double)this.GetValue(KeyTipHorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(KeyTipHorizontalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsAccessKeyScope
		{
			get
			{
				return (bool)this.GetValue(IsAccessKeyScopeProperty);
			}
			set
			{
				this.SetValue(IsAccessKeyScopeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.DependencyObject AccessKeyScopeOwner
		{
			get
			{
				return (global::Windows.UI.Xaml.DependencyObject)this.GetValue(AccessKeyScopeOwnerProperty);
			}
			set
			{
				this.SetValue(AccessKeyScopeOwnerProperty, value);
			}
		}
		#endif
		// Skipping already declared property CharacterSpacingProperty
		// Skipping already declared property FontFamilyProperty
		// Skipping already declared property FontSizeProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FontStretchProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"FontStretch", typeof(global::Windows.UI.Text.FontStretch), 
			typeof(global::Windows.UI.Xaml.Documents.TextElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Text.FontStretch)));
		#endif
		// Skipping already declared property FontStyleProperty
		// Skipping already declared property FontWeightProperty
		// Skipping already declared property ForegroundProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty LanguageProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Language", typeof(string), 
			typeof(global::Windows.UI.Xaml.Documents.TextElement), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsTextScaleFactorEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsTextScaleFactorEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Documents.TextElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AccessKeyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AccessKey", typeof(string), 
			typeof(global::Windows.UI.Xaml.Documents.TextElement), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AllowFocusOnInteractionProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AllowFocusOnInteraction", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Documents.TextElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ExitDisplayModeOnAccessKeyInvoked", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Documents.TextElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AccessKeyScopeOwnerProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AccessKeyScopeOwner", typeof(global::Windows.UI.Xaml.DependencyObject), 
			typeof(global::Windows.UI.Xaml.Documents.TextElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsAccessKeyScopeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsAccessKeyScope", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Documents.TextElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty KeyTipHorizontalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"KeyTipHorizontalOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Documents.TextElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty KeyTipPlacementModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"KeyTipPlacementMode", typeof(global::Windows.UI.Xaml.Input.KeyTipPlacementMode), 
			typeof(global::Windows.UI.Xaml.Documents.TextElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.KeyTipPlacementMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty KeyTipVerticalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"KeyTipVerticalOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Documents.TextElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		// Skipping already declared property TextDecorationsProperty
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.Name.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontSize.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontSize.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontFamily.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontFamily.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontWeight.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontWeight.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontStyle.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontStyle.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontStretch.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontStretch.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.CharacterSpacing.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.CharacterSpacing.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.Foreground.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.Foreground.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.Language.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.Language.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.ContentStart.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.ContentEnd.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.ElementStart.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.ElementEnd.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object FindName( string name)
		{
			throw new global::System.NotImplementedException("The member object TextElement.FindName(string name) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.IsTextScaleFactorEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.IsTextScaleFactorEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AllowFocusOnInteraction.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AllowFocusOnInteraction.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKey.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKey.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.ExitDisplayModeOnAccessKeyInvoked.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.ExitDisplayModeOnAccessKeyInvoked.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.TextDecorations.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.TextDecorations.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.IsAccessKeyScope.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.IsAccessKeyScope.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKeyScopeOwner.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKeyScopeOwner.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.KeyTipPlacementMode.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.KeyTipPlacementMode.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.KeyTipHorizontalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.KeyTipHorizontalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.KeyTipVerticalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.KeyTipVerticalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKeyDisplayRequested.add
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKeyDisplayRequested.remove
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKeyDisplayDismissed.add
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKeyDisplayDismissed.remove
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKeyInvoked.add
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKeyInvoked.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnDisconnectVisualChildren()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.TextElement", "void TextElement.OnDisconnectVisualChildren()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.TextDecorationsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.IsAccessKeyScopeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKeyScopeOwnerProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.KeyTipPlacementModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.KeyTipHorizontalOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.KeyTipVerticalOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AllowFocusOnInteractionProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.AccessKeyProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.ExitDisplayModeOnAccessKeyInvokedProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.IsTextScaleFactorEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontSizeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontFamilyProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontWeightProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontStyleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.FontStretchProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.CharacterSpacingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.ForegroundProperty.get
		// Forced skipping of method Windows.UI.Xaml.Documents.TextElement.LanguageProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Documents.TextElement, global::Windows.UI.Xaml.Input.AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.TextElement", "event TypedEventHandler<TextElement, AccessKeyDisplayDismissedEventArgs> TextElement.AccessKeyDisplayDismissed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.TextElement", "event TypedEventHandler<TextElement, AccessKeyDisplayDismissedEventArgs> TextElement.AccessKeyDisplayDismissed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Documents.TextElement, global::Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.TextElement", "event TypedEventHandler<TextElement, AccessKeyDisplayRequestedEventArgs> TextElement.AccessKeyDisplayRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.TextElement", "event TypedEventHandler<TextElement, AccessKeyDisplayRequestedEventArgs> TextElement.AccessKeyDisplayRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Documents.TextElement, global::Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs> AccessKeyInvoked
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.TextElement", "event TypedEventHandler<TextElement, AccessKeyInvokedEventArgs> TextElement.AccessKeyInvoked");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.TextElement", "event TypedEventHandler<TextElement, AccessKeyInvokedEventArgs> TextElement.AccessKeyInvoked");
			}
		}
		#endif
	}
}
