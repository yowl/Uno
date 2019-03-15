#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Hub : global::Windows.UI.Xaml.Controls.Control,global::Windows.UI.Xaml.Controls.ISemanticZoomInformation
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Orientation Orientation
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Orientation)this.GetValue(OrientationProperty);
			}
			set
			{
				this.SetValue(OrientationProperty, value);
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
		public  int DefaultSectionIndex
		{
			get
			{
				return (int)this.GetValue(DefaultSectionIndexProperty);
			}
			set
			{
				this.SetValue(DefaultSectionIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Collections.IObservableVector<object> SectionHeaders
		{
			get
			{
				throw new global::System.NotImplementedException("The member IObservableVector<object> Hub.SectionHeaders is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.HubSection> Sections
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<HubSection> Hub.Sections is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.HubSection> SectionsInView
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<HubSection> Hub.SectionsInView is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.SemanticZoom SemanticZoomOwner
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.SemanticZoom)this.GetValue(SemanticZoomOwnerProperty);
			}
			set
			{
				this.SetValue(SemanticZoomOwnerProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsZoomedInView
		{
			get
			{
				return (bool)this.GetValue(IsZoomedInViewProperty);
			}
			set
			{
				this.SetValue(IsZoomedInViewProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsActiveView
		{
			get
			{
				return (bool)this.GetValue(IsActiveViewProperty);
			}
			set
			{
				this.SetValue(IsActiveViewProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DefaultSectionIndexProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"DefaultSectionIndex", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Hub), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HeaderProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Header", typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.Hub), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HeaderTemplateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HeaderTemplate", typeof(global::Windows.UI.Xaml.DataTemplate), 
			typeof(global::Windows.UI.Xaml.Controls.Hub), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsActiveViewProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsActiveView", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.Hub), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsZoomedInViewProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsZoomedInView", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.Hub), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty OrientationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Orientation", typeof(global::Windows.UI.Xaml.Controls.Orientation), 
			typeof(global::Windows.UI.Xaml.Controls.Hub), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.Orientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SemanticZoomOwnerProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"SemanticZoomOwner", typeof(global::Windows.UI.Xaml.Controls.SemanticZoom), 
			typeof(global::Windows.UI.Xaml.Controls.Hub), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.SemanticZoom)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public Hub() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "Hub.Hub()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.Hub()
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.Header.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.Header.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.HeaderTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.HeaderTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.Orientation.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.Orientation.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.DefaultSectionIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.DefaultSectionIndex.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.Sections.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.SectionsInView.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.SectionHeaders.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.SectionHeaderClick.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.SectionHeaderClick.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.SectionsInViewChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.SectionsInViewChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ScrollToSection( global::Windows.UI.Xaml.Controls.HubSection section)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "void Hub.ScrollToSection(HubSection section)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.SemanticZoomOwner.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.SemanticZoomOwner.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.IsActiveView.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.IsActiveView.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.IsZoomedInView.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.IsZoomedInView.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void InitializeViewChange()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "void Hub.InitializeViewChange()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void CompleteViewChange()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "void Hub.CompleteViewChange()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void MakeVisible( global::Windows.UI.Xaml.Controls.SemanticZoomLocation item)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "void Hub.MakeVisible(SemanticZoomLocation item)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void StartViewChangeFrom( global::Windows.UI.Xaml.Controls.SemanticZoomLocation source,  global::Windows.UI.Xaml.Controls.SemanticZoomLocation destination)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "void Hub.StartViewChangeFrom(SemanticZoomLocation source, SemanticZoomLocation destination)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void StartViewChangeTo( global::Windows.UI.Xaml.Controls.SemanticZoomLocation source,  global::Windows.UI.Xaml.Controls.SemanticZoomLocation destination)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "void Hub.StartViewChangeTo(SemanticZoomLocation source, SemanticZoomLocation destination)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void CompleteViewChangeFrom( global::Windows.UI.Xaml.Controls.SemanticZoomLocation source,  global::Windows.UI.Xaml.Controls.SemanticZoomLocation destination)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "void Hub.CompleteViewChangeFrom(SemanticZoomLocation source, SemanticZoomLocation destination)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void CompleteViewChangeTo( global::Windows.UI.Xaml.Controls.SemanticZoomLocation source,  global::Windows.UI.Xaml.Controls.SemanticZoomLocation destination)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "void Hub.CompleteViewChangeTo(SemanticZoomLocation source, SemanticZoomLocation destination)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.HeaderProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.HeaderTemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.OrientationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.DefaultSectionIndexProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.SemanticZoomOwnerProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.IsActiveViewProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Hub.IsZoomedInViewProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Controls.HubSectionHeaderClickEventHandler SectionHeaderClick
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "event HubSectionHeaderClickEventHandler Hub.SectionHeaderClick");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "event HubSectionHeaderClickEventHandler Hub.SectionHeaderClick");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Controls.SectionsInViewChangedEventHandler SectionsInViewChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "event SectionsInViewChangedEventHandler Hub.SectionsInViewChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Hub", "event SectionsInViewChangedEventHandler Hub.SectionsInViewChanged");
			}
		}
		#endif
		// Processing: Windows.UI.Xaml.Controls.ISemanticZoomInformation
	}
}
