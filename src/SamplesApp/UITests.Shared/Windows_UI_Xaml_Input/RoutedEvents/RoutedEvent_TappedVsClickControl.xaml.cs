using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace UITests.Shared.Windows_UI_Xaml_Input.RoutedEvents
{
	public sealed partial class RoutedEvent_TappedVsClickControl : UserControl
	{
		public RoutedEvent_TappedVsClickControl()
		{
			this.InitializeComponent();

			Tapped += (snd, evt) =>
			{
				txtChildren.Text += "(2/2) Tapped (event handler) + handled=true\n";

				evt.Handled = true;
			};

			btnOuter.Tapped += (snd, evt) =>
			{
				txtChildren.Text += $"Outer TAPPED\n";
			};
			btnOuter.Click += (snd, evt) =>
			{
				txtChildren.Text += $"Outer CLICK\n";
			};
			btnInner.Tapped += (snd, evt) =>
			{
				txtChildren.Text += $"Inner TAPPED\n";
			};
			btnInner.Click += (snd, evt) =>
			{
				txtChildren.Text += $"Inner CLICK\n";
			};

			outerContent.Tapped += (snd, evt) =>
			{
				txtChildren.Text += $"Outer content TAPPED\n";
			};
		}

		protected override void OnTapped(TappedRoutedEventArgs e)
		{
			base.OnTapped(e);

			txtChildren.Text += "(1/2) Tapped (override)\n";
		}

		protected override void OnPointerPressed(PointerRoutedEventArgs args)
		{
			txtChildren.Text += "PRESSED\n";

			base.OnPointerPressed(args);
		}

		protected override void OnPointerReleased(PointerRoutedEventArgs args)
		{
			txtChildren.Text += "RELEASED\n";

			base.OnPointerReleased(args);
		}
	}
}
