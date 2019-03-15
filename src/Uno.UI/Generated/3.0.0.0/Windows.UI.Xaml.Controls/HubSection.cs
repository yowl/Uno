#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HubSection : global::Windows.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsHeaderInteractive
		{
			get
			{
				return (bool)this.GetValue(IsHeaderInteractiveProperty);
			}
			set
			{
				this.SetValue(IsHeaderInteractiveProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.DataTemplate HeaderTemplate
		{
			get
			{
				return (global::Windows.UI.Xaml.DataTemplate)this.GetValue(HeaderTemplateProperty);
			}
			set
			{
				this.SetValue(HeaderTemplateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Header
		{
			get
			{
				return (object)this.GetValue(HeaderProperty);
			}
			set
			{
				this.SetValue(HeaderProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.DataTemplate ContentTemplate
		{
			get
			{
				return (global::Windows.UI.Xaml.DataTemplate)this.GetValue(ContentTemplateProperty);
			}
			set
			{
				this.SetValue(ContentTemplateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ContentTemplateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ContentTemplate", typeof(global::Windows.UI.Xaml.DataTemplate), 
			typeof(global::Windows.UI.Xaml.Controls.HubSection), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HeaderProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Header", typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.HubSection), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HeaderTemplateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HeaderTemplate", typeof(global::Windows.UI.Xaml.DataTemplate), 
			typeof(global::Windows.UI.Xaml.Controls.HubSection), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsHeaderInteractiveProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsHeaderInteractive", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.HubSection), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public HubSection() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.HubSection", "HubSection.HubSection()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.HubSection()
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.Header.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.Header.set
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.HeaderTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.HeaderTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.ContentTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.ContentTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.IsHeaderInteractive.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.IsHeaderInteractive.set
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.HeaderProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.HeaderTemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.ContentTemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.HubSection.IsHeaderInteractiveProperty.get
	}
}
