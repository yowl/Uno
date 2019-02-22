using Mono.Cecil;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Uno.UI.AssemblyComparer
{
    class Program
	{
		private static readonly PackageSource NuGetOrgSource = new PackageSource("https://api.nuget.org/v3/index.json");

		static async Task<int> Main(string[] args)
        {
			var sourcePath = await GetPackage(args[0]);
			var targetPath = await GetPackage(args[1]);
			var outputFile = args[2];

			try
			{
				var sourcePlatforms = Directory.GetDirectories(Path.Combine(sourcePath, "lib"), "*.*", SearchOption.TopDirectoryOnly);
				var targetPlatforms = Directory.GetDirectories(Path.Combine(targetPath, "lib"), "*.*", SearchOption.TopDirectoryOnly);
				var platformsFiles = from sourceAssemblyPath in sourcePlatforms
									 join targetAssemblyPath in targetPlatforms on Path.GetFileName(sourceAssemblyPath) equals Path.GetFileName(targetAssemblyPath)
									 select new
									 {
										 Platform = Path.GetFileName(sourceAssemblyPath),
										 Source = sourceAssemblyPath,
										 Target = targetAssemblyPath
									 };

				using (var writer = new StreamWriter(outputFile))
				{
					foreach (var platform in platformsFiles)
					{
						writer.WriteLine($"# {platform.Platform} Platform");

						foreach (var sourceFile in Directory.GetFiles(platform.Source, "*.dll"))
						{
							var targetFile = Path.Combine(platform.Target, Path.GetFileName(sourceFile));

							Console.WriteLine($"Comparing {sourceFile} and {targetFile}");

							var source = ReadModule(sourceFile);
							var target = ReadModule(targetFile);

							writer.WriteLine($"## {Path.GetFileName(sourceFile)}");
							CompareTypes(writer, source.MainModule.GetTypes(), target.MainModule.GetTypes());
						}
					}
				}

				Console.WriteLine($"Done comparing.");

				return 0;
			}
			finally
			{
				Directory.Delete(sourcePath, true);
				Directory.Delete(targetPath, true);
			}
		}

		private static async Task<string> GetPackage(string packagePath)
		{
			if(!packagePath.EndsWith(".nupkg", StringComparison.OrdinalIgnoreCase))
			{
				var settings = Settings.LoadDefaultSettings(null);
				var repositoryProvider = new SourceRepositoryProvider(settings, Repository.Provider.GetCoreV3());

				var repository = repositoryProvider.CreateRepository(NuGetOrgSource, FeedType.HttpV3);

				var searchResource = repository.GetResource<PackageSearchResource>();

				var packages = (await searchResource.SearchAsync(packagePath, new SearchFilter(true, SearchFilterType.IsLatestVersion), skip: 0, take: 1000, log: new NullLogger(), cancellationToken: CancellationToken.None)).ToArray();

				if(packages.Any())
				{
					var latestStable = (await packages.First().GetVersionsAsync())
						.OrderByDescending(v => v.Version)
						.Where(v => !v.Version.IsPrerelease)
						.FirstOrDefault();

					if (latestStable != null)
					{
						var url = $"https://api.nuget.org/v3-flatcontainer/{packagePath}/{latestStable.Version}/{packagePath}.{latestStable.Version}.nupkg";

						Console.WriteLine($"Downloading {url}");
						var outFile = Path.GetTempFileName();
						await new WebClient().DownloadFileTaskAsync(new Uri(url), outFile);
						return await UnpackArchive(outFile);
					}
					else
					{
						throw new InvalidOperationException($"Unable to find stable {packagePath} in {NuGetOrgSource.SourceUri}");
					}
				}
				else
				{
					throw new InvalidOperationException($"Unable to find {packagePath} in {NuGetOrgSource.SourceUri}");
				}
			}
			else
			{
				return await UnpackArchive(packagePath);
			}
		}

		private static async Task<string> UnpackArchive(string packagePath)
		{
			var path = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString().Trim('{', '}'));

			Directory.CreateDirectory(path);

			Console.WriteLine($"Extracting {packagePath} -> {path}");
			using (var file = File.OpenRead(packagePath))
			{
				using (var archive = new ZipArchive(file, ZipArchiveMode.Read))
				{
					archive.ExtractToDirectory(path);
				}
			}

			return path;
		}

		private static void CompareTypes(StreamWriter writer, IEnumerable<TypeDefinition> targetTypes, IEnumerable<TypeDefinition> sourceTypes)
		{
			// Types only in target
			var q = from targetType in targetTypes
					where !sourceTypes.Any(t => t.FullName == targetType.FullName)
					where targetType.IsPublic
					group targetType by targetType.Namespace into namespaces
					orderby namespaces.Key
					select new
					{
						Types = namespaces,
						TypesForNamespace = targetTypes
							.Where(t => t.IsPublic)
							.Where(t => t.Namespace == namespaces.Key)
					};

			writer.WriteLine("### {0} missing types:", q.SelectMany(i => i.Types).Count());

			foreach (var newNamespace in q)
			{
				var allTypesCount = newNamespace.TypesForNamespace.Count();
				var existingTypesCount = newNamespace.Types.Count();

				writer.WriteLine($"- `{newNamespace.Types.Key}` ({existingTypesCount} of {allTypesCount})");

				foreach (var type in newNamespace.Types)
				{
					writer.WriteLine("\t* `{0}`", type.FullName);
				}
			}

			var existingTypes = from targetType in targetTypes
								let sourceType = sourceTypes.FirstOrDefault(t => t.FullName == targetType.FullName)
								where sourceType != null
								where targetType.IsPublic
								select (sourceType, targetType);

			FindMissingProperties(writer, existingTypes);
			FindMissingMethods(writer, existingTypes);
			FindMissingFields(writer, existingTypes);
			FindMissingEvents(writer, existingTypes);
		}

		private static void FindMissingMethods(StreamWriter writer, IEnumerable<(TypeDefinition sourceType, TypeDefinition targetType)> existingTypes)
		{
			IEnumerable<string> getMethodParamsSignature(MethodDefinition method)
				=> method.Parameters.Select(p => p.Name + p.ParameterType.FullName);

			var q1 = from type in existingTypes
					 from targetMethod in type.targetType.Methods
					 let targetMethodParams = getMethodParamsSignature(targetMethod)
					 where targetMethod.IsPublic
					 where !type.sourceType.Methods.Any(m => m.Name == targetMethod.Name && targetMethodParams.SequenceEqual(getMethodParamsSignature(m)))
					 group targetMethod by targetMethod.DeclaringType.FullName into types
					 orderby types.Key
					 select types;

			writer.WriteLine("### {0} missing or changed method in existing types:", q1.SelectMany(i => i).Count());

			foreach (var updatedType in q1)
			{
				writer.WriteLine("- `{0}`", updatedType.Key);
				foreach (var method in updatedType)
				{
					writer.WriteLine("\t* ``{0}``", ExpandMethod(method));
				}
			}
		}

		private static string ExpandMethod(MethodDefinition method)
		{
			var parms = string.Join(", ", method.Parameters.Select(p => $"{p.ParameterType} {p.Name}"));
			return $"{method.ReturnType} {method.DeclaringType}.{method.Name}({parms})";
		}

		private static void FindMissingEvents(StreamWriter writer, IEnumerable<(TypeDefinition sourceType, TypeDefinition targetType)> existingTypes)
		{
			var q1 = from type in existingTypes
					 from targetEvent in type.targetType.Events
					 where targetEvent.AddMethod?.IsPublic ?? false
					 where !type.sourceType.Events.Any(p => p.Name == targetEvent.Name && p.EventType.FullName != targetEvent.FullName)
					 group targetEvent by targetEvent.DeclaringType.FullName into types
					 orderby types.Key
					 select types;

			writer.WriteLine("### {0} missing or changed events in existing types:", q1.SelectMany(i => i).Count());

			foreach (var updatedType in q1)
			{
				writer.WriteLine($"- `{updatedType.Key}`");
				foreach (var evt in updatedType)
				{
					writer.WriteLine($"\t* ``{evt}``");
				}
			}
		}

		private static void FindMissingFields(StreamWriter writer, IEnumerable<(TypeDefinition sourceType, TypeDefinition targetType)> existingTypes)
		{
			var q1 = from type in existingTypes
					 from targetField in type.targetType.Fields
					 where targetField.IsPublic
					 where !type.sourceType.Fields.Any(p => p.Name == targetField.Name && p.FieldType.FullName == targetField.FieldType.FullName)
					 group targetField by targetField.DeclaringType.FullName into types
					 orderby types.Key
					 select types;

			writer.WriteLine("### {0} missing or changed fields in existing types:", q1.SelectMany(i => i).Count());

			foreach (var updatedType in q1)
			{
				writer.WriteLine("- `{0}`", updatedType.Key);
				foreach (var field in updatedType)
				{
					writer.WriteLine("\t* ``{0}``", field.DeclaringType.FullName + "." + field.Name);
				}
			}
		}

		private static void FindMissingProperties(StreamWriter writer, IEnumerable<(TypeDefinition sourceType, TypeDefinition targetType)> existingTypes)
		{
			var q1 = from type in existingTypes
					 from targetProp in type.targetType.Properties
					 where targetProp.GetMethod?.IsPublic ?? false
					 where !type.sourceType.Properties.Any(p => p.Name == targetProp.Name && p.PropertyType.FullName == targetProp.PropertyType.FullName)
					 group targetProp by targetProp.DeclaringType.FullName into types
					 orderby types.Key
					 select types;

			writer.WriteLine("### {0} missing or changed properties in existing types:", q1.SelectMany(i => i).Count());

			foreach (var updatedType in q1)
			{
				writer.WriteLine("- `{0}`", updatedType.Key);
				foreach (var property in updatedType)
				{
					writer.WriteLine("\t* ``{0}``", property.DeclaringType.FullName + "." + property.Name);
				}
			}
		}

		private static AssemblyDefinition ReadModule(string path)
        {
            var resolver = new DefaultAssemblyResolver();

            return AssemblyDefinition.ReadAssembly(path, new ReaderParameters() { AssemblyResolver = resolver });
        }
    }
}
