using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using Uno.UI.Extensions;

namespace Uno.UI.Media
{
	partial class NativeRenderTransformAdapter
	{
		partial void Apply(bool isSizeChanged, bool isOriginChanged)
		{
			if (isSizeChanged)
			{
				// As we use the 'AnchorPoint', the transform matrix is independent of the size of the control
			}
			else if (isOriginChanged)
			{
				// Note: On íOS and MacOS Transform are applied by default on the center on the view

				Owner.Layer.AnchorPoint = CurrentOrigin;
			}
			else
			{
				Owner.Layer.Transform = Transform.MatrixCore.ToTransform3D();
			}
		}

		partial void Cleanup()
		{
			Owner.Layer.Transform = CATransform3D.Identity;
		}
	}
}
