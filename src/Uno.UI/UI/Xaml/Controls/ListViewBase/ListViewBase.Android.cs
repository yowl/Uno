﻿using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Uno.Disposables;
using Uno.Client;
using Uno.Extensions;
using Uno.Extensions.Specialized;
using Uno.UI;
using Windows.UI.Xaml.Controls.Primitives;
using Uno.Logging;
using Microsoft.Extensions.Logging;
using System;
using Android.Support.V7.Widget;
using Windows.UI.Xaml.Data;
using Windows.UI.Core;
using Android.Views;

namespace Windows.UI.Xaml.Controls
{
	public partial class ListViewBase
	{
		private readonly SerialDisposable _collectionChangedSubscription = new SerialDisposable();
		private readonly SerialDisposable _headerFooterSubscription = new SerialDisposable();

		private void InitializeNativePanel()
		{
			var adapter = new NativeListViewBaseAdapter();
			adapter.Owner = NativePanel;
			NativePanel.CurrentAdapter = adapter;
		}

		private void AddItems(int firstItem, int count, int section)
		{
			var unoIndex = IndexPath.FromRowSection(firstItem, section);
			var recyclerViewIndex = GetDisplayIndexFromIndexPath(unoIndex);
			NativePanel?.CurrentAdapter?.NotifyItemRangeInserted(recyclerViewIndex, count);
		}

		private void RemoveItems(int firstItem, int count, int section)
		{
			var unoIndex = IndexPath.FromRowSection(firstItem, section);
			var recyclerViewIndex = GetDisplayIndexFromIndexPath(unoIndex);
			NativePanel?.CurrentAdapter?.NotifyItemRangeRemoved(recyclerViewIndex, count);
		}

		partial void NativeReplaceItems(int firstItem, int count, int section)
		{
			var unoIndex = IndexPath.FromRowSection(firstItem, section);
			var recyclerViewIndex = GetDisplayIndexFromIndexPath(unoIndex);
			NativePanel?.CurrentAdapter?.NotifyItemRangeChanged(recyclerViewIndex, count);
		}

		partial void AddGroupItems(int groupIndex)
		{
			var adapter = NativePanel?.CurrentAdapter;
			if (adapter == null)
			{
				return;
			}

			var count = GetGroupCount(groupIndex);
			if (count > 0)
			{
				adapter.NotifyItemRangeInserted(GetDisplayIndexFromIndexPath(IndexPath.FromRowSection(0, groupIndex)), count);
			}
		}

		partial void RemoveGroupItems(int groupIndex, int count)
		{
			var adapter = NativePanel?.CurrentAdapter;
			if (adapter == null)
			{
				return;
			}

			if (count > 0)
			{
				adapter.NotifyItemRangeRemoved(GetDisplayIndexFromIndexPath(IndexPath.FromRowSection(0, groupIndex)), count);
			}
		}

		/// <summary>
		/// Add a group using the native in-place modifier.
		/// </summary>
		/// <param name="groupIndexInView">The index of the group from the native collection view's perspective, ie ignoring empty groups 
		/// if HidesIfEmpty=true.</param>
		private void AddGroup(int groupIndexInView)
		{
			NativePanel?.CurrentAdapter?.NotifyItemInserted(GetGroupHeaderDisplayIndex(groupIndexInView));

			NativePanel?.NativeLayout?.NotifyGroupOperation(new GroupOperation { GroupIndex = groupIndexInView, Type = GroupOperationType.Add });
		}

		private void RemoveGroup(int groupIndexInView)
		{
			NativePanel?.CurrentAdapter?.NotifyItemRemoved(GetGroupHeaderDisplayIndex(groupIndexInView));

			NativePanel?.NativeLayout?.NotifyGroupOperation(new GroupOperation { GroupIndex = groupIndexInView, Type = GroupOperationType.Remove });
		}

		private void ReplaceGroup(int groupIndexInView)
		{
			NativePanel?.CurrentAdapter?.NotifyItemChanged(GetGroupHeaderDisplayIndex(groupIndexInView));
		}

		private void Refresh()
		{
			NativePanel?.Refresh();
		}

		internal override DependencyObject ContainerFromIndexInner(int index)
		{
			if (NativePanel != null)
			{
				var position = ConvertIndexToDisplayPosition(index);

				var asSelectorItem = NativePanel?.NativeLayout?.FindViewByAdapterPosition(position) as SelectorItem;

				return asSelectorItem;

			}

			else
			{
				// Not using virtualizing panel
				return base.ContainerFromIndexInner(index);
			}
		}

		private ContentControl ContainerFromGroupIndex(int groupIndex)
		{
			var displayIndex = GetGroupHeaderDisplayIndex(groupIndex);

			var view = NativePanel?.NativeLayout?.FindViewByAdapterPosition(displayIndex);

			if (view is SelectorItem)
			{
				this.Log().Error($"Got item view {view} at {groupIndex} instead of group container.");

				return null;
			}

			return view as ContentControl;
		}

		internal override int IndexFromContainerInner(DependencyObject container)
		{
			if (NativePanel != null)
			{
				var selectorItem = container as SelectorItem;
				if (selectorItem == null)
				{
					return -1;
				}

				if (selectorItem.LayoutParameters is RecyclerView.LayoutParams)
				{
					var displayPosition = NativePanel.GetChildLayoutPosition(selectorItem);
					var index = ConvertDisplayPositionToIndex(displayPosition);
					return index;
				}
			}

			return base.IndexFromContainerInner(container);
		}

		partial void PrepareNativeLayout(VirtualizingPanelLayout layouter)
		{
			layouter.XamlParent = this;
			var disposables = new CompositeDisposable();
			PropertyChangedCallback headerFooterCallback = (_, __) => layouter.UpdateHeaderAndFooter();
			this.RegisterDisposablePropertyChangedCallback(HeaderProperty, headerFooterCallback).DisposeWith(disposables);
			this.RegisterDisposablePropertyChangedCallback(FooterProperty, headerFooterCallback).DisposeWith(disposables);
			this.RegisterDisposablePropertyChangedCallback(HeaderTemplateProperty, headerFooterCallback).DisposeWith(disposables);
			this.RegisterDisposablePropertyChangedCallback(FooterTemplateProperty, headerFooterCallback).DisposeWith(disposables);
			_headerFooterSubscription.Disposable = disposables;
		}

		partial void OnDataContextChangedPartial()
		{
			(NativePanel?.NativeLayout as VirtualizingPanelLayout)?.UpdateHeaderAndFooter();
		}

		partial void ApplyMultiSelectStateToCachedItems()
		{
			foreach (var item in (NativePanel?.CachedItemViews).Safe())
			{
				ApplyMultiSelectState(item);
			}
		}

		internal override object GetElementFromDisplayPosition(int displayPosition)
		{
			//Convention here: if Header and/or Footer should be shown, they correspond to the initial display items
			int adjustedDisplayPosition = displayPosition;
			if (ShouldShowHeader)
			{
				adjustedDisplayPosition--;
				if (adjustedDisplayPosition == -1)
				{
					return ResolveHeaderContext();
				}
			}
			if (ShouldShowFooter)
			{
				adjustedDisplayPosition--;
				if (adjustedDisplayPosition == -1)
				{
					return ResolveFooterContext();
				}
			}
			return base.GetElementFromDisplayPosition(adjustedDisplayPosition);
		}

		internal override int GetDisplayItemCount()
		{
			var displayItemCount = base.GetDisplayItemCount();
			return ConvertIndexToDisplayPosition(displayItemCount);
		}

		internal override int GetDisplayIndexFromIndexPath(IndexPath indexPath)
		{
			var displayIndex = base.GetDisplayIndexFromIndexPath(indexPath);
			return ConvertIndexToDisplayPosition(displayIndex);
		}

		internal override int GetGroupHeaderDisplayIndex(int groupIndex)
		{
			return ConvertIndexToDisplayPosition(base.GetGroupHeaderDisplayIndex(groupIndex));
		}

		internal override bool GetIsGroupHeader(int displayPosition)
		{
			return base.GetIsGroupHeader(ConvertDisplayPositionToIndex(displayPosition));
		}

		internal int ConvertIndexToDisplayPosition(int index)
		{
			if (ShouldShowHeader)
			{
				index++;
			}
			if (ShouldShowFooter)
			{
				index++;
			}
			return index;
		}

		internal int ConvertDisplayPositionToIndex(int position)
		{
			var index = position;
			if (ShouldShowHeader)
			{
				index--;
			}
			if (ShouldShowFooter)
			{
				index--;
			}
			return index;
		}

		internal bool GetIsHeader(int displayPosition)
		{
			if (!ShouldShowHeader)
			{
				return false;
			}
			return displayPosition == 0;
		}

		internal bool GetIsFooter(int displayPosition)
		{
			if (!ShouldShowFooter)
			{
				return false;
			}

			if (ShouldShowHeader)
			{
				return displayPosition == 1;
			}

			return displayPosition == 0;
		}

		public void ScrollIntoView(object item)
		{
			ScrollIntoView(item, ScrollIntoViewAlignment.Default);
		}

		public void ScrollIntoView(object item, ScrollIntoViewAlignment alignment)
		{
			// Dispatching ScrollIntoView on Android prevents issues where layout/render changes
			// occuring during scrolling are not always properly picked up by the layouting/rendering engine.
			Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
			{
				var index = IndexFromItem(item);
				if (index < 0)
				{
					return;
				}
				var displayPosition = ConvertIndexToDisplayPosition(index);
				NativePanel?.ScrollIntoView(displayPosition, alignment);
			});
		}

		public override bool DispatchTouchEvent(MotionEvent e)
		{
			NativePanel?.TrackMotionDirections(e);

			return base.DispatchTouchEvent(e);
		}

		protected internal override IEnumerable<DependencyObject> GetItemsPanelChildren()
		{
			if (NativePanel != null)
			{
				return NativePanel.GetChildren().OfType<DependencyObject>();
			}
			else
			{
				return base.GetItemsPanelChildren();
			}
		}

		/// <summary>
		/// Record of an INotifyCollectionChanged operation which adds/removes groups from the source
		/// </summary>
		internal struct GroupOperation
		{
			public GroupOperationType Type { get; set; }
			public int GroupIndex { get; set; }
		}
		internal enum GroupOperationType
		{
			Add,
			Remove
		}
	}
}
