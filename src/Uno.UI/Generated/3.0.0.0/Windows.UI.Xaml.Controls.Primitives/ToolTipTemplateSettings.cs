#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ToolTipTemplateSettings : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double FromHorizontalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ToolTipTemplateSettings.FromHorizontalOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double FromVerticalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ToolTipTemplateSettings.FromVerticalOffset is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ToolTipTemplateSettings.FromHorizontalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ToolTipTemplateSettings.FromVerticalOffset.get
	}
}
