using System;
using System.Numerics;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Uno.Extensions;

namespace Windows.UI.Xaml.Media
{
	public partial class GeneralTransform : DependencyObject
	{
		protected GeneralTransform() { }

		public GeneralTransform Inverse => InverseCore;

		protected virtual GeneralTransform InverseCore
		{
			get
			{
				Matrix3x2 matrix = Matrix3x2.Identity;

				if (matrix.IsIdentity)
				{
					return this;
				}
				else
				{
					Matrix3x2.Invert(matrix, out var inverse);
					return new MatrixTransform
					{
						Matrix = new Matrix(inverse)
					};
				}
			}
		}

		public Point TransformPoint(Point point)
		{
			Matrix3x2 matrix = Matrix3x2.Identity;

			if (matrix.IsIdentity)
			{
				return point;
			}
			else
			{
				return new Point
				(
					(point.X * matrix.M11) + (point.Y * matrix.M21) + matrix.M31,
					(point.X * matrix.M12) + (point.Y * matrix.M22) + matrix.M32
				);
			}
		}

		public bool TryTransform(Point inPoint, out Point outPoint)
			=> TryTransformCore(inPoint, out outPoint);

		protected virtual bool TryTransformCore(Point inPoint, out Point outPoint)
		{
			Matrix3x2 matrix = Matrix3x2.Identity;

			if (matrix.IsIdentity)
			{
				outPoint = inPoint;
				return false;
			}
			else
			{
				outPoint = new Point
				(
					(inPoint.X * matrix.M11) + (inPoint.Y * matrix.M21) + matrix.M31,
					(inPoint.X * matrix.M12) + (inPoint.Y * matrix.M22) + matrix.M32
				);
				return true;
			}
		}

		public Rect TransformBounds(Rect rect)
			=> TransformBoundsCore(rect);

		protected virtual Rect TransformBoundsCore(Rect rect)
		{
			Matrix3x2 matrix = Matrix3x2.Identity;

			return rect.Transform(matrix);
		}
	}
}
