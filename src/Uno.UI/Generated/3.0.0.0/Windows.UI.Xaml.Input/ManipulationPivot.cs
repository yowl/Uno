#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ManipulationPivot 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double Radius
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ManipulationPivot.Radius is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Input.ManipulationPivot", "double ManipulationPivot.Radius");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point Center
		{
			get
			{
				throw new global::System.NotImplementedException("The member Point ManipulationPivot.Center is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Input.ManipulationPivot", "Point ManipulationPivot.Center");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ManipulationPivot( global::Windows.Foundation.Point center,  double radius) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Input.ManipulationPivot", "ManipulationPivot.ManipulationPivot(Point center, double radius)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Input.ManipulationPivot.ManipulationPivot(Windows.Foundation.Point, double)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ManipulationPivot() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Input.ManipulationPivot", "ManipulationPivot.ManipulationPivot()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Input.ManipulationPivot.ManipulationPivot()
		// Forced skipping of method Windows.UI.Xaml.Input.ManipulationPivot.Center.get
		// Forced skipping of method Windows.UI.Xaml.Input.ManipulationPivot.Center.set
		// Forced skipping of method Windows.UI.Xaml.Input.ManipulationPivot.Radius.get
		// Forced skipping of method Windows.UI.Xaml.Input.ManipulationPivot.Radius.set
	}
}
