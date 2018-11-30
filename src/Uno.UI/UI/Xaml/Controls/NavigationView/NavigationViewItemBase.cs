using Uno.UI;

#if XAMARIN_ANDROID
#elif XAMARIN_IOS_UNIFIED
using UIKit;
#elif __MACOS__
using AppKit;
#endif

namespace Windows.UI.Xaml.Controls
{
	public partial class NavigationViewItemBase : ListViewItem
	{
		public NavigationViewItemBase()
		{
			Loaded += NavigationViewItemBase_Loaded;
		}

		private void NavigationViewItemBase_Loaded(object sender, RoutedEventArgs e)
		{
			if(this.FindFirstParent<NavigationView>() is NavigationView view)
			{
				view.UpdateItemState(this);
			}
		}
	}
}
