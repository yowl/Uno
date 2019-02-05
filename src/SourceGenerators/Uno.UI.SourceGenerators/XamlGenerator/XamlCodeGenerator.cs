using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Uno.SourceGeneration;

namespace Uno.UI.SourceGenerators.XamlGenerator
{
	public class XamlCodeGenerator : SourceGenerator
	{
		public override void Execute(SourceGeneratorContext context)
		{
			if (PlatformHelper.IsValidPlatform(context))
			{
				var gen = new XamlCodeGeneration(context);
				gen.Generate();
			}
		}
	}
}
