﻿#if !NET461 && !__MACOS__
using System;
using System.Collections.Generic;
using System.Text;
using Uno;
using Uno.UI;

namespace Windows.UI.Xaml.Controls
{
	public partial class ItemsStackPanel : Panel, IVirtualizingPanel
	{
		VirtualizingPanelLayout _layout;

#if __WASM__
		[NotImplemented]
#endif
		public int FirstVisibleIndex => _layout?.FirstVisibleIndex ?? -1;
#if __WASM__
		[NotImplemented]
#endif
		public int LastVisibleIndex => _layout?.LastVisibleIndex ?? -1;

#if XAMARIN_ANDROID
		public int FirstCacheIndex => _layout.XamlParent.NativePanel.ViewCache.FirstCacheIndex;
		public int LastCacheIndex => _layout.XamlParent.NativePanel.ViewCache.LastCacheIndex;
#endif

		public ItemsStackPanel()
		{
			if (FeatureConfiguration.ListViewBase.DefaultCacheLength.HasValue)
			{
				CacheLength = FeatureConfiguration.ListViewBase.DefaultCacheLength.Value;
			}

#if __WASM__
			CreateLayoutIfNeeded();
			_layout.Initialize(this);
#endif
		}

		VirtualizingPanelLayout IVirtualizingPanel.GetLayouter()
		{
			CreateLayoutIfNeeded();
			return _layout;
		}

		private void CreateLayoutIfNeeded()
		{
			if (_layout == null)
			{
				_layout = new ItemsStackPanelLayout();
				_layout.BindToEquivalentProperty(this, nameof(Orientation));
				_layout.BindToEquivalentProperty(this, nameof(AreStickyGroupHeadersEnabled));
				_layout.BindToEquivalentProperty(this, nameof(GroupHeaderPlacement));
				_layout.BindToEquivalentProperty(this, nameof(GroupPadding));
#if !XAMARIN_IOS
				_layout.BindToEquivalentProperty(this, nameof(CacheLength));
#endif
			}
		}
	}
}

#endif
