#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Documents
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Run : global::Windows.UI.Xaml.Documents.Inline
	{
		// Skipping already declared property Text
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.FlowDirection FlowDirection
		{
			get
			{
				return (global::Windows.UI.Xaml.FlowDirection)this.GetValue(FlowDirectionProperty);
			}
			set
			{
				this.SetValue(FlowDirectionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FlowDirectionProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"FlowDirection", typeof(global::Windows.UI.Xaml.FlowDirection), 
			typeof(global::Windows.UI.Xaml.Documents.Run), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.FlowDirection)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Documents.Run.Run()
		// Forced skipping of method Windows.UI.Xaml.Documents.Run.Run()
		// Forced skipping of method Windows.UI.Xaml.Documents.Run.Text.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Run.Text.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Run.FlowDirection.get
		// Forced skipping of method Windows.UI.Xaml.Documents.Run.FlowDirection.set
		// Forced skipping of method Windows.UI.Xaml.Documents.Run.FlowDirectionProperty.get
	}
}
