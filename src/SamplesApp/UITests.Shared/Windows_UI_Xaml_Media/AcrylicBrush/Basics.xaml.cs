using System;
using System.Linq;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using UIKit;
using Uno.UI.Samples.Controls;

namespace UITests.Shared.Windows_UI_Xaml_Media.AcrylicBrush
{
	[SampleControlInfo("AcrylicBrush", "Basics")]
	public sealed partial class Basics : Page
	{
		public Basics()
		{
			this.InitializeComponent();

			Loaded += (snd, args) =>
			{
				var target = (Border) _backdrop;

				var blurView = new UIVisualEffectView(new UIBlurEffect())
				{
					Frame = target.Frame,
					TranslatesAutoresizingMaskIntoConstraints = true
				};

				//blurView.AddSubview(new Border
				//{
				//	Width = 50,
				//	Height = 50,
				//	Background = new SolidColorBrush(Colors.DeepPink)
				//});
				target.SizeChanged += (_, e) =>
				{
					blurView.Frame = target.Frame;
				};
				var content = target.Child;
				content.RemoveFromSuperview();

				target.AddSubview(content);

				target.InsertSubview(blurView, 0);
			};
		}
	}
}
