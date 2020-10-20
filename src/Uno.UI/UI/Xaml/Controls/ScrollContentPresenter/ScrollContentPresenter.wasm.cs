﻿using Uno.Extensions;
using Uno.Logging;
using Uno.UI.DataBinding;
using Windows.UI.Xaml.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Uno.Disposables;
using System.Runtime.CompilerServices;
using System.Text;
using Windows.Foundation;
using Uno.UI.Xaml;
using Microsoft.Extensions.Logging;

namespace Windows.UI.Xaml.Controls
{
	public partial class ScrollContentPresenter : ContentPresenter
	{
		private ScrollBarVisibility _verticalScrollBarVisibility;
		private ScrollBarVisibility _horizotalScrollBarVisibility;

		internal Size ScrollBarSize
		{
			get
			{
				var (clientSize, offsetSize) = WindowManagerInterop.GetClientViewSize(HtmlId);

				return new Size(offsetSize.Width - clientSize.Width, offsetSize.Height - clientSize.Height);
			}
		}

		public ScrollContentPresenter()
		{
			Application.PrintLine("ScrollContentPresenter");
			PointerReleased += ScrollViewer_PointerReleased;
			Application.PrintLine("ScrollContentPresenter PointerReleased");

			PointerPressed += ScrollViewer_PointerPressed;
			Application.PrintLine("ScrollContentPresenter PointerPressed");
			PointerCanceled += ScrollContentPresenter_PointerCanceled;
			Application.PrintLine("ScrollContentPresenter PointerCanceled");
			PointerMoved += ScrollContentPresenter_PointerMoved;
			Application.PrintLine("ScrollContentPresenter PointerMoved");
			PointerEntered += ScrollContentPresenter_PointerEntered;
			Application.PrintLine("ScrollContentPresenter PointerEntered");
			PointerExited += ScrollContentPresenter_PointerExited;
			Application.PrintLine("ScrollContentPresenter PointerExited");
			PointerWheelChanged += ScrollContentPresenter_PointerWheelChanged;
			Application.PrintLine("ScrollContentPresenter PointerWheelChanged");
		}

		private void ScrollContentPresenter_PointerWheelChanged(object sender, Input.PointerRoutedEventArgs e)
			=> HandlePointerEvent(e);

		private void ScrollContentPresenter_PointerExited(object sender, Input.PointerRoutedEventArgs e)
			=> HandlePointerEvent(e);

		private void ScrollContentPresenter_PointerEntered(object sender, Input.PointerRoutedEventArgs e)
			=> HandlePointerEvent(e);

		private void ScrollContentPresenter_PointerMoved(object sender, Input.PointerRoutedEventArgs e)
			=> HandlePointerEvent(e);

		private void ScrollContentPresenter_PointerCanceled(object sender, Input.PointerRoutedEventArgs e)
			=> HandlePointerEvent(e);

		private void ScrollViewer_PointerPressed(object sender, Input.PointerRoutedEventArgs e)
			=> HandlePointerEvent(e);

		private void ScrollViewer_PointerReleased(object sender, Input.PointerRoutedEventArgs e)
			=> HandlePointerEvent(e);

		private void HandlePointerEvent(Input.PointerRoutedEventArgs e)
		{
			var (clientSize, offsetSize) = WindowManagerInterop.GetClientViewSize(HtmlId);

			bool hasHorizontalScroll = (offsetSize.Height - clientSize.Height) > 0;
			bool hasVerticalScroll = (offsetSize.Width - clientSize.Width) > 0;

			if (this.Log().IsEnabled(LogLevel.Debug))
			{
				this.Log().LogDebug($"{HtmlId}: {offsetSize} / {clientSize} / {e.GetCurrentPoint(this)}");
			}

			if (!hasVerticalScroll && !hasHorizontalScroll)
			{
				return;
			}

			// The events coming from the scrollbars are bubbled up
			// to the parents, as those are not (yet) XAML elements.
			// This can cause issues for popups with scrollable content and
			// light dismiss patterns.
			var position = e.GetCurrentPoint(this).Position;
			var isInVerticalScrollbar = hasVerticalScroll && position.X >= clientSize.Width;
			var isInHorizontalScrollbar = hasHorizontalScroll && position.Y >= clientSize.Height;

			if (isInVerticalScrollbar || isInHorizontalScrollbar)
			{
				e.Handled = true;
			}
		}

		public float MinimumZoomScale { get; private set; }

		public float MaximumZoomScale { get; private set; }

		private static readonly string[] VerticalVisibilityClasses = { "scroll-y-auto", "scroll-y-disabled", "scroll-y-hidden", "scroll-y-visible" };

		public ScrollBarVisibility VerticalScrollBarVisibility
		{
			get { return _verticalScrollBarVisibility; }
			set
			{
				if (_verticalScrollBarVisibility != value)
				{
					_verticalScrollBarVisibility = value;
					SetClasses(VerticalVisibilityClasses, (int)value);
				}
			}
		}
		private static readonly string[] HorizontalVisibilityClasses = { "scroll-x-auto", "scroll-x-disabled", "scroll-x-hidden", "scroll-x-visible" };

		public ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get { return _horizotalScrollBarVisibility; }
			set
			{
				if (_horizotalScrollBarVisibility != value)
				{
					_horizotalScrollBarVisibility = value;
					SetClasses(HorizontalVisibilityClasses, (int)value);
				}
			}
		}

		private protected override void OnLoaded()
		{
			Application.PrintLine("scrollcontentpresenter OnLoaded ");

			base.OnLoaded();
			RegisterEventHandler("scroll", (EventHandler)OnScroll);
			Application.PrintLine("scrollcontentpresenter OnLoaded end");
		}

		private protected override void OnUnloaded()
		{
			base.OnUnloaded();
			UnregisterEventHandler("scroll", (EventHandler)OnScroll);
		}

		public void ScrollTo(double? horizontalOffset, double? verticalOffset, bool disableAnimation)
			=> WindowManagerInterop.ScrollTo(HtmlId, horizontalOffset, verticalOffset, disableAnimation);

		private void OnScroll(object sender, EventArgs args)
		{
			var left = GetProperty("scrollLeft");
			var top = GetProperty("scrollTop");

			if (!double.TryParse(left, NumberStyles.Number, CultureInfo.InvariantCulture, out var horizontalOffset))
			{
				horizontalOffset = 0;
			}
			if (!double.TryParse(top, NumberStyles.Number, CultureInfo.InvariantCulture, out var verticalOffset))
			{
				verticalOffset = 0;
			}

			// We don't have any information from the DOM 'scroll' event about the intermediate vs. final state.
			// We could try to rely on the IsPointerPressed state to detect when the user is scrolling and use it.
			// This would however not include scrolling due to the inertia which should also be flagged as intermediate.
			// The main issue is that the IsPointerPressed be true ONLY when dragging the scrollbars with the mouse, 
			// as for finger and pen we will get a PointerCancelled which will reset the pressed state to false.
			// And it would also requires us to explicitly invoke OnScroll in PointerRelease in order to raise the
			// final SV.ViewChanged event with a IsIntermediate == false.
			// This is probably safer for now to always consider the scroll as final, even if it introduce a performance cost
			// (the SV updates mode is always sync when isIntermediate is false).
			var isIntermediate = false;

			(TemplatedParent as ScrollViewer)?.OnScrollInternal(
				horizontalOffset,
				verticalOffset,
				isIntermediate
			);
		}
	}
}
