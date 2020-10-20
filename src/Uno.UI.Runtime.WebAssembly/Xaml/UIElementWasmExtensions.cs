﻿using System;
using Windows.UI.Xaml;
using Uno.UI.Xaml;
using System.Threading.Tasks;
using Uno.Extensions;
using Uno.Foundation;

namespace Windows.UI.Xaml
{
	public static class UIElementWasmExtensions
	{
		/// <summary>
		/// Get the Id of the corresponding element in the HTML DOM
		/// </summary>
		public static string GetHtmlId(this UIElement element)
		{
			return element.HtmlId.ToString();
		}

		/// <summary>
		/// Set one or many CSS styles on a HTML element.
		/// </summary>
		/// <remarks>
		/// The style is using the CSS syntax format, not the DOM syntax.
		/// Ex: for font size, use "font-size", not "fontSize".
		/// </remarks>
		public static void SetCssStyle(this UIElement element, string name, string value)
		{
			WindowManagerInterop.SetStyles(element.HtmlId, new[] {(name, value)});
		}

        /// <summary>
        /// Set one or many CSS styles on a HTML element.
        /// </summary>
        /// <remarks>
        /// The style is using the CSS syntax format, not the DOM syntax.
        /// Ex: for font size, use "font-size", not "fontSize".
        /// </remarks>
        public static void SetCssStyle(this UIElement element, params (string name, string value)[] styles)
        {
            WindowManagerInterop.SetStyles(element.HtmlId, styles);
        }

		/// <summary>
		/// Clear one or many CSS styles from a HTML element.
		/// </summary>
		public static void ClearCssStyle(this UIElement element, params string[] names)
		{
			WindowManagerInterop.ResetStyle(element.HtmlId, names);
		}

		/// <summary>
		/// Set one of the predefined class
		/// </summary>
		/// <remarks>
		/// Useful to switch a control from different modes when each mode is bound
		/// to a specific class.
		/// </remarks>
		public static void SetCssClass(this UIElement element, string[] classes, int index)
		{
			WindowManagerInterop.SetClasses(element.HtmlId, classes, index);
		}

		/// <summary>
		/// Add one or many CSS classes to a HTML element, if not present.
		/// </summary>
		public static void SetCssClass(this UIElement element, params string[] classesToSet)
		{
			WindowManagerInterop.SetUnsetCssClasses(element.HtmlId, classesToSet, null);
		}

		/// <summary>
		/// Remove one or many CSS classes from a HTML element, if defined.
		/// </summary>
		public static void UnsetCssClass(this UIElement element, params string[] classesToUnset)
		{
			WindowManagerInterop.SetUnsetCssClasses(element.HtmlId, null, classesToUnset);
		}

		/// <summary>
		/// Set a HTML attribute to an element.
		/// </summary>
		public static void SetHtmlAttribute(this UIElement element, string name, string value)
		{
			WindowManagerInterop.SetAttribute(element.HtmlId, name, value);
		}

		/// <summary>
		/// Set multiple HTML attributes to an element at the same time.
		/// </summary>
		public static void SetHtmlAttribute(this UIElement element, params (string name, string value)[] attributes)
		{
			WindowManagerInterop.SetAttributes(element.HtmlId, attributes);
		}

		/// <summary>
		/// Get the HTML attribute value of an element
		/// </summary>
		public static string GetHtmlAttribute(this UIElement element, string name)
		{
			return WindowManagerInterop.GetAttribute(element.HtmlId, name);
		}

		/// <summary>
		/// Clear/remove a HTML attribute from an element.
		/// </summary>
		public static void ClearHtmlAttribute(this UIElement element, string name)
		{
			WindowManagerInterop.RemoveAttribute(element.HtmlId, name);
		}

		/// <summary>
		/// Run javascript in the context of a DOM element.
		/// This one is available in the scope as "element".
		/// </summary>
		/// <remarks>
		/// Will work even if the element is not yet loaded into the DOM.
		/// </remarks>
		public static string ExecuteJavascript(this UIElement element, string jsCode)
		{
			var js = @$"
(function(element) {{
{jsCode}
}})(Uno.UI.WindowManager.current.getView({element.HtmlId}));
";
			return WebAssemblyRuntime.InvokeJS(js);
		}

		/// <summary>
		/// Asynchronously run javascript on a DOM element.
		/// This one is available in the scope as "element".
		/// The called code is expected to return something awaitable (a Promise).
		/// </summary>
		/// <remarks>
		/// Will work even if the element is not yet loaded into the DOM.
		/// </remarks>
		public static Task<string> ExecuteJavascriptAsync(this UIElement element, string asyncJsCode)
		{
			var js = @$"
(function(element) {{
const __f = () => {asyncJsCode};
return __f(element);
}})(Uno.UI.WindowManager.current.getView({element.HtmlId}));
";
			return WebAssemblyRuntime.InvokeAsync(js);
		}

		/// <summary>
		/// Set raw HTML Content for this element.
		/// Don't use this when there's child elements managed by Uno or you'll
		/// get expected results.
		/// </summary>
		public static void SetHtmlContent(this UIElement element, string html)
		{
			WindowManagerInterop.SetContentHtml(element.HtmlId, html);
		}

		/// <summary>
		/// Will invoke `addEventListener(<paramref name="eventName"/>)` on the corresponding HTML element.
		/// </summary>
		public static void RegisterHtmlEventHandler(this UIElement element, string eventName, EventHandler handler)
		{
			Application.PrintLine("RegisterHtmlEventHandler " + eventName);
			element.RegisterEventHandler(eventName, handler);
		}

		/// <summary>
		/// Unregister previously registered event with RegisterHtmlEventHandler.
		/// </summary>
		public static void UnregisterHtmlEventHandler(this UIElement element, string eventName, EventHandler handler)
		{
			element.UnregisterEventHandler(eventName, handler);
		}

		/// <summary>
		/// Will invoke `addEventListener(<paramref name="eventName"/>)` on the corresponding HTML element.
		/// </summary>
		/// <remarks>
		/// For use with CustomEvent("name", {detail:{detail here}}).
		/// </remarks>
		/// <param name="isDetailJson">
		/// True will JSON.stringify the detail (payload). False will treat the detail as a string.
		/// </param>
		public static void RegisterHtmlCustomEventHandler(this UIElement element, string eventName, EventHandler<HtmlCustomEventArgs> handler, bool isDetailJson = false)
		{
			var extractor = isDetailJson
				? UIElement.HtmlEventExtractor.CustomEventDetailJsonExtractor
				: UIElement.HtmlEventExtractor.CustomEventDetailStringExtractor;
			Application.PrintLine("RegisterHtmlCustomEventHandler");
			element.RegisterEventHandler(
				eventName,
				handler,
				eventExtractor: extractor,
				payloadConverter: (_, s) => new HtmlCustomEventArgs(s));
		}

		/// <summary>
		/// Unregister previously registered event with RegisterHtmlCustomEventHandler.
		/// </summary>
		public static void UnregisterHtmlCustomEventHandler(this UIElement element, string eventName, EventHandler<HtmlCustomEventArgs> handler)
		{
			element.UnregisterEventHandler(eventName, handler);
		}
	}
}
