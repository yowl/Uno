using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Android.Views;
using Android.Views.Animations;
using Microsoft.Extensions.Logging;
using Uno.Extensions;
using Uno.Logging;
using Uno.UI.Controls;

namespace Uno.UI.Media
{
	partial class NativeRenderTransformAdapter
	{
		private static readonly float[] _identity =
		{
			1, 0, 0,
			0, 1, 0,
			0, 0, 1
		};

		/// <summary>
		/// Gets the native transform that can be applied by the parent ViewGroup for the given child view
		/// </summary>
		internal Android.Graphics.Matrix Matrix { get; } = new Android.Graphics.Matrix();

		partial void Initialized()
			=> UpdateParent(null, Owner.Parent);

		public void UpdateParent(object oldParent, object newParent)
		{
			// The only way to apply a matrix transform on Android is by using the "static transform" on the parent `GroupView`.
			// Here we register on the parent this RenderTransform for on of its children.

			(oldParent as BindableView)?.UnregisterChildTransform(this);

			if (newParent is BindableView newBindableParent)
			{
				newBindableParent.RegisterChildTransform(this);
			}
			else if (newParent != null && this.Log().IsEnabled(LogLevel.Error))
			{
				this.Log().Error(
					$"A RenderTransform was set on '{Owner}', but its parent is not a BindableView ({newParent.GetType().Name}), "
					+ $"so the transform won't have any effect.");
			}
		}

		partial void Apply(Matrix3x2 matrix, bool isSizeChanged)
		{
			if (Transform.IsAnimating)
			{
				Matrix.SetValues(_identity);
				if (isSizeChanged)
				{
					// We must update the PivotX and PivotY
					AnimatorFactory.UpdatePivotWhileAnimating(
						Transform,
						CurrentSize.Width * CurrentOrigin.X,
						CurrentSize.Height * CurrentOrigin.Y);
				}
			}
			else
			{
				Matrix.SetValues(new[]
				{
					matrix.M11, matrix.M21, ViewHelper.LogicalToPhysicalPixels(matrix.M31),
					matrix.M12, matrix.M22, ViewHelper.LogicalToPhysicalPixels(matrix.M32),
					0, 0, 1
				});
				Owner.PivotX = 0;
				Owner.PivotY = 0;

				if (!isSizeChanged)
				{
					Owner.Invalidate();
				}
			}
		}

		partial void Cleanup()
		{
			(Owner.Parent as BindableView)?.UnregisterChildTransform(this);

			Owner.Invalidate();
		} 

		//internal class MatrixTransformation : Transformation
		//{
		//	public static MatrixTransformation Identity { get; } = new MatrixTransformation();

		//	public MatrixTransformation()
		//		: this(Matrix3x2.Identity)
		//	{
		//	}

		//	public MatrixTransformation(Matrix3x2 matrix)
		//	{
		//		Alpha = 1;
		//		TransformationType = TransformationTypes.Matrix;

		//		Set(matrix);
		//	}

		//	public bool IsIdentity { get; private set; }

		//	public void Set(Matrix3x2 matrix)
		//	{
		//		Matrix.SetValues(new[]
		//		{
		//			matrix.M11, matrix.M21, ViewHelper.LogicalToPhysicalPixels(matrix.M31),
		//			matrix.M12, matrix.M22, ViewHelper.LogicalToPhysicalPixels(matrix.M32),
		//			0, 0, 1
		//		});
		//		IsIdentity = matrix.IsIdentity;
		//	}
		//}
	}
}
