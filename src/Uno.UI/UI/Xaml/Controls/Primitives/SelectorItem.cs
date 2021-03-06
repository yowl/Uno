﻿using System;
using System.Collections.Generic;
using Uno.Disposables;
using System.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Core;
using System.Threading.Tasks;
using Uno.UI;
#if XAMARIN_IOS
using UIKit;
#endif

namespace Windows.UI.Xaml.Controls.Primitives
{
	public partial class SelectorItem : ContentControl
	{
		/// <summary>
		/// Delay time before setting the pressed state of an item to false, to allow time for the Pressed visual state to be drawn and perceived. 
		/// </summary>
		private static readonly TimeSpan MinTimeBetweenPressStates = TimeSpan.FromMilliseconds(100);

		/// <summary>
		/// Whether the SelectorItem will handle touches. This can be set to false for compatibility with controls where the parent 
		/// handles touches (ComboBox-Android, legacy ListView/GridView). 
		/// </summary>
		internal bool ShouldHandlePressed { get; set; } = true;

		public SelectorItem()
		{
		}

		/// <remarks>
		/// Ensure that the ContentControl will create its chidren even
		/// if it has no parent view. This is critical for the recycling panels,
		/// where the content is databound before being assigned to its
		/// parent and displayed.
		/// </remarks>
		protected override bool CanCreateTemplateWithoutParent { get; } = true;

		private Selector Selector => ItemsControl.ItemsControlFromItemContainer(this) as Selector;

		private bool IsItemClickEnabled
		{
			get
			{
				if (!(Selector is ListViewBase listViewBase))
				{
					return true;
				}

				return listViewBase.IsItemClickEnabled || listViewBase.SelectionMode != ListViewSelectionMode.None;
			}
		}

		private class CommonStates
		{
			public const string Selected = "Selected";
			public const string Normal = "Normal";
			public const string Pressed = "Pressed";
			public const string PressedSelected = "PressedSelected";
		}

		private class DisabledStates
		{
			public const string Enabled = "Enabled";
			public const string Disabled = "Disabled";
		}

		protected override void OnIsEnabledChanged(bool oldValue, bool newValue)
		{
			var disabledStates = newValue ? DisabledStates.Enabled : DisabledStates.Disabled;
			VisualStateManager.GoToState(this, disabledStates, true);

			base.OnIsEnabledChanged(oldValue, newValue);
		}

		private bool _isPressed;

		// The default state of this variable must follow the default state of the
		// associated UI elements in the generic template.
		private bool _isMultiSelectedEnabled;

		internal bool IsPressed
		{
			get { return _isPressed; }
			set
			{
				using (InterceptSetNeedsLayout())
				{
					_isPressed = value;
					UpdateCommonStates();
				}
			}
		}


		/// <summary>
		/// Set appropriate visual state from MultiSelectStates group. (https://msdn.microsoft.com/en-us/library/windows/apps/mt299136.aspx?f=255&MSPPError=-2147217396)
		/// </summary>
		internal bool IsMultiselectEnabled
		{
			get { return _isMultiSelectedEnabled; }
			set {

				if (_isMultiSelectedEnabled != value)
				{
					// The MultiSelectDisabled state goes through VisibleRect then collapsed, which means Disabled state can't be
					// invoked if the state is already disabled without having the selected check box appearing briefly. (Issue #403)
					VisualStateManager.GoToState(this, value ? "MultiSelectEnabled" : "MultiSelectDisabled", useTransitions: true);

					_isMultiSelectedEnabled = value;
				}
			}
		}

		partial void OnIsSelectedChangedPartial(bool oldIsSelected, bool newIsSelected)
		{
			UpdateCommonStates();
		}

		public void UpdateCommonStates()
		{
			var state = CommonStates.Normal;
			if (IsSelected && IsPressed)
			{
				state = CommonStates.PressedSelected;
			}
			else if (IsSelected)
			{
				state = CommonStates.Selected;
			}
			else if (IsPressed)
			{
				state = CommonStates.Pressed;
			}

			SetVisualState(state, true);
		}

		internal protected virtual void SetVisualState(string state, bool useTransitions)
		{
			VisualStateManager.GoToState(this, state, useTransitions);
		}

		protected override void OnLoaded()
		{
			base.OnLoaded();
			IsPressed = false;
#if XAMARIN_ANDROID
			Focusable = true;
			FocusableInTouchMode = true;
#endif
		}

		protected override void OnPointerPressed(PointerRoutedEventArgs args)
		{
			if (!ShouldHandlePressed || !IsItemClickEnabled)
			{
				return;
			}

			IsPressed = true;
			args.Handled = true;
#if !__WASM__
			Focus(FocusState.Pointer);
#endif
			base.OnPointerPressed(args);
		}

		protected override void OnPointerCanceled(PointerRoutedEventArgs args)
		{
			if (!ShouldHandlePressed || !IsItemClickEnabled)
			{
				return;
			}

			IsPressed = false;
			base.OnPointerCanceled(args);
		}

		protected override void OnPointerReleased(PointerRoutedEventArgs args)
		{
			if (!ShouldHandlePressed || !IsItemClickEnabled)
			{
				return;
			}

			Selector?.OnItemClicked(this);
			base.OnPointerReleased(args);

			CoreDispatcher.Main
				.RunAsync(
					CoreDispatcherPriority.Normal,
					async () =>
					{
						await Task.Delay(MinTimeBetweenPressStates);
						IsPressed = false;
					}
				);
		}

		protected override void OnPointerExited(PointerRoutedEventArgs args)
		{
			if (!ShouldHandlePressed || !IsItemClickEnabled)
			{
				return;
			}

			IsPressed = false;
			base.OnPointerExited(args);
		}

		private IDisposable InterceptSetNeedsLayout()
		{
#if XAMARIN_IOS
			bool match(UIView view) => view is ListViewBaseInternalContainer || view is Selector;
			var cell = this.FindFirstParent<UIView>(predicate: match);
			return (cell as ListViewBaseInternalContainer)?.InterceptSetNeedsLayout();
#else
			return null;
#endif
		}
	}
}
