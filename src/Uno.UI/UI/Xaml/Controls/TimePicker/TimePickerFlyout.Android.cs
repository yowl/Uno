﻿#if XAMARIN_ANDROID
using Android.OS;
using System;
using Uno.UI;
using Uno.UI.Extensions;
using Windows.Globalization;
using Windows.UI.Xaml.Controls.Primitives;
using static Android.App.TimePickerDialog;

namespace Windows.UI.Xaml.Controls
{
	public partial class TimePickerFlyout : FlyoutBase
	{
		private UnoTimePickerDialog _dialog;
		private TimeSpan _initialTime;

		internal protected override void Open()
		{
			SaveInitialTime();

			//Minute increments are not supported with clock and Samsung devices running marshmallow (Android 6.0)
			//show the clock as truncated in landscape. The spinner style is enforced in these two cases.

			var isSamsungAndMarshmellow = Build.VERSION.SdkInt == BuildVersionCodes.M &&
										  Build.Manufacturer.ToLower().IndexOf("samsung") >= 0;

			var tryEnforceSpinnerStyle = isSamsungAndMarshmellow || MinuteIncrement > 1;

			ShowTimePicker(tryEnforceSpinnerStyle);
		}

		private void SaveInitialTime() => _initialTime = Time;

		internal protected override void Close() { base.Close(); }

		private void SaveTime(TimeSpan time)
		{
			if (Time != time)
			{
				Time = time;
				SaveInitialTime();
			}
		}

		private void AdjustAndSaveTime(int hourOfDay, int minutes)
		{
			if (Time.Hours != hourOfDay || Time.Minutes != minutes)
			{
				if (_dialog.IsInSpinnerMode)
				{
					minutes = minutes * MinuteIncrement;
				}

				var time = new TimeSpan(Time.Days, hourOfDay, minutes, Time.Seconds, Time.Milliseconds);
				SaveTime(time.RoundToMinuteInterval(MinuteIncrement));
			}
		}

		private void ShowTimePicker(bool useSpinnerStyle)
		{
			var time = Time.RoundToNextMinuteInterval(MinuteIncrement);
			var listener = new OnSetTimeListener((view, hourOfDay, minute) => AdjustAndSaveTime(hourOfDay, minute));
			int timePickerStyleResId = useSpinnerStyle ? 3 : 0;

			_dialog = new UnoTimePickerDialog(
					ContextHelper.Current,
					timePickerStyleResId,
					listener,
					time.Hours,
					time.Minutes,
					ClockIdentifier == ClockIdentifiers.TwentyFourHour,
					MinuteIncrement
				);

			_dialog.DismissEvent += OnDismiss;
			_dialog.Show();
		}

		private void OnDismiss(object sender, EventArgs e)
		{
			Hide(canCancel: false);
		}

		partial void OnTimeChangedPartialNative(TimeSpan oldTime, TimeSpan newTime) { }

		public class OnSetTimeListener : Java.Lang.Object, IOnTimeSetListener
		{
			private Action<Android.Widget.TimePicker, int, int> _action;

			public OnSetTimeListener(Action<Android.Widget.TimePicker, int, int> action)
			{
				_action = action;
			}

			public void OnTimeSet(Android.Widget.TimePicker view, int hourOfDay, int minute) => _action(view, hourOfDay, minute);
		}
	}
}
#endif
