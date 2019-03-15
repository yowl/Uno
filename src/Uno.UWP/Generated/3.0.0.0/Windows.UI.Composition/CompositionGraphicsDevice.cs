#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionGraphicsDevice : global::Windows.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.CompositionDrawingSurface CreateDrawingSurface( global::Windows.Foundation.Size sizePixels,  global::Windows.Graphics.DirectX.DirectXPixelFormat pixelFormat,  global::Windows.Graphics.DirectX.DirectXAlphaMode alphaMode)
		{
			throw new global::System.NotImplementedException("The member CompositionDrawingSurface CompositionGraphicsDevice.CreateDrawingSurface(Size sizePixels, DirectXPixelFormat pixelFormat, DirectXAlphaMode alphaMode) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionGraphicsDevice.RenderingDeviceReplaced.add
		// Forced skipping of method Windows.UI.Composition.CompositionGraphicsDevice.RenderingDeviceReplaced.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.CompositionDrawingSurface CreateDrawingSurface2( global::Windows.Graphics.SizeInt32 sizePixels,  global::Windows.Graphics.DirectX.DirectXPixelFormat pixelFormat,  global::Windows.Graphics.DirectX.DirectXAlphaMode alphaMode)
		{
			throw new global::System.NotImplementedException("The member CompositionDrawingSurface CompositionGraphicsDevice.CreateDrawingSurface2(SizeInt32 sizePixels, DirectXPixelFormat pixelFormat, DirectXAlphaMode alphaMode) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.CompositionVirtualDrawingSurface CreateVirtualDrawingSurface( global::Windows.Graphics.SizeInt32 sizePixels,  global::Windows.Graphics.DirectX.DirectXPixelFormat pixelFormat,  global::Windows.Graphics.DirectX.DirectXAlphaMode alphaMode)
		{
			throw new global::System.NotImplementedException("The member CompositionVirtualDrawingSurface CompositionGraphicsDevice.CreateVirtualDrawingSurface(SizeInt32 sizePixels, DirectXPixelFormat pixelFormat, DirectXAlphaMode alphaMode) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Composition.CompositionGraphicsDevice, global::Windows.UI.Composition.RenderingDeviceReplacedEventArgs> RenderingDeviceReplaced
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionGraphicsDevice", "event TypedEventHandler<CompositionGraphicsDevice, RenderingDeviceReplacedEventArgs> CompositionGraphicsDevice.RenderingDeviceReplaced");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionGraphicsDevice", "event TypedEventHandler<CompositionGraphicsDevice, RenderingDeviceReplacedEventArgs> CompositionGraphicsDevice.RenderingDeviceReplaced");
			}
		}
		#endif
	}
}
