#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Matrix3DProjection : global::Windows.UI.Xaml.Media.Projection
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Media3D.Matrix3D ProjectionMatrix
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Media3D.Matrix3D)this.GetValue(ProjectionMatrixProperty);
			}
			set
			{
				this.SetValue(ProjectionMatrixProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ProjectionMatrixProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ProjectionMatrix", typeof(global::Windows.UI.Xaml.Media.Media3D.Matrix3D), 
			typeof(global::Windows.UI.Xaml.Media.Matrix3DProjection), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Media3D.Matrix3D)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public Matrix3DProjection() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Matrix3DProjection", "Matrix3DProjection.Matrix3DProjection()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Matrix3DProjection.Matrix3DProjection()
		// Forced skipping of method Windows.UI.Xaml.Media.Matrix3DProjection.ProjectionMatrix.get
		// Forced skipping of method Windows.UI.Xaml.Media.Matrix3DProjection.ProjectionMatrix.set
		// Forced skipping of method Windows.UI.Xaml.Media.Matrix3DProjection.ProjectionMatrixProperty.get
	}
}
