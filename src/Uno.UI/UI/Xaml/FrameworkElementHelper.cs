using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using Windows.UI.Xaml;

namespace Uno.UI
{
	/// <summary>
	/// A set of uno.ui-specific helpers for Xaml
	/// </summary>
	public static class FrameworkElementHelper
	{
		/// <summary>
		/// Set the rendering phase, defined via x:Phase.
		/// </summary>
		/// <param name="target">The target <see cref="FrameworkElement"/></param>
		/// <param name="phase">The render phase ID</param>
		public static void SetRenderPhase(FrameworkElement target, int phase)
			=> target.RenderPhase = phase;

		/// <summary>
		/// Sets the x:Phases defined by all the children controls. The control must be the root element of a DataTemplate.
		/// </summary>
		/// <param name="target">The target <see cref="FrameworkElement"/></param>
		/// <param name="declaredPhases">A set of phases used by the children controls.</param>
		public static void SetDataTemplateRenderPhases(FrameworkElement target, int[] declaredPhases)
			=> target.DataTemplateRenderPhases = declaredPhases;

		/// <summary>
		/// When true (normally because the IsUiAutomationMappingEnabled build property is set), setting the <see cref="Name"/> property
		/// programmatically will also set the appropriate test identifier for Android/iOS. Disabled by default because it may interfere
		/// with accessibility features in non-testing scenarios.
		/// On WebAssembly, settings this property also enables the ability for <see cref="Windows.UI.Xaml.Automation.AutomationProperties.AutomationIdProperty"/>
		/// to be applied to the visual tree elements.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool IsUiAutomationMappingEnabled { get; set; } = false;

		public static void SetBaseUri(FrameworkElement target, string uri)
		{
			PrintLine("SetBaseUri");
			if (target is FrameworkElement fe)
			{
				PrintLine("SetBaseUri new Uri " + uri);
				var u = new Uri(uri);
				PrintLine("SetBaseUri created Uri " );
				fe.BaseUri = u;
			}
			PrintLine("SetBaseUri e");
		}

		[DllImport("*")]
		private static unsafe extern int printf(byte* str, byte* unused);
		public struct TwoByteStr
		{
			public byte first;
			public byte second;
		}
		private static unsafe void PrintString(string s)
		{
			int length = s.Length;
			fixed (char* curChar = s)
			{
				for (int i = 0; i < length; i++)
				{
					TwoByteStr curCharStr = new TwoByteStr();
					curCharStr.first = (byte)(*(curChar + i));
					printf((byte*)&curCharStr, null);
				}
			}
		}
		public static void PrintLine(string s)
		{
			PrintString(s);
			PrintString("\n");
		}
	}
}
