using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Uno.Extensions;
using Uno.UI.Views.Controls;
using Windows.UI.Xaml.Data;
using Uno.UI.Converters;
using Uno.Client;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using Uno.Diagnostics.Eventing;
using Uno.UI.Controls;
using Windows.UI.Core;
using System.Globalization;
using Uno.Disposables;
using Uno.Extensions.Specialized;
using Windows.Foundation;
using Windows.UI.Xaml.Controls.Primitives;
using Uno.UI;
using Uno.Logging;
using Uno.UI.Extensions;
using Microsoft.Extensions.Logging;

#if XAMARIN_IOS_UNIFIED
using Foundation;
using UIKit;
using CoreGraphics;
#elif XAMARIN_IOS
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using CGRect = System.Drawing.RectangleF;
using nfloat = System.Single;
using CGPoint = System.Drawing.PointF;
using nint = System.Int32;
using CGSize = System.Drawing.SizeF;
#endif

namespace Windows.UI.Xaml.Controls
{
	[Bindable]
	public partial class ListViewBaseSource : UICollectionViewSource
	{
		/// <summary>
		/// Key used to represent a null DataTemplate in _templateCache and _templateCells dictionaries (because null is a not a valid key) 
		/// </summary>
		private readonly static DataTemplate _nullDataTemplateKey = new DataTemplate(() => null);

		private readonly static IEventProvider _trace = Tracing.Get(TraceProvider.Id);

		private Dictionary<ListViewBaseInternalContainer, List<Action>> _onRecycled = new Dictionary<ListViewBaseInternalContainer, List<Action>>();
		/// <summary>
		/// We include one extra section to ensure Header and Footer can display even when we have no sections (ie an empty grouped source).
		/// </summary>
		internal const int SupplementarySections = 1;

		/// <summary>
		/// Visual element which stops layout requests from propagating up. Used for measuring templates.
		/// </summary>
		private BlockLayout BlockLayout { get; } = new BlockLayout();

		public static class TraceProvider
		{
			public readonly static Guid Id = Guid.Parse("{EE64E62E-67BD-496A-A8B1-4A142642B3A3}");

			public const int ListViewBaseSource_GetCellStart = 1;
			public const int ListViewBaseSource_GetCellStop = 2;
		}


		#region Members
		private DataTemplateSelector _currentSelector;
		private Dictionary<DataTemplate, CGSize> _templateCache = new Dictionary<DataTemplate, CGSize>(DataTemplate.FrameworkTemplateEqualityComparer.Default);
		private Dictionary<DataTemplate, NSString> _templateCells = new Dictionary<DataTemplate, NSString>(DataTemplate.FrameworkTemplateEqualityComparer.Default);
		/// <summary>
		/// The furthest item in the source which has already been materialized. Items up to this point can safely be retrieved.
		/// </summary>
		private NSIndexPath _lastMaterializedItem = NSIndexPath.FromRowSection(0, 0);

		/// <summary>
		/// Is the UICollectionView currently undergoing animated scrolling, either user-initiated or programmatic.
		/// </summary>
		private bool _isInAnimatedScroll;
		#endregion

		public ListViewBaseSource()
		{
		}

		#region Properties

		private WeakReference<NativeListViewBase> _owner;

		public NativeListViewBase Owner
		{
			get { return _owner?.GetTarget(); }
			set { _owner = new WeakReference<NativeListViewBase>(value); }
		}

		#endregion

		public ListViewBaseSource(NativeListViewBase owner)
		{
			Owner = owner;
		}

		#region Overrides
		public override nint NumberOfSections(UICollectionView collectionView)
		{
			var itemsSections = Owner.XamlParent.IsGrouping ?
				Owner.XamlParent.NumberOfDisplayGroups :
				1;
			return itemsSections + SupplementarySections;
		}

		public override nint GetItemsCount(UICollectionView collectionView, nint section)
		{
			int count;
			if (Owner.XamlParent.IsGrouping)
			{
				count = GetGroupedItemsCount(section);
			}
			else
			{
				count = GetUngroupedItemsCount(section);
			}

			if (this.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
			{
				this.Log().Debug($"Count requested for section {section}, returning {count}");
			}
			return count;
		}

		private int GetUngroupedItemsCount(nint section)
		{
			int count;
			if (section == 0)
			{
				count = Owner.XamlParent.NumberOfItems;
			}
			else
			{
				// Extra section added to accommodate header+footer, contains no items.
				count = 0;
			}

			return count;
		}

		private int GetGroupedItemsCount(nint section)
		{
			if ((int)section >= Owner.XamlParent.NumberOfDisplayGroups)
			{
				// Header+footer section which is empty
				return 0;
			}
			return Owner.XamlParent.GetDisplayGroupCount((int)section);
		}

		public override void CellDisplayingEnded(UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			var key = cell as ListViewBaseInternalContainer;

			if (_onRecycled.TryGetValue(key, out var actions))
			{
				foreach (var a in actions) { a(); }
				_onRecycled.Remove(key);
			}

			if (this.Log().IsEnabled(LogLevel.Debug))
			{
				this.Log().LogDebug($"CellDisplayingEnded for cell at {indexPath}");
			}
		}

		/// <summary>
		/// Queues an action to be executed when the provided viewHolder is being recycled.
		/// </summary>
		internal void RegisterForRecycled(ListViewBaseInternalContainer container, Action action)
		{
			if (!_onRecycled.TryGetValue(container, out var actions))
			{
				_onRecycled[container] = actions = new List<Action>();
			}

			actions.Add(action);
		}

		public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
		{
			using (
			   _trace.WriteEventActivity(
				   TraceProvider.ListViewBaseSource_GetCellStart,
				   TraceProvider.ListViewBaseSource_GetCellStop
			   )
			)
			{
				// Marks this item to be materialized, so its actual measured size 
				// is used during the calculation of the layout.
				// This is required for paged lists, so that the layout calculation
				// does not eagerly get all the items of the ItemsSource.
				UpdateLastMaterializedItem(indexPath);

				var index = Owner?.XamlParent?.GetIndexFromIndexPath(IndexPath.FromNSIndexPath(indexPath)) ?? -1;

				var identifier = GetReusableCellIdentifier(indexPath);

				var listView = (NativeListViewBase)collectionView;
				var cell = (ListViewBaseInternalContainer)collectionView.DequeueReusableCell(identifier, indexPath);

				using (cell.InterceptSetNeedsLayout())
				{
					var selectorItem = cell.Content as SelectorItem;

					if (selectorItem == null)
					{
						cell.Owner = Owner;
						selectorItem = Owner?.XamlParent?.GetContainerForIndex(index) as SelectorItem;
						cell.Content = selectorItem;
						if (this.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
						{
							this.Log().Debug($"Creating new view at indexPath={indexPath}.");
						}

						FrameworkElement.InitializePhaseBinding(selectorItem);
					}
					else if (this.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
					{
						this.Log().Debug($"Reusing view at indexPath={indexPath}, previously bound to {selectorItem.DataContext}.");
					}

					Owner?.XamlParent?.PrepareContainerForIndex(selectorItem, index);

					// Normally this happens when the SelectorItem.Content is set, but there's an edge case where after a refresh, a
					// container can be dequeued which happens to have had exactly the same DataContext as the new item.
					cell.ClearMeasuredSize();
				}

				Owner?.XamlParent?.TryLoadMoreItems(index);

				return cell;
			}
		}

		/// <summary>
		/// Update record of the furthest item materialized.
		/// </summary>
		/// <param name="newItem">Item currently being materialized.</param>
		/// <returns>True if the value has changed and the layout would change.</returns>
		internal bool UpdateLastMaterializedItem(NSIndexPath newItem)
		{
			if (newItem.Compare(_lastMaterializedItem) > 0)
			{
				_lastMaterializedItem = newItem;
				return Owner.ItemTemplateSelector != null; ;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Is item in the range of already-materialized items?
		/// </summary>
		private bool IsMaterialized(NSIndexPath itemPath) => itemPath.Compare(_lastMaterializedItem) <= 0;

		// Consider group header to be materialized if first item in group is materialized
		private bool IsMaterialized(int section) => section <= _lastMaterializedItem.Section;

		public override void WillDisplayCell(UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			var index = Owner?.XamlParent?.GetIndexFromIndexPath(IndexPath.FromNSIndexPath(indexPath)) ?? -1;
			var container = cell as ListViewBaseInternalContainer;
			var selectorItem = container?.Content as SelectorItem;
			//Update IsSelected and multi-select state immediately before display, in case either was modified after cell was prefetched but before it became visible
			if (selectorItem != null)
			{
				selectorItem.IsSelected = Owner?.XamlParent?.IsSelected(index) ?? false;
				Owner?.XamlParent?.ApplyMultiSelectState(selectorItem);
			}

			FrameworkElement.RegisterPhaseBinding(container.Content, a => RegisterForRecycled(container, a));

			if (this.Log().IsEnabled(LogLevel.Debug))
			{
				this.Log().LogDebug($"WillDisplayCell for cell at {indexPath}");
			}
		}

		public override UICollectionReusableView GetViewForSupplementaryElement(
			UICollectionView collectionView,
			NSString elementKind,
			NSIndexPath indexPath)
		{
			var listView = (NativeListViewBase)collectionView;

			if (elementKind == NativeListViewBase.ListViewHeaderElementKind)
			{
				return GetBindableSupplementaryView(
					collectionView: collectionView,
					elementKind: NativeListViewBase.ListViewHeaderElementKindNS,
					indexPath: indexPath,
					reuseIdentifier: NativeListViewBase.ListViewHeaderReuseIdentifierNS,
					context: listView.Header,
					template: listView.HeaderTemplate,
					style: null
				);
			}

			else if (elementKind == NativeListViewBase.ListViewFooterElementKind)
			{
				return GetBindableSupplementaryView(
					collectionView: collectionView,
					elementKind: NativeListViewBase.ListViewFooterElementKindNS,
					indexPath: indexPath,
					reuseIdentifier: NativeListViewBase.ListViewFooterReuseIdentifierNS,
					context: listView.Footer,
					template: listView.FooterTemplate,
					style: null
				);
			}

			else if (elementKind == NativeListViewBase.ListViewSectionHeaderElementKind)
			{
				// Ensure correct template can be retrieved
				UpdateLastMaterializedItem(indexPath);

				return GetBindableSupplementaryView(
					collectionView: collectionView,
					elementKind: NativeListViewBase.ListViewSectionHeaderElementKindNS,
					indexPath: indexPath,
					reuseIdentifier: NativeListViewBase.ListViewSectionHeaderReuseIdentifierNS,
					//ICollectionViewGroup.Group is used as context for sectionHeader
					context: listView.XamlParent.GetGroupAtDisplaySection(indexPath.Section).Group,
					template: GetTemplateForGroupHeader(indexPath.Section),
					style: listView.GroupStyle?.HeaderContainerStyle
				);
			}

			else
			{
				throw new NotSupportedException("Unsupported element kind: {0}".InvariantCultureFormat(elementKind));
			}
		}

		private UICollectionReusableView GetBindableSupplementaryView(
			UICollectionView collectionView,
			NSString elementKind,
			NSIndexPath indexPath,
			NSString reuseIdentifier,
			object context,
			DataTemplate template,
			Style style)
		{
			var supplementaryView = (ListViewBaseInternalContainer)collectionView.DequeueReusableSupplementaryView(
				elementKind,
				reuseIdentifier,
				indexPath);

			using (supplementaryView.InterceptSetNeedsLayout())
			{
				if (supplementaryView.Content == null)
				{
					supplementaryView.Owner = Owner;
					var content = CreateContainerForElementKind(elementKind);
					content.HorizontalContentAlignment = HorizontalAlignment.Stretch;
					content.VerticalContentAlignment = VerticalAlignment.Stretch;
					supplementaryView.Content = content
						.Binding("Content", "");
				}
				supplementaryView.Content.ContentTemplate = template;
				supplementaryView.Content.DataContext = context;
				if (style != null)
				{
					supplementaryView.Content.Style = style;
				}
			}

			return supplementaryView;
		}

		internal void SetIsAnimatedScrolling() => _isInAnimatedScroll = true;

		public override void Scrolled(UIScrollView scrollView)
		{
			InvokeOnScroll();
		}

		// Called when user starts dragging
		public override void DraggingStarted(UIScrollView scrollView)
		{
			_isInAnimatedScroll = true;
		}

		// Called when user stops dragging (lifts finger)
		public override void DraggingEnded(UIScrollView scrollView, bool willDecelerate)
		{
			if (!willDecelerate)
			{
				//No fling, send final scroll event
				OnAnimatedScrollEnded();
			}
		}

		// Called when a user-initiated fling comes to a stop
		public override void DecelerationEnded(UIScrollView scrollView)
		{
			OnAnimatedScrollEnded();
		}

		// Called at the end of a programmatic animated scroll
		public override void ScrollAnimationEnded(UIScrollView scrollView)
		{
			OnAnimatedScrollEnded();
		}

		public override void DidZoom(UIScrollView scrollView)
		{
			// Note: untested, more may be needed to support zooming. On ScrollContentPresenter we set ViewForZoomingInScrollView (not 
			// obvious what it would be in the case of a list).
			Owner.XamlParent?.ScrollViewer?.OnZoomInternal((float)Owner.ZoomScale);
		}

		private void OnAnimatedScrollEnded()
		{
			_isInAnimatedScroll = false;
			InvokeOnScroll();
		}

		private void InvokeOnScroll()
		{
			var shouldReportNegativeOffsets = Owner.XamlParent?.ScrollViewer?.ShouldReportNegativeOffsets ?? false;
			// iOS can return, eg, negative values for offset, whereas Windows never will, even for 'elastic' scrolling
			var clampedOffset = shouldReportNegativeOffsets ?
				Owner.ContentOffset :
				Owner.ContentOffset.Clamp(CGPoint.Empty, Owner.UpperScrollLimit);
			Owner.XamlParent?.ScrollViewer?.OnScrollInternal(clampedOffset.X, clampedOffset.Y, isIntermediate: _isInAnimatedScroll);
		}

		public override void WillEndDragging(UIScrollView scrollView, CGPoint velocity, ref CGPoint targetContentOffset)
		{
			// If snap points are enabled, override the target offset with the calculated snap point.
			var snapTo = Owner?.NativeLayout?.GetSnapTo(velocity, targetContentOffset);
			if (snapTo.HasValue)
			{
				targetContentOffset = snapTo.Value;
			}
		}

		#endregion

		internal void ReloadData()
		{
			_lastMaterializedItem = NSIndexPath.FromRowSection(0, 0);
		}

		/// <summary>
		/// Get item container corresponding to an element kind (header, footer, list item, etc)
		/// </summary>
		private ContentControl CreateContainerForElementKind(NSString elementKind)
		{
			if (elementKind == NativeListViewBase.ListViewSectionHeaderElementKindNS)
			{
				return Owner?.XamlParent?.GetGroupHeaderContainer(null);
			}
			else if (elementKind == NativeListViewBase.ListViewItemElementKindNS)
			{
				return Owner?.XamlParent?.GetContainerForIndex(-1) as ContentControl;
			}
			else
			{
				//Used for header and footer
				return ContentControl.CreateItemContainer();
			}
		}

		internal CGSize GetHeaderSize()
		{
			return Owner.HeaderTemplate != null ? GetTemplateSize(Owner.HeaderTemplate, NativeListViewBase.ListViewHeaderElementKindNS) : CGSize.Empty;
		}

		internal CGSize GetFooterSize()
		{
			return Owner.FooterTemplate != null ? GetTemplateSize(Owner.FooterTemplate, NativeListViewBase.ListViewFooterElementKindNS) : CGSize.Empty;
		}

		internal CGSize GetSectionHeaderSize(int section)
		{
			var template = GetTemplateForGroupHeader(section);
			return template.SelectOrDefault(ht => GetTemplateSize(ht, NativeListViewBase.ListViewSectionHeaderElementKindNS), CGSize.Empty);
		}


		public virtual CGSize GetItemSize(UICollectionView collectionView, NSIndexPath indexPath)
		{
			DataTemplate itemTemplate = GetTemplateForItem(indexPath);

			if (_currentSelector != Owner.ItemTemplateSelector)
			{
				// If the templateSelector has changed, clear the cache
				_currentSelector = Owner.ItemTemplateSelector;
				_templateCache.Clear();
				_templateCells.Clear();
			}

			var size = GetTemplateSize(itemTemplate, NativeListViewBase.ListViewItemElementKindNS);

			if (size == CGSize.Empty)
			{
				// The size of the template is usually empty for items that have not been displayed yet when using ItemTemplateSelector.
				// The reason why we can't measure the template is because we do not resolve it, 
				// as it would require enumerating through all items of a possibly virtualized ItemsSource.
				// To ensure a first display (after which they will be properly measured), we need them to have a non-empty size. 
				size = new CGSize(44, 44); // 44 is the default MinHeight/MinWidth of ListViewItem/GridViewItem on UWP.
			}

			return size;
		}

		private DataTemplate GetTemplateForItem(NSIndexPath indexPath)
		{
			if (IsMaterialized(indexPath))
			{
				return Owner?.XamlParent?.ResolveItemTemplate(Owner.XamlParent.GetDisplayItemFromIndexPath(indexPath.ToIndexPath()));
			}
			else
			{
				// Ignore ItemTemplateSelector since we do not know what the item is
				return Owner?.XamlParent?.ItemTemplate;
			}
		}

		private DataTemplate GetTemplateForGroupHeader(int section)
		{
			var groupStyle = Owner.GroupStyle;
			if (IsMaterialized(section))
			{
				return DataTemplateHelper.ResolveTemplate(
					groupStyle?.HeaderTemplate,
					groupStyle?.HeaderTemplateSelector,
					Owner.XamlParent.GetGroupAtDisplaySection(section).Group,
					Owner);
			}
			else
			{
				return groupStyle?.HeaderTemplate;
			}
		}

		/// <summary>
		/// Gets the actual item template size, using a non-databound materialized
		/// view of the template.
		/// </summary>
		/// <param name="dataTemplate">A data template</param>
		/// <returns>The actual size of the template</returns>
		private CGSize GetTemplateSize(DataTemplate dataTemplate, NSString elementKind)
		{
			//TODO: this should take an available breadth
			CGSize size;

			// Cache the sizes to avoid creating new templates everytime.
			if (!_templateCache.TryGetValue(dataTemplate ?? _nullDataTemplateKey, out size))
			{
				var container = CreateContainerForElementKind(elementKind);

				Style style = null;
				if (elementKind == NativeListViewBase.ListViewItemElementKind)
				{
					style = Owner.ItemContainerStyle;
				}
				else if (elementKind == NativeListViewBase.ListViewSectionHeaderElementKind)
				{
					style = Owner.GroupStyle?.HeaderContainerStyle;
				}
				if (style != null)
				{
					container.Style = style;
				}

				container.ContentTemplate = dataTemplate;
				try
				{
					// Attach templated container to visual tree while measuring. This works around the bug that default Style is not 
					// applied until view is loaded.
					Owner.XamlParent.AddSubview(BlockLayout);
					BlockLayout.AddSubview(container);
					size = Owner.NativeLayout.Layouter.MeasureChild(container, new Size(double.MaxValue, double.MaxValue));

					if ((size.Height > nfloat.MaxValue / 2 || size.Width > nfloat.MaxValue / 2) &&
						this.Log().IsEnabled(LogLevel.Warning)
					)
					{
						this.Log().LogWarning($"Infinite item size reported, this can crash {nameof(UICollectionView)}.");
					}
				}
				finally
				{
					Owner.XamlParent.RemoveChild(BlockLayout);
					BlockLayout.RemoveChild(container);
				}

				_templateCache[dataTemplate ?? _nullDataTemplateKey] = size;
			}

			return size;
		}

		/// <summary>
		/// Determine the identifier to use for the dequeuing.
		/// This avoid for already materialized items with a specific template
		/// to switch to a different template, and have to re-create the content 
		/// template.
		/// </summary>
		private NSString GetReusableCellIdentifier(NSIndexPath indexPath)
		{
			NSString identifier;
			var template = GetTemplateForItem(indexPath);

			if (!_templateCells.TryGetValue(template ?? _nullDataTemplateKey, out identifier))
			{
				identifier = new NSString(_templateCache.Count.ToString(CultureInfo.InvariantCulture));
				_templateCells[template ?? _nullDataTemplateKey] = identifier;

				Owner.RegisterClassForCell(typeof(ListViewBaseInternalContainer), identifier);
			}

			return identifier;
		}
	}

	/// <summary>
	/// A hidden root item that allows the reuse of ContentControl features.
	/// </summary>
	internal class ListViewBaseInternalContainer : UICollectionViewCell
	{
		/// <summary>
		/// Native constructor, do not use explicitly.
		/// </summary>
		/// <remarks>
		/// Used by the Xamarin Runtime to materialize native 
		/// objects that may have been collected in the managed world.
		/// </remarks>
		public ListViewBaseInternalContainer(IntPtr handle) : base(handle) { }

		public ListViewBaseInternalContainer()
		{

		}

		private CGSize _lastUsedSize;
		private CGSize? _measuredContentSize;
		private readonly SerialDisposable _contentChangedDisposable = new SerialDisposable();
		private bool _needsLayout = true;
		private bool _interceptSetNeedsLayout = false;

		private WeakReference<NativeListViewBase> _ownerRef;
		public NativeListViewBase Owner
		{
			get { return _ownerRef?.GetTarget(); }
			set
			{
				if (value != _ownerRef?.GetTarget())
				{
					_ownerRef = new WeakReference<NativeListViewBase>(value);
				}
			}
		}

		private Orientation ScrollOrientation => Owner.NativeLayout.ScrollOrientation;
		private bool SupportsDynamicItemSizes => Owner.NativeLayout.SupportsDynamicItemSizes;
		private ILayouter Layouter => Owner.NativeLayout.Layouter;

		protected override void Dispose(bool disposing)
		{
			if (!disposing)
			{
				GC.ReRegisterForFinalize(this);

				Core.CoreDispatcher.Main.RunIdleAsync(_ => Dispose());
			}
			else
			{
				// We need to excplicitly remove the content before being disposed
				// otherwise, the children will try to reference ContentView which 
				// will have been disposed.

				foreach (var v in ContentView.Subviews)
				{
					v.RemoveFromSuperview();
				}

				base.Dispose(disposing);
			}
		}

		public ContentControl Content
		{
			get
			{
				return /* Cache the content ?*/ContentView.Subviews.FirstOrDefault() as ContentControl;
			}
			set
			{
				using (InterceptSetNeedsLayout())
				{
					if (ContentView.Subviews.Any())
					{
						ContentView.Subviews[0].RemoveFromSuperview();
					}

					value.Frame = ContentView.Bounds;
					value.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

					ContentView.AddSubview(value);

					ClearMeasuredSize();
					_contentChangedDisposable.Disposable = value?.RegisterDisposablePropertyChangedCallback(ContentControl.ContentProperty, (_, __) => _measuredContentSize = null);
				}
			}
		}

		public override CGRect Frame
		{
			get => base.Frame;
			set
			{
				base.Frame = value;
				UpdateContentViewFrame();
			}
		}

		public override CGRect Bounds
		{
			get => base.Bounds;
			set
			{
				if (_measuredContentSize.HasValue)
				{
					// At some points, eg during a collection change, iOS seems to apply an outdated size even after we've updated the 
					// LayoutAttributes. Keep the good size.
					SetExtent(ref value, _measuredContentSize.Value);
				}
				base.Bounds = value;
				UpdateContentViewFrame();
			}
		}

		/// <summary>
		/// Set the ContentView's size to match the InternalContainer, this is necessary for touches to buttons inside the template to 
		/// propagate properly.
		/// </summary>
		private void UpdateContentViewFrame()
		{
			if (ContentView != null)
			{
				ContentView.Frame = Bounds;
			}
		}

		/// <summary>
		/// Clear the cell's measured size, this allows the static template size to be updated with the correct databound size.
		/// </summary>
		internal void ClearMeasuredSize() => _measuredContentSize = null;

		public override UICollectionViewLayoutAttributes PreferredLayoutAttributesFittingAttributes(UICollectionViewLayoutAttributes layoutAttributes)
		{
			if (!(((object)layoutAttributes) is UICollectionViewLayoutAttributes))
			{
				// This case happens for a yet unknown GC issue, where the layoutAttribute instance passed the current
				// method maps to another object. The repro steps are not clear, and it may be related to ListView/GridView
				// data reload.
				this.Log().Error("ApplyLayoutAttributes has been called with an invalid instance. See bug #XXX for more details.");
				return null;
			}

			if(Content == null)
			{
				this.Log().Error("Empty ListViewBaseInternalContainer content.");
				return null;
			}

			try
			{
				var size = layoutAttributes.Frame.Size;
				if (_measuredContentSize == null || size != _lastUsedSize)
				{
					_lastUsedSize = size;
					var availableSize = AdjustAvailableSize(layoutAttributes.Frame.Size.ToFoundationSize());
					if (Window != null || Owner.XamlParent.Window == null)
					{
						using (InterceptSetNeedsLayout())
						{
							_measuredContentSize = Layouter.MeasureChild(Content, availableSize);
						}
					}
					else
					{
						try
						{
							//Attach temporarily, because some Uno control (eg ItemsControl) are only measured correctly after MovedToWindow has been called
							InterceptSetNeedsLayout();
							Owner.XamlParent.AddSubview(this);
							_measuredContentSize = Layouter.MeasureChild(Content, availableSize);
						}
						finally
						{
							Owner.XamlParent.RemoveChild(this);
							AllowSetNeedsLayout();
						}
					}
					if (SupportsDynamicItemSizes ||
						layoutAttributes.RepresentedElementKind == NativeListViewBase.ListViewSectionHeaderElementKind ||
						layoutAttributes.RepresentedElementKind == NativeListViewBase.ListViewHeaderElementKind ||
						layoutAttributes.RepresentedElementKind == NativeListViewBase.ListViewFooterElementKind
					)
					{
						//Fetch layout for this item from collection view, since it may have been updated by an earlier item
						var cachedAttributes = layoutAttributes.RepresentedElementKind == null ?
							Owner.NativeLayout.LayoutAttributesForItem(layoutAttributes.IndexPath) :
							Owner.NativeLayout.LayoutAttributesForSupplementaryView((NSString)layoutAttributes.RepresentedElementKind, layoutAttributes.IndexPath);
						// cachedAttributes may be null if we have modified the collection with DeleteItems
						var frame = cachedAttributes?.Frame ?? layoutAttributes.Frame;
						SetExtent(ref frame, _measuredContentSize.Value);
						if (this.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
						{
							this.Log().Debug($"Adjusting layout attributes for item at {layoutAttributes.IndexPath}({layoutAttributes.RepresentedElementKind}), Content={Content?.Content}. Previous frame={layoutAttributes.Frame}, new frame={frame}.");
						}
						var sizesAreDifferent = frame.Size != layoutAttributes.Frame.Size;
						if (sizesAreDifferent)
						{
							Owner.NativeLayout.HasDynamicElementSizes = true;
							this.Frame = frame;
							SetNeedsLayout();

							//If we don't do a lightweight refresh here, in some circumstances (grouping enabled?) the UICollectionView seems 
							//to use stale layoutAttributes for deciding if items should be visible, leading to them popping out of view mid-viewport.
							Owner?.NativeLayout?.RefreshLayout();
						}
						layoutAttributes.Frame = frame;
						if (sizesAreDifferent)
						{
							Owner.NativeLayout.UpdateLayoutAttributesForElement(layoutAttributes);
						}

						if (layoutAttributes.RepresentedElementKind != null)
						{
							//The UICollectionView seems to call PreferredLayoutAttributesFittingAttributes for supplementary views last. Therefore
							//we need to relayout all visible items to make sure item views are offset to account for headers and group headers.
							Owner.NativeLayout.RefreshLayout();
						}
					}
				}
			}
			catch (Exception e)
			{
				this.Log().Error($"Adjusting layout attributes for {layoutAttributes?.IndexPath?.ToString() ?? "[null]"} failed", e);
			}

			if (this.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
			{
				this.Log().Debug($"Returning layout attributes for item at {layoutAttributes.IndexPath}({layoutAttributes.RepresentedElementKind}), Content={Content?.Content}, with frame {layoutAttributes.Frame}");
			}

			if (layoutAttributes.Frame != this.Frame)
			{
				if (this.Log().IsEnabled(LogLevel.Debug))
				{
					this.Log().Debug($"Overwriting Frame: Item={layoutAttributes.IndexPath}: layoutAttributes.Frame={layoutAttributes.Frame}, this.Frame={this.Frame}");
				}
				// For some reason the item's Frame can be left stuck in the wrong value in certain cases where it is changed repeatedly in 
				// response to sequential collection changes.
				Frame = layoutAttributes.Frame;
			}

			return layoutAttributes;
		}

		public void SetSuperviewNeedsLayout()
		{
			if (!_needsLayout && !_interceptSetNeedsLayout)
			{
				_needsLayout = true;
				Owner?.NativeLayout?.RefreshLayout();
				ClearMeasuredSize();
				SetNeedsLayout();
			}
		}

		public override void LayoutSubviews()
		{
			_needsLayout = false;
			var size = Bounds.Size;

			if (Content != null)
			{
				Layouter.ArrangeChild(Content, new Rect(0, 0, (float)size.Width, (float)size.Height));
			}
		}

		/// <summary>
		/// Instruct the <see cref="ListViewBaseInternalContainer"/> not to propagate layout requests to its parent list, eg because the 
		/// item is in the process of being prepared by the list.
		/// </summary>
		internal IDisposable InterceptSetNeedsLayout()
		{
			_interceptSetNeedsLayout = true;
			return Disposable.Create(AllowSetNeedsLayout);
		}

		/// <summary>
		/// Tell the container to resume propagating layout requests.
		/// </summary>
		private void AllowSetNeedsLayout() => _interceptSetNeedsLayout = false;

		/// <summary>
		/// Set available size to be infinite in the scroll direction.
		/// </summary>
		private Size AdjustAvailableSize(Size availableSize)
		{
			if (ScrollOrientation == Orientation.Vertical)
			{
				availableSize.Height = float.MaxValue;
			}
			else
			{
				availableSize.Width = float.MaxValue;
			}
			return availableSize;
		}

		/// <summary>
		/// Set the frame's extent in the direction of scrolling.
		/// </summary>
		private void SetExtent(ref CGRect frame, CGSize targetSize)
		{
			if (ScrollOrientation == Orientation.Vertical)
			{
				frame.Height = targetSize.Height;
			}
			else
			{
				frame.Width = targetSize.Width;
			}
		}
	}

	internal partial class BlockLayout : Border
	{
		public override void SetNeedsLayout()
		{
			//Block
		}
		public override void SetSuperviewNeedsLayout()
		{
			//Block
		}
	}
}
