#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.AllJoyn
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AllJoynBusObjectStoppedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member int AllJoynBusObjectStoppedEventArgs.Status is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public AllJoynBusObjectStoppedEventArgs( int status) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.AllJoyn.AllJoynBusObjectStoppedEventArgs", "AllJoynBusObjectStoppedEventArgs.AllJoynBusObjectStoppedEventArgs(int status)");
		}
		#endif
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynBusObjectStoppedEventArgs.AllJoynBusObjectStoppedEventArgs(int)
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynBusObjectStoppedEventArgs.Status.get
	}
}
