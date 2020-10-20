using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.Extensions;
using Uno.UI;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
	/// <summary>
	/// Provides an instance pool for <see cref="Page"/>s. Pooling is enabled when <see cref="Uno.UI.FeatureConfiguration.Page.IsPoolingEnabled"/> is set to true.
	/// </summary>
	/// <remarks>Enabling page pooling improves performance when using <see cref="Frame"/> navigation.</remarks>
	public class PagePool
	{
		private readonly Stopwatch _watch = new Stopwatch();
		private readonly Dictionary<Type, List<PagePoolEntry>> _pooledInstances = new Dictionary<Type, List<PagePoolEntry>>();

		/// <summary>
		/// Determines the duration for which a pooled page stays alive.
		/// </summary>
		public static TimeSpan TimeToLive { get; set; } = TimeSpan.FromMinutes(1);

		/// <summary>
		/// Determines if the pooling is enabled. If false, all requested instances are new.
		/// </summary>
		public static bool IsPoolingEnabled { get; set; } = true;

		internal PagePool()
		{
			_watch.Start();

#if !NET461
			FrameworkElementHelper.PrintLine("PagePool ctor");
			CoreDispatcher.Main.RunIdleAsync(Scavenger);
			FrameworkElementHelper.PrintLine("Scavenger on idle");
#endif
		}

		private async void Scavenger(IdleDispatchedHandlerArgs e)
		{
			FrameworkElementHelper.PrintLine("PagePool Scavenger");

			var now = _watch.Elapsed;
			var removedInstancesCount = 0;
			FrameworkElementHelper.PrintLine("PagePool before foreach");

			foreach (var list in _pooledInstances.Values)
			{
				FrameworkElementHelper.PrintLine("PagePool list " + list.Count);

				removedInstancesCount += list.RemoveAll(t => now - t.CreationTime > TimeToLive);
			}
			FrameworkElementHelper.PrintLine("PagePool after foreach");

			if (removedInstancesCount > 0)
			{
				// Under iOS and Android, we need to force the collection for the GC
				// to pick up the orphan instances that we've just released.
				FrameworkElementHelper.PrintLine("PagePool GC.Collect");

				GC.Collect();
			}

			FrameworkElementHelper.PrintLine("PagePool await Task.Delay");

			await Task.Delay(TimeSpan.FromSeconds(30));

			FrameworkElementHelper.PrintLine("PagePool RunIdleAsync(Scavenger)");
			CoreDispatcher.Main.RunIdleAsync(Scavenger);
			FrameworkElementHelper.PrintLine("PagePool after RunIdleAsync(Scavenger)");

		}

		internal Page DequeuePage(Type pageType)
		{
					Application.PrintLine("DequeuePage Page.IsPoolingEnabled");
			if (!FeatureConfiguration.Page.IsPoolingEnabled)
			{
				Application.PrintLine("DequeuePage CreatePageInstance 1 " + pageType.FullName);
				return Frame.CreatePageInstance(pageType);
			}

				Application.PrintLine("DequeuePage UnoGetValueOrDefault 1");
			var list = _pooledInstances.UnoGetValueOrDefault(pageType);

			if (list == null || list.Count == 0)
			{
				Application.PrintLine("DequeuePage CreatePageInstance 2");
				return Frame.CreatePageInstance(pageType);
			}
			else
			{
				Application.PrintLine("DequeuePage else");

				var position = list.Count - 1;
				var instance = list[position].PageInstance;
				list.RemoveAt(position);
				return instance;
			}
		}

		internal void EnqueuePage(Type pageType, Page pageInstance)
		{
			var list = _pooledInstances.FindOrCreate(pageType, () => new List<PagePoolEntry>());

			FrameworkTemplatePool.PropagateOnTemplateReused(pageInstance);

			list.Add(new PagePoolEntry(_watch.Elapsed, pageInstance));
		}


		private class PagePoolEntry
		{
			public PagePoolEntry(TimeSpan creationTime, Page pageInstance)
			{
				CreationTime = creationTime;
				PageInstance = pageInstance;
			}

			public TimeSpan CreationTime { get; private set; }

			public Page PageInstance { get; private set; }
		}
	}
}
