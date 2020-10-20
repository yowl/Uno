﻿using System;
using System.Collections.Generic;
using System.Linq;
using Uno.Disposables;
using System.Text;
using System.Threading.Tasks;
using Uno.Extensions;
using Uno;
using Uno.Logging;
using Windows.UI.Xaml.Controls;
using Windows.Foundation;
using View = Windows.UI.Xaml.UIElement;
using System.Collections;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Media;
using Uno.UI;
using Uno.UI.Xaml;
using Windows.UI;
using System.Dynamic;

namespace Windows.UI.Xaml
{
	public partial class FrameworkElement : IEnumerable
	{
		bool IFrameworkElementInternal.HasLayouter => true;

		partial void OnLoadingPartial();

		private protected virtual void OnPostLoading()
		{
		}

		/*
			About NativeOn** vs ManagedOn** methods:
				The flag FeatureConfiguration.FrameworkElement.WasmUseManagedLoadedUnloaded will configure which set of methods will be used
				but they are mutually exclusive: Only one of each is going to be invoked.

			For the managed methods: for perf consideration (avoid lots of casting) the loaded state is managed by the UI Element,
				the FrameworkElement only makes it publicly available by overriding methods from UIElement and raising events.
				The propagation of this loaded state is also made by the UIElement.
		 */

		internal sealed override void ManagedOnLoading()
		{
			base.IsLoading = true;
			Application.PrintLine("ManagedOnLoading " + GetType().FullName);
			OnLoadingPartial();
			Application.PrintLine("ManagedOnLoading OnLoadingPartial");

			ApplyCompiledBindings();
			Application.PrintLine("ManagedOnLoading ApplyCompiledBindings");

			try
			{
				// Raise event before invoking base in order to raise them top to bottom
				_loading?.Invoke(this, new RoutedEventArgs(this));
				Application.PrintLine("ManagedOnLoading Invoke");

			}
			catch (Exception error)
			{
				_log.Error("ManagedOnLoading failed in FrameworkElement", error);
				Application.Current.RaiseRecoverableUnhandledException(error);
			}

			OnPostLoading();
			Application.PrintLine("ManagedOnLoading OnPostLoading");

			// Explicit propagation of the loading even must be performed
			// after the compiled bindings are applied (cf. OnLoading), as there may be altered
			// properties that affect the visual tree.
			base.ManagedOnLoading();
			Application.PrintLine("ManagedOnLoading base.ManagedOnLoading");

		}

		private void NativeOnLoading(object sender, RoutedEventArgs args)
		{
			OnLoadingPartial();
			ApplyCompiledBindings();

			// Explicit propagation of the loading even must be performed
			// after the compiled bindings are applied, as there may be altered
			// properties that affect the visual tree.
			foreach (var child in _children)
			{
				(child as FrameworkElement)?.InternalDispatchEvent("loading", args);
			}
		}

		internal sealed override void ManagedOnLoaded(int depth)
		{
			if (!base.IsLoaded)
			{
				// Make sure to set the flag before raising the loaded event (duplicated with the base.ManagedOnLoaded)
				base.IsLoaded = true;
				base.IsLoading = false;

				if (FeatureConfiguration.UIElement.AssignDOMXamlProperties)
				{
					UpdateDOMProperties();
				}

				try
				{
					// Raise event before invoking base in order to raise them top to bottom
					OnLoaded();
					_loaded?.Invoke(this, new RoutedEventArgs(this));
				}
				catch (Exception error)
				{
					_log.Error("ManagedOnLoaded failed in FrameworkElement", error);
					Application.Current.RaiseRecoverableUnhandledException(error);
				}
			}

			base.ManagedOnLoaded(depth);
		}

		private void NativeOnLoaded(object sender, RoutedEventArgs args)
		{
			base.IsLoaded = true;

			foreach (var child in _children)
			{
				(child as FrameworkElement)?.InternalDispatchEvent("loaded", args);
			}

			try
			{
				OnLoaded();
			}
			catch (Exception error)
			{
				_log.Error("NativeOnLoaded failed in FrameworkElement", error);
				Application.Current.RaiseRecoverableUnhandledException(error);
			}
		}

		internal sealed override void ManagedOnUnloaded()
		{
			base.ManagedOnUnloaded(); // Will set flag IsLoaded to false

			try
			{
				// Raise event after invoking base in order to raise them bottom to top
				OnUnloaded();
				_unloaded?.Invoke(this, new RoutedEventArgs(this));
			}
			catch (Exception error)
			{
				_log.Error("ManagedOnUnloaded failed in FrameworkElement", error);
				Application.Current.RaiseRecoverableUnhandledException(error);
			}
		}

		private void NativeOnUnloaded(object sender, RoutedEventArgs args)
		{
			base.IsLoaded = false;

			foreach (var child in _children)
			{
				(child as FrameworkElement)?.InternalDispatchEvent("unloaded", args);
			}

			try
			{
				OnUnloaded();
			}
			catch (Exception error)
			{
				_log.Error("NativeOnUnloaded failed in FrameworkElement", error);
				Application.Current.RaiseRecoverableUnhandledException(error);
			}
		}

		public bool HasParent()
		{
			return Parent != null;
		}

		private Size _actualSize;
		public double ActualWidth => GetActualWidth();
		public double ActualHeight => GetActualHeight();

		public event SizeChangedEventHandler SizeChanged;

		internal void RaiseSizeChanged(SizeChangedEventArgs args)
		{
			SizeChanged?.Invoke(this, args);
			_renderTransform?.UpdateSize(args.NewSize);
		}

		internal void SetActualSize(Size size) => _actualSize = size;

		private protected virtual double GetActualWidth() => _actualSize.Width;
		private protected virtual double GetActualHeight() => _actualSize.Height;

		partial void OnGenericPropertyUpdatedPartial(DependencyPropertyChangedEventArgs args);

		private event RoutedEventHandler _loading;
		public event RoutedEventHandler Loading
		{
			add
			{
				Application.PrintLine("Loading add");
				if (FeatureConfiguration.FrameworkElement.WasmUseManagedLoadedUnloaded)
				{
					_loading += value;
				}
				else
				{
					RegisterEventHandler("loading", value);
				}
				Application.PrintLine("Loading add end");

			}
			remove
			{
				if (FeatureConfiguration.FrameworkElement.WasmUseManagedLoadedUnloaded)
				{
					_loading -= value;
				}
				else
				{
					UnregisterEventHandler("loading", value);
				}
			}
		}

		private event RoutedEventHandler _loaded;
		public event RoutedEventHandler Loaded
		{
			add
			{
				Application.PrintLine("Loaded add");

				if (FeatureConfiguration.FrameworkElement.WasmUseManagedLoadedUnloaded)
				{
					_loaded += value;
				}
				else
				{
					RegisterEventHandler("loaded", value);
				}
				Application.PrintLine("Loaded add end");

			}
			remove
			{
				if (FeatureConfiguration.FrameworkElement.WasmUseManagedLoadedUnloaded)
				{
					_loaded -= value;
				}
				else
				{
					UnregisterEventHandler("loaded", value);
				}
			}
		}

		private event RoutedEventHandler _unloaded;
		public event RoutedEventHandler Unloaded
		{
			add
			{
				if (FeatureConfiguration.FrameworkElement.WasmUseManagedLoadedUnloaded)
				{
					_unloaded += value;
				}
				else
				{
					RegisterEventHandler("unloaded", value);
				}
			}
			remove
			{
				if (FeatureConfiguration.FrameworkElement.WasmUseManagedLoadedUnloaded)
				{
					_unloaded -= value;
				}
				else
				{
					UnregisterEventHandler("unloaded", value);
				}
			}
		}

		public new bool IsLoaded => base.IsLoaded; // The IsLoaded state is managed by the UIElement, FrameworkElement only makes it publicly visible

		private bool IsTopLevelXamlView() => throw new NotSupportedException();

		internal void SuspendRendering() => throw new NotSupportedException();

		internal void ResumeRendering() => throw new NotSupportedException();

		public IEnumerator GetEnumerator() => _children.GetEnumerator();

		protected void SetCornerRadius(CornerRadius cornerRadius)
		{
			var borderRadius = cornerRadius == CornerRadius.None
				? ""
				: $"{cornerRadius.TopLeft}px {cornerRadius.TopRight}px {cornerRadius.BottomRight}px {cornerRadius.BottomLeft}px";

			SetStyle("border-radius", borderRadius);
		}

		protected void SetBorder(Thickness thickness, Brush brush, CornerRadius cornerRadius)
		{
			var borderRadius = cornerRadius == CornerRadius.None
				? ""
				: $"{cornerRadius.TopLeft}px {cornerRadius.TopRight}px {cornerRadius.BottomRight}px {cornerRadius.BottomLeft}px";

			if (thickness == Thickness.Empty)
			{
				SetStyle(
					("border-style", "none"),
					("border-color", ""),
					("border-width", ""),
					("border-radius", borderRadius));
			}
			else
			{
				var borderWidth = $"{thickness.Top.ToStringInvariant()}px {thickness.Right.ToStringInvariant()}px {thickness.Bottom.ToStringInvariant()}px {thickness.Left.ToStringInvariant()}px";
				switch (brush)
				{
					case SolidColorBrush solidColorBrush:
						var borderColor = solidColorBrush.ColorWithOpacity;
						SetStyle(
							("border", ""),
							("border-style", "solid"),
							("border-color", borderColor.ToHexString()),
							("border-width", borderWidth),
							("border-radius", borderRadius));
						break;
					case GradientBrush gradientBrush:
						var border = gradientBrush.ToCssString(RenderSize); // TODO: Reevaluate when size is changing
						SetStyle(
							("border-style", "solid"),
							("border-color", ""),
							("border-image", border),
							("border-width", borderWidth),
							("border-radius", borderRadius));
						break;
					case AcrylicBrush acrylicBrush:
						var acrylicFallbackColor = acrylicBrush.FallbackColorWithOpacity;
						SetStyle(
							("border", ""),
							("border-style", "solid"),
							("border-color", acrylicFallbackColor.ToHexString()),
							("border-width", borderWidth),
							("border-radius", borderRadius));
						break;
					default:
						ResetStyle("border-style", "border-color", "border-image", "border-width", "border-radius");
						break;
				}
			}
		}

		internal override bool IsEnabledOverride() => IsEnabled && base.IsEnabledOverride();

		#region Margin Dependency Property
		[GeneratedDependencyProperty(
			Options = FrameworkPropertyMetadataOptions.AutoConvert | FrameworkPropertyMetadataOptions.AffectsMeasure
#if DEBUG
			, ChangedCallbackName = nameof(OnGenericPropertyUpdated)
#endif
		)]
		public static DependencyProperty MarginProperty { get ; } = CreateMarginProperty();

		public virtual Thickness Margin
		{
			get => GetMarginValue();
			set => SetMarginValue(value);
		}
		private static Thickness GetMarginDefaultValue() => Thickness.Empty;
		#endregion

		#region HorizontalAlignment Dependency Property
		[GeneratedDependencyProperty(
			DefaultValue = Xaml.HorizontalAlignment.Stretch,
			Options = FrameworkPropertyMetadataOptions.AutoConvert | FrameworkPropertyMetadataOptions.AffectsMeasure
#if DEBUG
			, ChangedCallbackName = nameof(OnGenericPropertyUpdated)
#endif
		)]
		public static DependencyProperty HorizontalAlignmentProperty { get ; } = CreateHorizontalAlignmentProperty();

		public HorizontalAlignment HorizontalAlignment
		{
			get => GetHorizontalAlignmentValue();
			set => SetHorizontalAlignmentValue(value);
		}
		#endregion

		#region HorizontalAlignment Dependency Property
		[GeneratedDependencyProperty(
			DefaultValue = Xaml.HorizontalAlignment.Stretch,
			Options = FrameworkPropertyMetadataOptions.AutoConvert | FrameworkPropertyMetadataOptions.AffectsMeasure
#if DEBUG
			, ChangedCallbackName = nameof(OnGenericPropertyUpdated)
#endif
		)]
		public static DependencyProperty VerticalAlignmentProperty { get ; } = CreateVerticalAlignmentProperty();

		public VerticalAlignment VerticalAlignment
		{
			get => GetVerticalAlignmentValue();
			set => SetVerticalAlignmentValue(value);
		}
		#endregion

		#region Width Dependency Property
		[GeneratedDependencyProperty(
			DefaultValue = double.NaN,
			Options = FrameworkPropertyMetadataOptions.AutoConvert | FrameworkPropertyMetadataOptions.AffectsMeasure
#if DEBUG
			, ChangedCallbackName = nameof(OnGenericPropertyUpdated)
#endif
		)]
		public static DependencyProperty WidthProperty { get ; } = CreateWidthProperty();

		public double Width
		{
			get => GetWidthValue();
			set => SetWidthValue(value);
		}
		#endregion

		#region Height Dependency Property
		[GeneratedDependencyProperty(
			DefaultValue = double.NaN,
			Options = FrameworkPropertyMetadataOptions.AutoConvert | FrameworkPropertyMetadataOptions.AffectsMeasure
#if DEBUG
			, ChangedCallbackName = nameof(OnGenericPropertyUpdated)
#endif
		)]
		public static DependencyProperty HeightProperty { get ; } = CreateHeightProperty();

		public double Height
		{
			get => GetHeightValue();
			set => SetHeightValue(value);
		}
		#endregion

		#region MinWidth Dependency Property
		[GeneratedDependencyProperty(
			DefaultValue = 0.0d,
			Options = FrameworkPropertyMetadataOptions.AutoConvert | FrameworkPropertyMetadataOptions.AffectsMeasure
#if DEBUG
			, ChangedCallbackName = nameof(OnGenericPropertyUpdated)
#endif
		)]
		public static DependencyProperty MinWidthProperty { get ; } = CreateMinWidthProperty();

		public double MinWidth
		{
			get => GetMinWidthValue();
			set => SetMinWidthValue(value);
		}
		#endregion

		#region MinHeight Dependency Property

		[GeneratedDependencyProperty(
			DefaultValue = 0.0d,
			Options = FrameworkPropertyMetadataOptions.AutoConvert | FrameworkPropertyMetadataOptions.AffectsMeasure
#if DEBUG
			, ChangedCallbackName = nameof(OnGenericPropertyUpdated)
#endif
		)]
		public static DependencyProperty MinHeightProperty { get ; } = CreateMinHeightProperty();

		public double MinHeight
		{
			get => GetMinHeightValue();
			set => SetMinHeightValue(value);
		}
		#endregion

		#region MaxWidth Dependency Property
		[GeneratedDependencyProperty(
			DefaultValue = double.PositiveInfinity,
			Options = FrameworkPropertyMetadataOptions.AutoConvert | FrameworkPropertyMetadataOptions.AffectsMeasure
#if DEBUG
			, ChangedCallbackName = nameof(OnGenericPropertyUpdated)
#endif
		)]
		public static DependencyProperty MaxWidthProperty { get ; } = CreateMaxWidthProperty();

		public double MaxWidth
		{
			get => GetMaxWidthValue();
			set => SetMaxWidthValue(value);
		}
		#endregion

		#region MaxHeight Dependency Property

		[GeneratedDependencyProperty(
			DefaultValue = double.PositiveInfinity,
			Options = FrameworkPropertyMetadataOptions.AutoConvert | FrameworkPropertyMetadataOptions.AffectsMeasure
#if DEBUG
			, ChangedCallbackName = nameof(OnGenericPropertyUpdated)
#endif
		)]
		public static DependencyProperty MaxHeightProperty { get ; } = CreateMaxHeightProperty();

		public double MaxHeight
		{
			get => GetMaxHeightValue();
			set => SetMaxHeightValue(value);
		}
		#endregion

		private void OnGenericPropertyUpdated(DependencyPropertyChangedEventArgs args)
		{
			if (FeatureConfiguration.UIElement.AssignDOMXamlProperties)
			{
				UpdateDOMProperties();
			}
		}

		/// <summary>
		/// If corresponding feature flag is enabled, set layout properties as DOM attributes to aid in debugging.
		/// </summary>
		/// <remarks>
		/// Calls to this method should be wrapped in a check of the feature flag, to avoid the expense of a virtual method call
		/// that will most of the time do nothing in hot code paths.
		/// </remarks>
		private protected override void UpdateDOMProperties()
		{
			if (FeatureConfiguration.UIElement.AssignDOMXamlProperties && IsLoaded)
			{
				UpdateDOMXamlProperty(nameof(Margin), Margin);
				UpdateDOMXamlProperty(nameof(HorizontalAlignment), HorizontalAlignment);
				UpdateDOMXamlProperty(nameof(VerticalAlignment), VerticalAlignment);
				UpdateDOMXamlProperty(nameof(Width), Width);
				UpdateDOMXamlProperty(nameof(Height), Height);
				UpdateDOMXamlProperty(nameof(MinWidth), MinWidth);
				UpdateDOMXamlProperty(nameof(MinHeight), MinHeight);
				UpdateDOMXamlProperty(nameof(MaxWidth), MaxWidth);
				UpdateDOMXamlProperty(nameof(MaxHeight), MaxHeight);
				UpdateDOMXamlProperty(nameof(IsEnabled), IsEnabled);

				base.UpdateDOMProperties();
			}
		}

		public override string ToString()
		{
			if (FeatureConfiguration.UIElement.RenderToStringWithId && !Name.IsNullOrEmpty())
			{
				return $"{base.ToString()}\"{Name}\"";
			}

			return base.ToString();
		}
	}
}
