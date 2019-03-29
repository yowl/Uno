using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Uno.Extensions;
using Fragment = Android.Support.V4.App.Fragment;
using Windows.UI.Xaml.Data;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;

namespace Uno.UI.Controls
{
	public partial class BindableFragment : Fragment, DependencyObject
	{
		public BindableFragment(Activity owner, global::Android.Util.IAttributeSet attrs)
		{
			InitializeBinder();
		}
	}
}
