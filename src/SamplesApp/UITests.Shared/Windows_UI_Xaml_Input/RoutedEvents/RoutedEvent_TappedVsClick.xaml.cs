using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Uno.UI.Samples.Controls;

namespace UITests.Shared.Windows_UI_Xaml_Input.RoutedEvents
{
	[SampleControlInfo("Routed Events", "Tapped Vs Click")]
	public sealed partial class RoutedEvent_TappedVsClick : Page
	{
		public RoutedEvent_TappedVsClick()
		{
			this.InitializeComponent();

			AddHandler(TappedEvent, new TappedEventHandler(RootHandler), handledEventsToo: true);
		}

		private void RootHandler(object sender, TappedRoutedEventArgs e)
		{
			txtRoot.Text += "TAPPED (root) - handledEventsToo: true\n";
		}

		protected override void OnTapped(TappedRoutedEventArgs e)
		{
			base.OnTapped(e);

			txtRoot.Text += "TAPPED (root) - override, should not happen when tapped on children element\n";
		}
	}
}
