#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EdgeGestureEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Input.EdgeGestureKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member EdgeGestureKind EdgeGestureEventArgs.Kind is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Input.EdgeGestureEventArgs.Kind.get
	}
}
