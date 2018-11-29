namespace Windows.UI.Xaml.Controls.Primitives
{
	public  partial class NavigationViewItemPresenter : global::Windows.UI.Xaml.Controls.ContentControl
	{
		public  global::Windows.UI.Xaml.Controls.IconElement Icon
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.IconElement)this.GetValue(IconProperty);
			}
			set
			{
				this.SetValue(IconProperty, value);
			}
		}

		public static global::Windows.UI.Xaml.DependencyProperty IconProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Icon", typeof(global::Windows.UI.Xaml.Controls.IconElement), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.NavigationViewItemPresenter), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.IconElement)));

		public NavigationViewItemPresenter() : base()
		{
		}
	}
}
