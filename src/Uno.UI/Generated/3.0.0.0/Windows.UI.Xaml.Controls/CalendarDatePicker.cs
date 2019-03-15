#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CalendarDatePicker : global::Windows.UI.Xaml.Controls.Control
	{
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
		public  global::System.DateTimeOffset MinDate
		{
			get
			{
				return (global::System.DateTimeOffset)this.GetValue(MinDateProperty);
			}
			set
			{
				this.SetValue(MinDateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.DateTimeOffset MaxDate
		{
			get
			{
				return (global::System.DateTimeOffset)this.GetValue(MaxDateProperty);
			}
			set
			{
				this.SetValue(MaxDateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsTodayHighlighted
		{
			get
			{
				return (bool)this.GetValue(IsTodayHighlightedProperty);
			}
			set
			{
				this.SetValue(IsTodayHighlightedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsOutOfScopeEnabled
		{
			get
			{
				return (bool)this.GetValue(IsOutOfScopeEnabledProperty);
			}
			set
			{
				this.SetValue(IsOutOfScopeEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsGroupLabelVisible
		{
			get
			{
				return (bool)this.GetValue(IsGroupLabelVisibleProperty);
			}
			set
			{
				this.SetValue(IsGroupLabelVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsCalendarOpen
		{
			get
			{
				return (bool)this.GetValue(IsCalendarOpenProperty);
			}
			set
			{
				this.SetValue(IsCalendarOpenProperty, value);
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
		public  global::Windows.Globalization.DayOfWeek FirstDayOfWeek
		{
			get
			{
				return (global::Windows.Globalization.DayOfWeek)this.GetValue(FirstDayOfWeekProperty);
			}
			set
			{
				this.SetValue(FirstDayOfWeekProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.CalendarViewDisplayMode DisplayMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.CalendarViewDisplayMode)this.GetValue(DisplayModeProperty);
			}
			set
			{
				this.SetValue(DisplayModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string DayOfWeekFormat
		{
			get
			{
				return (string)this.GetValue(DayOfWeekFormatProperty);
			}
			set
			{
				this.SetValue(DayOfWeekFormatProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string DateFormat
		{
			get
			{
				return (string)this.GetValue(DateFormatProperty);
			}
			set
			{
				this.SetValue(DateFormatProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.DateTimeOffset? Date
		{
			get
			{
				return (global::System.DateTimeOffset?)this.GetValue(DateProperty);
			}
			set
			{
				this.SetValue(DateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Style CalendarViewStyle
		{
			get
			{
				return (global::Windows.UI.Xaml.Style)this.GetValue(CalendarViewStyleProperty);
			}
			set
			{
				this.SetValue(CalendarViewStyleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string CalendarIdentifier
		{
			get
			{
				return (string)this.GetValue(CalendarIdentifierProperty);
			}
			set
			{
				this.SetValue(CalendarIdentifierProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.LightDismissOverlayMode LightDismissOverlayMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.LightDismissOverlayMode)this.GetValue(LightDismissOverlayModeProperty);
			}
			set
			{
				this.SetValue(LightDismissOverlayModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Description
		{
			get
			{
				return (object)this.GetValue(DescriptionProperty);
			}
			set
			{
				this.SetValue(DescriptionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CalendarIdentifierProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CalendarIdentifier", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CalendarViewStyleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CalendarViewStyle", typeof(global::Windows.UI.Xaml.Style), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Style)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DateFormatProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"DateFormat", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Date", typeof(global::System.DateTimeOffset?), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(global::System.DateTimeOffset?)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DayOfWeekFormatProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"DayOfWeekFormat", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DisplayModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"DisplayMode", typeof(global::Windows.UI.Xaml.Controls.CalendarViewDisplayMode), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.CalendarViewDisplayMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FirstDayOfWeekProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"FirstDayOfWeek", typeof(global::Windows.Globalization.DayOfWeek), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(global::Windows.Globalization.DayOfWeek)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HeaderProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Header", typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HeaderTemplateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HeaderTemplate", typeof(global::Windows.UI.Xaml.DataTemplate), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsCalendarOpenProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsCalendarOpen", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsGroupLabelVisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsGroupLabelVisible", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsOutOfScopeEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsOutOfScopeEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsTodayHighlightedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsTodayHighlighted", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MaxDateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MaxDate", typeof(global::System.DateTimeOffset), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(global::System.DateTimeOffset)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty MinDateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"MinDate", typeof(global::System.DateTimeOffset), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(global::System.DateTimeOffset)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PlaceholderTextProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PlaceholderText", typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty LightDismissOverlayModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"LightDismissOverlayMode", typeof(global::Windows.UI.Xaml.Controls.LightDismissOverlayMode), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.LightDismissOverlayMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DescriptionProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Description", typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.CalendarDatePicker), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CalendarDatePicker() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CalendarDatePicker", "CalendarDatePicker.CalendarDatePicker()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.CalendarDatePicker()
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.Date.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.Date.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsCalendarOpen.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsCalendarOpen.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DateFormat.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DateFormat.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.PlaceholderText.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.PlaceholderText.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.Header.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.Header.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.HeaderTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.HeaderTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.CalendarViewStyle.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.CalendarViewStyle.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.MinDate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.MinDate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.MaxDate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.MaxDate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsTodayHighlighted.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsTodayHighlighted.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DisplayMode.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DisplayMode.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.FirstDayOfWeek.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.FirstDayOfWeek.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DayOfWeekFormat.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DayOfWeekFormat.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.CalendarIdentifier.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.CalendarIdentifier.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsOutOfScopeEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsOutOfScopeEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsGroupLabelVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsGroupLabelVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.CalendarViewDayItemChanging.add
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.CalendarViewDayItemChanging.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DateChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DateChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.Opened.add
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.Opened.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.Closed.add
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.Closed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetDisplayDate( global::System.DateTimeOffset date)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CalendarDatePicker", "void CalendarDatePicker.SetDisplayDate(DateTimeOffset date)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetYearDecadeDisplayDimensions( int columns,  int rows)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CalendarDatePicker", "void CalendarDatePicker.SetYearDecadeDisplayDimensions(int columns, int rows)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.LightDismissOverlayMode.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.LightDismissOverlayMode.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.Description.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.Description.set
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DescriptionProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.LightDismissOverlayModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsCalendarOpenProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DateFormatProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.PlaceholderTextProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.HeaderProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.HeaderTemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.CalendarViewStyleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.MinDateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.MaxDateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsTodayHighlightedProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DisplayModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.FirstDayOfWeekProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.DayOfWeekFormatProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.CalendarIdentifierProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsOutOfScopeEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CalendarDatePicker.IsGroupLabelVisibleProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventHandler CalendarViewDayItemChanging
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CalendarDatePicker", "event CalendarViewDayItemChangingEventHandler CalendarDatePicker.CalendarViewDayItemChanging");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CalendarDatePicker", "event CalendarViewDayItemChangingEventHandler CalendarDatePicker.CalendarViewDayItemChanging");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::System.EventHandler<object> Closed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CalendarDatePicker", "event EventHandler<object> CalendarDatePicker.Closed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CalendarDatePicker", "event EventHandler<object> CalendarDatePicker.Closed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.CalendarDatePicker, global::Windows.UI.Xaml.Controls.CalendarDatePickerDateChangedEventArgs> DateChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CalendarDatePicker", "event TypedEventHandler<CalendarDatePicker, CalendarDatePickerDateChangedEventArgs> CalendarDatePicker.DateChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CalendarDatePicker", "event TypedEventHandler<CalendarDatePicker, CalendarDatePickerDateChangedEventArgs> CalendarDatePicker.DateChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::System.EventHandler<object> Opened
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CalendarDatePicker", "event EventHandler<object> CalendarDatePicker.Opened");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CalendarDatePicker", "event EventHandler<object> CalendarDatePicker.Opened");
			}
		}
		#endif
	}
}
