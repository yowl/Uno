using System;
using Uno.Disposables;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	public partial class AdaptiveTrigger : StateTriggerBase
	{
		private SerialDisposable _sizeChangedSubscription = new SerialDisposable();

		public AdaptiveTrigger()
		{
			TryUpdateState();
		}

		private void OnCurrentWindowSizeChanged(object sender, Core.WindowSizeChangedEventArgs e)
		{
			// No matter the new size of the window, we must update
			UpdateState(Window.Current.Bounds);
		}

		private void TryUpdateState()
		{
			var size = Window.Current.Bounds;
			if (size.Width > 0 && size.Height > 0)
			{
				// On WASM bounds may start a 0, so avoid to trigger state until the windows bound was set
				UpdateState(size);
			}
		}

		private void UpdateState(Rect size)
		{
			var isMinWidthSet = MinWindowWidth != -1;
			var isMinHeightSet = MinWindowHeight != -1;

			if (!isMinWidthSet && !isMinHeightSet)
			{
				// So threshold set yet, skip the update (even if the size of the window effectively changed)
				return;
			}

			var widthIsActive = isMinWidthSet && size.Width >= MinWindowWidth;
			var heightIsActive = isMinHeightSet && size.Height >= MinWindowHeight;

			SetActive((isMinWidthSet && isMinHeightSet && heightIsActive && widthIsActive)
				|| (isMinWidthSet && widthIsActive)
				|| (isMinHeightSet && heightIsActive));
		}

		#region MinWindowHeight DependencyProperty

		public double MinWindowHeight
		{
			get { return (double)this.GetValue(MinWindowHeightProperty); }
			set { this.SetValue(MinWindowHeightProperty, value); }
		}

		// Using a DependencyProperty as the backing store for MinWindowHeight.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty MinWindowHeightProperty =
			DependencyProperty.Register("MinWindowHeight", typeof(double), typeof(AdaptiveTrigger), new PropertyMetadata(-1d, (s, e) => ((AdaptiveTrigger)s)?.OnMinWindowHeightChanged(e)));

		private void OnMinWindowHeightChanged(DependencyPropertyChangedEventArgs e)
		{
			TryUpdateState();
		}

		#endregion

		#region MinWindowWidth DependencyProperty

		public double MinWindowWidth
		{
			get { return (double)this.GetValue(MinWindowWidthProperty); }
			set { this.SetValue(MinWindowWidthProperty, value); }
		}

		// Using a DependencyProperty as the backing store for MinWindowWidthProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty MinWindowWidthProperty =
			DependencyProperty.Register("MinWindowWidthProperty", typeof(double), typeof(AdaptiveTrigger), new PropertyMetadata(-1d, (s, e) => ((AdaptiveTrigger)s)?.OnMinWindowWidthChanged(e)));


		private void OnMinWindowWidthChanged(DependencyPropertyChangedEventArgs e)
		{
			TryUpdateState();
		}

		#endregion

		internal override void OnOwnerChanged()
		{
			base.OnOwnerChanged();

			_sizeChangedSubscription.Disposable = null;

			if (Owner != null)
			{
				_sizeChangedSubscription.Disposable = Window.Current.RegisterSizeChangedEvent(OnCurrentWindowSizeChanged);
			}
		}
	}
}
