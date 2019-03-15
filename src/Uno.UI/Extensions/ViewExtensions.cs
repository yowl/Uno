#if NET461 || __WASM__
using System;
using System.Collections.Generic;
using System.Linq;
using Uno.Disposables;
using System.Text;

using Uno.Extensions;
using Uno.Logging;
using Windows.UI.Xaml;
using Uno.UI.Extensions;
using System.Drawing;
using Windows.UI.Core;
using System.Threading.Tasks;

using _ViewGroup = Windows.UI.Xaml.UIElement;
using _View = Windows.UI.Xaml.UIElement;

namespace Uno.UI
{
	public static partial class ViewExtensions
	{
		/// <summary>
		/// Enumerates all the children for a specified view group.
		/// </summary>
		/// <param name="view">The view group to get the children from</param>
		/// <param name="selector">The selector function</param>
		/// <param name="maxDepth">The depth to stop looking for children.</param>
		/// <returns>A lazy enumerable of views</returns>
		public static IEnumerable<_View> EnumerateAllChildren(this _ViewGroup view, Func<_View, bool> selector, int maxDepth = 20)
		{
			var children = view.GetChildren().OfType<UIElement>();

			foreach (var sub in children)
			{
				if (selector(sub))
				{
					yield return sub;
				}
				else if (maxDepth > 0)
				{
					var childGroup = sub as _ViewGroup;

					if (childGroup != null)
					{
						foreach (var subResult in childGroup.EnumerateAllChildren(selector, maxDepth - 1))
						{
							yield return subResult;
						}
					}
				}
			}
		}

		/// <summary>
		/// Enumerates all the children for a specified view group.
		/// </summary>
		/// <param name="view">The view group to get the children from</param>
		/// <param name="maxDepth">The depth to stop looking for children.</param>
		/// <returns>A lazy enumerable of views</returns>
		public static IEnumerable<_View> EnumerateAllChildren(this _ViewGroup view, int maxDepth = 20)
		{
			var children = view.GetChildren().OfType<UIElement>();

			foreach (var sub in children)
			{
				yield return sub;

				if (maxDepth > 0)
				{
					var childGroup = sub as _ViewGroup;

					if (childGroup != null)
					{
						foreach (var subResult in childGroup.EnumerateAllChildren(maxDepth - 1))
						{
							yield return subResult;
						}
					}
				}
			}
		}
	}
}
#endif