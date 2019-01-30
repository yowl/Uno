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
		partial void Initialized()
		{
			// On íOS and MacOS Transform are applied by default on the center on the view
			// so make sure to reset it when the transform is attached to the view
			Apply(isSizeChanged: false, isOriginChanged: true);
		}

		private CATransform3D _transform = CATransform3D.Identity;

		partial void Apply(bool isSizeChanged, bool isOriginChanged)
		{
			if (isSizeChanged)
			{
				// As we use the 'AnchorPoint', the transform matrix is independent of the size of the control
				// But the layouter expects from us that we restore the transform on each measuring phase
				Owner.Layer.Transform = _transform;
			}
			else if (isOriginChanged)
			{
				Owner.Layer.AnchorPoint = CurrentOrigin;
			}
			else
			{
				Owner.Layer.Transform = _transform = Transform.MatrixCore.ToTransform3D();
			}
		}

		partial void Cleanup()
		{
			Owner.Layer.Transform = CATransform3D.Identity;
		}
	}
}
