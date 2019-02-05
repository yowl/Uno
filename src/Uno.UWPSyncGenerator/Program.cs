using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace Uno.UWPSyncGenerator
{
	class Program
	{
		const string SyncMode = "sync";
		const string DocMode = "doc";
		const string AllMode = "all";

		static async Task Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("No mode selected.");
				return;
			}

			var mode = args[0].ToLowerInvariant();
			var tasks = new List<Task>();

			if (mode == SyncMode || mode == AllMode)
			{
				Console.WriteLine("*** WARNING: Close all editor files in visual studio, otherwise VS will freeze for a few minutes ****");
				Console.WriteLine("Press any key to continue...");
				Console.ReadLine();

				tasks.Add(new SyncGenerator().Build(@"..\..\..\..\Uno.Foundation", "Uno.Foundation", "Windows.Foundation.FoundationContract"));
				tasks.Add(new SyncGenerator().Build(@"..\..\..\..\Uno.UWP", "Uno", "Windows.Foundation.UniversalApiContract"));
				tasks.Add(new SyncGenerator().Build(@"..\..\..\..\Uno.UWP", "Uno", "Windows.Phone.PhoneContract"));
				tasks.Add(new SyncGenerator().Build(@"..\..\..\..\Uno.UI", "Uno.UI", "Windows.Foundation.UniversalApiContract"));
			}

			if (mode == DocMode || mode == AllMode)
			{
				tasks.Add(new DocGenerator().Build(@"..\..\..\..\Uno.UI", "Uno.UI", "Windows.Foundation.UniversalApiContract"));
			}

			await Task.WhenAll(tasks);
		}
	}
}
