using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
//using UIKit;
#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif __WASM__
using _View = Windows.UI.Xaml.UIElement;
#else
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace Uno.UI.Xaml.Controls.Border
{
	/// <summary>
	/// An helper class to handle and display the layers usually related to a <see cref="Windows.UI.Xaml.Controls.Border"/>
	/// </summary>
	internal sealed partial class BorderLayerRenderer
	{
		// Note: This class is designed to handle the border properties using an aggregation pattern.
		//		 We assume that the code of this class could be directly integrated as part of the code
		//		 of the '_owner', and has been extracted only for re-used across controls.

		private readonly _View _owner;

		/// <summary>
		/// Creates a border layer renderer for the given owner
		/// </summary>
		/// <param name="owner">The owner of this renderer, usually a <see cref="Windows.UI.Xaml.Controls.Border"/> or a <see cref="Windows.UI.Xaml.Controls.Panel"/>.</param>
		public BorderLayerRenderer(_View owner)
		{
			_owner = owner;
		}

		public void UpdateBackground(Brush brush)
		{

		}

		public void UpdateBorderBrush(Brush brush)
		{

		}

		public void UpdateBorderThickness(Thickness thickness)
		{

		}

		public void UpdateCornerRadius(CornerRadius radius)
		{

		}

		public void UpdatePadding(Thickness thickness)
		{

		}
	}

	public class NativeBrushAdapter : IDisposable
	{
		public NativeBrushAdapter(_View owner, Brush brush)
		{
			//// UIAccessibilityIsReduceTransparencyEnabled
			//var blurView = new UIVisualEffectView(new UIBlurEffect());

			//// Useless: we cannot move child to this one
			////blurView.ContentView.AddSubview(new UIVisualEffectView(new UIVibrancyEffect()));

			//owner.Layer.AddSublayer(blurView.Layer);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
