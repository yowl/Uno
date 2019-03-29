﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Controls;

namespace Uno.UI
{
	public static class FeatureConfiguration
	{
		public static class UIElement
		{
			/// <summary>
			/// Enables the legacy clipping behavior which only applies binding to itself and 
			/// its children. Normal clipping only applies to a single UIElement considering its
			/// clipping parent, based on <see cref="Windows.UI.Xaml.UIElement.ClipChildrenToBounds"/>.
			/// </summary>
			public static bool UseLegacyClipping { get; set; } = true;

			/// <summary>
			/// Enable the visualization of clipping bounds (intended for diagnostic purposes).
			/// </summary>
			public static bool ShowClippingBounds { get; set; } = false;
		}

		public static class FrameworkElement
		{
			/// <summary>
			/// Enables the behavior for which the style is applied before the inherited
			/// FrameworkElement instances constructors. The UWP behavior is to apply
			/// </summary>
			public static bool UseLegacyApplyStylePhase { get; set; } = false;

			/// <summary>
			/// When changing a style on a <see cref="Windows.UI.Xaml.FrameworkElement"/> clears 
			/// the previous style setters. This property is applicable only when <see cref="UseLegacyApplyStylePhase"/>
			/// is set to <see cref="false"/>.
			/// </summary>
			public static bool ClearPreviousOnStyleChange { get; set; } = true;

#if __ANDROID__
			/// <summary>
			/// Controls the propagation of <see cref="Windows.UI.Xaml.FrameworkElement.Loaded"/> and
			/// <see cref="Windows.UI.Xaml.FrameworkElement.Unloaded"/> events through managed
			/// or native visual tree traversal. 
			/// </summary>
			/// <remarks>
			/// This setting impacts significantly the loading performance of controls on Android.
			/// Setting it to <see cref="true"/> avoids the use of costly Java->C# interop.
			/// </remarks>
			public static bool AndroidUseManagedLoadedUnloaded { get; set; } = true;
#endif

#if __WASM__
			/// <summary>
			/// Controls the propagation of <see cref="Windows.UI.Xaml.FrameworkElement.Loaded"/> and
			/// <see cref="Windows.UI.Xaml.FrameworkElement.Unloaded"/> events through managed
			/// or native visual tree traversal. 
			/// </summary>
			/// <remarks>
			/// This setting impacts significantly the loading performance of controls on Web Assembly.
			/// Setting it to <see cref="true"/> avoids the use of costly JavaScript->C# interop.
			/// </remarks>
			public static bool WasmUseManagedLoadedUnloaded { get; set; } = true;
#endif
		}

		public static class Style
		{
			/// <summary>
			/// Determines if Uno.UI should be using native styles for controls that have
			/// a native counterpart. (e.g. Button, Slider, ComboBox, ...)
			/// </summary>
			public static bool UseUWPDefaultStyles { get; set; } = true;
		}

		public static class Control
		{
			/// <summary>
			/// Make the default value of VerticalContentAlignment and HorizontalContentAlignment be Stretch instead of Center
			/// </summary>
			public static bool UseLegacyContentAlignment { get; set; } = false;

			/// <summary>
			/// Enables the lazy materialization of <see cref="Windows.UI.Xaml.Controls.Control"/> template. This behavior
			/// is not aligned with UWP, which materializes templates immediately, making x:Name controls available
			/// in the constructor of a control.
			/// </summary>
			public static bool UseLegacyLazyApplyTemplate { get; set; } = false;
		}

		public static class DataTemplateSelector
		{
			/// <summary>
			/// When set the false (default value), a call to `SelectTemplateCore(object, DependencyObject)`
			/// will be made as fallback when the `SelectTemplateCore(object)` returns null.
			/// When set to true, only `SelectTemplateCore(object)` is called (Uno's legacy mode).
			/// </summary>
			public static bool UseLegacyTemplateSelectorOverload { get; set; } = false;
		}

		public static class ListViewBase
		{
			/// <summary>
			/// Sets the value to use for <see cref="ItemsStackPanel.CacheLength"/> and <see cref="ItemsWrapGrid.CacheLength"/> if not set 
			/// explicitly in Xaml or code. Higher values will cache more views either side of the visible window, improving list performance 
			/// at the expense of consuming more memory. Setting this to null will leave the default value at the UWP default of 4.0.
			/// </summary>
			public static double? DefaultCacheLength = 1.0;
		}

#if __ANDROID__
		public static class NativeListViewBase
		{
			/// <summary>
			/// Sets this value to remove item animation for <see cref="UnoRecyclerView"/>. This prevents <see cref="UnoRecyclerView"/>
			/// from crashing when pressured: Tmp detached view should be removed from RecyclerView before it can be recycled
			/// </summary>
			public static bool RemoveItemAnimator = true;
		}
#endif

		public static class Page
		{
			/// <summary>
			/// Enables reuse of <see cref="Page"/> instances. Enabling can improve performance when using <see cref="Frame"/> navigation.
			/// </summary>
			public static bool IsPoolingEnabled { get; set; } = false;
		}

		public static class AutomationPeer
		{
			/// <summary>
			/// Enable a mode that simplifies accessibility by automatically grouping accessible elements into top-level accessible elements. The default value is false.
			/// </summary>
			/// <remarks>
			/// When enabled, the accessibility name of top-level accessible elements (elements that return a non-null AutomationPeer in <see cref="UIElement.OnCreateAutomationPeer()"/> and/or have <see cref="AutomationProperties.Name" /> set to a non-empty string) 
			/// will be an aggregate of the accessibility name of all child accessible elements.
			/// 
			/// For example, if you have a <see cref="Button"/> that contains 3 <see cref="TextBlock"/> "A" "B" "C", the accessibility name of the <see cref="Button"/> will be "A, B, C". 
			/// These 3 <see cref="TextBlock"/> will also be automatically excluded from accessibility focus.
			/// 
			/// This greatly facilitates accessibility, as you would need to do this manually on UWP.
			/// 
			/// A limitation of this strategy is that you can't nest interactive elements, as children of an accessible elements are excluded from accessibility focus.
			/// For example, if you put a <see cref="Button"/> inside another <see cref="Button"/>, only the parent <see cref="Button"/> will be focusable.
			/// This happens to match a limitation of iOS, which does this by default and forces developers to make elements as siblings instead of nesting them.
			/// 
			/// To prevent a top-level accessible element from being accessible and make its children accessibility focusable, you can set <see cref="AutomationProperties.AccessibilityViewProperty"/> to <see cref="AccessibilityView.Raw"/>.
			/// 
			/// Note: This is incompatible with the way accessibility works on UWP.
			/// </remarks>
			public static bool UseSimpleAccessibility { get; set; } = false;
		}

		public static class Font
		{
			/// <summary>
			/// Defines the default font to be used when displaying symbols, such as in SymbolIcon.
			/// </summary>
			public static string SymbolsFont { get; set; } =
#if !ANDROID
			"Symbols";
#else
			"ms-appx:///Assets/Fonts/winjs-symbols.ttf#Symbols";
#endif
			/// <summary>
			/// Ignores text scale factor, resulting in a font size as dictated by the control.
			/// </summary>
			public static bool IgnoreTextScaleFactor { get; set; } = false;
		}

#if __WASM__
		public static class Interop
		{
			/// <summary>
			/// Used to control the behavior of the C#/Javascript interop. Setting this
			/// flag to true forces the use of the Javascript eval mode, instead of binary interop.
			/// This flag has no effect when running in hosted mode.
			/// </summary>
			public static bool ForceJavascriptInterop { get; set; } = false;
		}
#endif
	}
}
