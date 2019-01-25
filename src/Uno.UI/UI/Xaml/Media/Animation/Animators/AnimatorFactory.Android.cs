using Android.Animation;
using Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.Foundation;
using Uno.UI;

namespace Windows.UI.Xaml.Media.Animation
{
    internal static partial class AnimatorFactory
    {
		private static readonly string __notSupportedProperty = "This property is not supported by GPU enabled animations.";

		/// <summary>
		/// Creates the actual animator instance
		/// </summary>
		internal static IValueAnimator Create(Timeline timeline, double startingValue, double targetValue)
		{
			if (timeline.GetIsDependantAnimation() || timeline.GetIsDurationZero())
			{
				return new NativeValueAnimatorAdapter(ValueAnimator.OfFloat((float)startingValue, (float)targetValue));
			}
			else
			{
				return timeline.GetGPUAnimator(startingValue, targetValue);
			}
		}

		private static NativeValueAnimatorAdapter GetGPUAnimator(this Timeline timeline, double startingValue, double targetValue)
		{
			// Overview    : http://developer.android.com/guide/topics/graphics/prop-animation.html#property-vs-view
			// Performance : http://developer.android.com/guide/topics/graphics/hardware-accel.html#layers-anims
			// Properties  : http://developer.android.com/guide/topics/graphics/prop-animation.html#views

			var info = timeline.PropertyInfo.GetPathItems().Last();
			var target = info.DataContext;
			var property = info.PropertyName.Split('.').Last().Replace("(", "").Replace(")", "");

			if (target is View view)
			{
				switch (property)
				{
					case nameof(FrameworkElement.Opacity):
						return new NativeValueAnimatorAdapter(GetRelativeAnimator(view, "alpha", startingValue, targetValue));
				}
			}

			if (target is TranslateTransform translate)
			{
				switch (property)
				{
					case nameof(TranslateTransform.X):
						return new NativeValueAnimatorAdapter(GetPixelsAnimator(translate.View, "translationX", startingValue, targetValue));

					case nameof(TranslateTransform.Y):
						return new NativeValueAnimatorAdapter(GetPixelsAnimator(translate.View, "translationY", startingValue, targetValue));
				}
			}

			if (target is RotateTransform rotate)
			{
				float pivotX = 0, pivotY = 0;

				switch (property)
				{
					case nameof(RotateTransform.Angle):
						return new NativeValueAnimatorAdapter(GetRelativeAnimator(rotate.View, "rotation", startingValue, targetValue), Prepare, CommitAngle);
				}

				void Prepare()
				{
					pivotX = rotate.View.PivotX;
					pivotY = rotate.View.PivotY;

					// Suspend the matrix transform
					rotate.IsAnimating = true;

					// Apply RotateTransform using native values
					rotate.View.PivotX += (float)rotate.CenterX;
					rotate.View.PivotY += (float)rotate.CenterY;
					rotate.View.Rotation = (float)rotate.Angle;
				}

				void CommitAngle(float finalValue)
				{
					// Remove the native values
					rotate.View.PivotX = pivotX;
					rotate.View.PivotY = pivotY;
					rotate.View.Rotation = 0;

					// Restore the transform matrix and update it
					rotate.IsAnimating = false;
					rotate.Angle = finalValue;
				}
			}

			if (target is ScaleTransform scale)
			{
				float pivotX = 0, pivotY = 0;

				switch (property)
				{
					case nameof(ScaleTransform.ScaleX):
						return new NativeValueAnimatorAdapter(GetRelativeAnimator(scale.View, "scaleX", startingValue, targetValue), Prepare, CommitScaleX);

					case nameof(ScaleTransform.ScaleY):
						return new NativeValueAnimatorAdapter(GetRelativeAnimator(scale.View, "scaleY", startingValue, targetValue), Prepare, CommitScaleY);
				}

				void Prepare()
				{
					pivotX = scale.View.PivotX;
					pivotY = scale.View.PivotY;

					// Suspend the matrix transform
					scale.IsAnimating = true;

					// Apply RotateTransform using native values
					scale.View.PivotX += (float)scale.CenterX;
					scale.View.PivotY += (float)scale.CenterY;
					scale.View.ScaleX = (float)scale.ScaleX;
					scale.View.ScaleY = (float)scale.ScaleY;
				}

				void CommitScaleX(float finalValue)
				{
					// Remove the native values
					scale.View.PivotX = pivotX;
					scale.View.PivotY = pivotY;
					scale.View.ScaleX = 0;
					scale.View.ScaleY = 0;

					// Restore the transform matrix and update it
					scale.IsAnimating = false;
					scale.ScaleX = finalValue;
				}

				void CommitScaleY(float finalValue)
				{
					// Remove the native values
					scale.View.PivotX = pivotX;
					scale.View.PivotY = pivotY;
					scale.View.ScaleX = 0;
					scale.View.ScaleY = 0;

					// Restore the transform matrix and update it
					scale.IsAnimating = false;
					scale.ScaleY = finalValue;
				}
			}

			//if (target is SkewTransform skew)
			//{
			//	switch (property)
			//	{
			//		case nameof(SkewTransform.AngleX):
			//			return ObjectAnimator.OfFloat(skew.View, "scaleX", ViewHelper.LogicalToPhysicalPixels(targetValue), startingValue);
			//
			//		case nameof(SkewTransform.AngleY):
			//			return ObjectAnimator.OfFloat(skew.View, "scaleY", ViewHelper.LogicalToPhysicalPixels(targetValue), startingValue);
			//	}
			//}

			if (target is CompositeTransform composite)
			{
				switch (property)
				{
					case nameof(CompositeTransform.TranslateX):
						return new NativeValueAnimatorAdapter(GetPixelsAnimator(composite.View, "translationX", startingValue, targetValue));

					case nameof(CompositeTransform.TranslateY):
						return new NativeValueAnimatorAdapter(GetPixelsAnimator(composite.View, "translationY", startingValue, targetValue));

					case nameof(CompositeTransform.Rotation):
						return new NativeValueAnimatorAdapter(GetRelativeAnimator(composite.View, "rotation", startingValue, targetValue));

					case nameof(CompositeTransform.ScaleX):
						return new NativeValueAnimatorAdapter(GetRelativeAnimator(composite.View, "scaleX", startingValue, targetValue));

					case nameof(CompositeTransform.ScaleY):
						return new NativeValueAnimatorAdapter(GetRelativeAnimator(composite.View, "scaleY", startingValue, targetValue));

					//case nameof(CompositeTransform.SkewX):
					//	return ObjectAnimator.OfFloat(composite.View, "scaleX", ViewHelper.LogicalToPhysicalPixels(targetValue), startingValue);

					//case nameof(CompositeTransform.SkewY):
					//	return ObjectAnimator.OfFloat(composite.View, "scaleY", ViewHelper.LogicalToPhysicalPixels(targetValue), startingValue);
				}
			}

			throw new NotSupportedException(__notSupportedProperty);
		}

		private static ValueAnimator GetPixelsAnimator(Java.Lang.Object target, string property, double from, double to)
		{
			return ObjectAnimator.OfFloat(target, property, ViewHelper.LogicalToPhysicalPixels(from), ViewHelper.LogicalToPhysicalPixels(to));
		}

		private static ValueAnimator GetRelativeAnimator(Java.Lang.Object target, string property, double from, double to)
		{
			return ObjectAnimator.OfFloat(target, property, (float)from, (float)to);
		}
	}
}
