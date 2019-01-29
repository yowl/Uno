using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Uno.UI.Samples.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UITests.Shared.Windows_UI_Xaml_Media.Transform
{
	[SampleControlInfo("Transform", "Animations")]
	public sealed partial class Animations : Page
	{
		public Animations()
		{
			this.InitializeComponent();

			Loaded += (snd, e) =>
			{
				var rotate = (RotateTransform) _rotate;
				var animation = new DoubleAnimation
				{
					Duration = TimeSpan.FromSeconds(20),
					From = 0,
					To = 345
				};
				Storyboard.SetTarget(animation, rotate);
				Storyboard.SetTargetProperty(animation, nameof(RotateTransform.Angle));
				var storyboard = new Storyboard()
				{
					Children = {animation}
				};

				animation.Completed += async (abc, def) =>
				{
					await Task.Delay(TimeSpan.FromSeconds(30));
					storyboard.Begin();
				};

				storyboard.Begin();
			};
		}
	}
}
