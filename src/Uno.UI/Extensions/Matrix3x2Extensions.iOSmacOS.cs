using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using CoreAnimation;

namespace Uno.UI.Extensions
{
	internal static class Matrix3x2Extensions
	{
		public static CATransform3D ToTransform3D(this Matrix3x2 matrix)
			=> new CATransform3D
			{
				m11 = matrix.M11, m12 = matrix.M12,
				m21 = matrix.M21, m22 = matrix.M22,
				m31 = matrix.M31, m32 = matrix.M32
			};
	}
}
