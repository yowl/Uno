using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
	public partial class CoreWindow 
	{
		public global::Windows.UI.Core.CoreCursor PointerCursor { get; set; }

		public static CoreWindow CurrentThreadCoreWindow { get; set; }

		[global::Uno.NotImplemented]
		public global::Windows.UI.Core.CoreVirtualKeyStates GetKeyState(global::Windows.System.VirtualKey virtualKey)
		{
			return CoreVirtualKeyStates.None;
		}

		public static global::Windows.UI.Core.CoreWindow GetForCurrentThread()
		{
			return CurrentThreadCoreWindow;
		}
	}
}
