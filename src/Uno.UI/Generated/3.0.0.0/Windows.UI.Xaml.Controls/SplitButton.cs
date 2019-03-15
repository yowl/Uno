#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SplitButton : global::Windows.UI.Xaml.Controls.ContentControl
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase Flyout
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase)this.GetValue(FlyoutProperty);
			}
			set
			{
				this.SetValue(FlyoutProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object CommandParameter
		{
			get
			{
				return (object)this.GetValue(CommandParameterProperty);
			}
			set
			{
				this.SetValue(CommandParameterProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Windows.Input.ICommand Command
		{
			get
			{
				return (global::System.Windows.Input.ICommand)this.GetValue(CommandProperty);
			}
			set
			{
				this.SetValue(CommandProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CommandParameterProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CommandParameter", typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.SplitButton), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CommandProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Command", typeof(global::System.Windows.Input.ICommand), 
			typeof(global::Windows.UI.Xaml.Controls.SplitButton), 
			new FrameworkPropertyMetadata(default(global::System.Windows.Input.ICommand)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FlyoutProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Flyout", typeof(global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase), 
			typeof(global::Windows.UI.Xaml.Controls.SplitButton), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SplitButton() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SplitButton", "SplitButton.SplitButton()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.SplitButton()
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.Flyout.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.Flyout.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.Command.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.Command.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.CommandParameter.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.CommandParameter.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.Click.add
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.Click.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.FlyoutProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.CommandProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SplitButton.CommandParameterProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.SplitButton, global::Windows.UI.Xaml.Controls.SplitButtonClickEventArgs> Click
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SplitButton", "event TypedEventHandler<SplitButton, SplitButtonClickEventArgs> SplitButton.Click");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SplitButton", "event TypedEventHandler<SplitButton, SplitButtonClickEventArgs> SplitButton.Click");
			}
		}
		#endif
	}
}
