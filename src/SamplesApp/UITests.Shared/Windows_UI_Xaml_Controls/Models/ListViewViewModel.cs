﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Uno;
using Uno.Extensions;
using Uno.Logging;
using Uno.UI.Samples.UITests.Helpers;

namespace SamplesApp.Windows_UI_Xaml_Controls.Models
{
	[Bindable]
	public class ListViewViewModel : ViewModelBase
	{
		private static readonly object[] RandomValues = new object[] { null, new object(), 0, -1, 0, 0.5, 1, "", " ", "test", 'a', ' ', new string[] { "A", "B", "C" }, DateTime.Now };
		private object[] _randomItems = new object[0];
		private string _newInput = "1,1,2,2,3,3";
		private List<string> _sampleItemsGenerated = new List<string> { "1", "1", "2", "2", "3", "3" };
		private double _variableWidth = 500d;
		private string _selectedItem = "3";

		public ListViewViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
			RefreshRandomItems = CreateCommand(ExecuteRefreshRandomItems);
			DoSomething = CreateCommand(ExecuteDoSomething);
			VaryWidth = CreateCommand(ExecuteVaryWidth);
			UpdateWithNewInput = CreateCommand(ExecuteOnUpdateWithNewInput);

			VariableLengthItemsLong = CreateVariableLengthItemsLong().ToArray();
			VariableLengthItemsLongLazy = CreateVariableLengthItemsLong();
			EmptyItemsLong = Enumerable.Range(0, 1000).Select(_ => "").ToArray();
		}

		public ICommand RefreshRandomItems { get; }
		public ICommand DoSomething { get; }

		public ICommand VaryWidth { get; }

		public ICommand UpdateWithNewInput { get; }

		public Orientation SelectedOrientation => Orientation.Horizontal;

		public string[] SampleItems => GetSampleItems();
		public string Header => "My Header";
		public string Footer => "My Footer";

		public IEnumerable<object> VariableLengthGroupHeaders => GetAsCollectionViewSource(GetGroupsWithVariableLengthKeys());

		public IEnumerable<object> GroupedCompoundSampleItems => GetAsCollectionViewSource(GetGroupedCompoundItems());

		public NumberViewModel[] CompoundSampleItems => GetCompoundItems();

		public string[] SampleItemsDuplicates => GetSampleItemsWithDuplicates();

		public string SelectedItem
		{
			get => _selectedItem;
			set
			{
				_selectedItem = value;
				RaisePropertyChanged();
			}
		}

		private void ExecuteRefreshRandomItems()
		{
			var randomItems = RandomValues
				.OrderBy(x => Guid.NewGuid()) // shuffle
				.Take(10)
				.ToArray();

			RandomItems = randomItems;
		}

		public object[] RandomItems
		{
			get => _randomItems;
			private set
			{
				_randomItems = value;
				RaisePropertyChanged();
			}
		}

		public string NewInput
		{
			get => _newInput;
			private set
			{
				_newInput = value;
				RaisePropertyChanged();
			}
		}

		public List<string> SampleItemsGenerated
		{
			get => _sampleItemsGenerated;
			private set
			{
				_sampleItemsGenerated = value;
				RaisePropertyChanged();
			}
		}

		private void ExecuteOnUpdateWithNewInput()
		{
			SampleItemsGenerated = NewInput.Split(new char[] {','}).ToList();
		}

		private void ExecuteDoSomething()
		{
			this.Log().Error("============= Item Clicked");
		}

		private static string[] GetSampleItems()
		{
			return Enumerable
				.Range(1, 10)
				.Select(i => i.ToString(CultureInfo.InvariantCulture))
				.ToArray();
		}

		private string[] GetSampleItemsWithDuplicates()
		{
			return Enumerable
				.Range(1, 10)
				.SelectMany(i => new string[] { i.ToString(CultureInfo.InvariantCulture), i.ToString(CultureInfo.InvariantCulture) })
				.ToArray();
		}

		public double VariableWidth
		{
			get => _variableWidth;
			set
			{
				_variableWidth = value;
				RaisePropertyChanged();
			}
		}

		private void ExecuteVaryWidth()
		{
			var newWidth = (new Random()).NextDouble() * 100d + 300d;
			this.Log().Warn($"Changing {nameof(VariableWidth)} to {newWidth}");
			VariableWidth =  newWidth;
		}

		private static IEnumerable<IGrouping<string, string>> GetGroupsWithVariableLengthKeys()
		{
			return _variableLengthItems
				.Select(s =>
					new Grouping<string, string>(s, s.Select(c => c.ToString())
				)
			);
		}

		private static IEnumerable<object> GetAsCollectionViewSource<T1, T2>(IEnumerable<IGrouping<T1, T2>> groups)
		{
			var source = new CollectionViewSource()
			{
				Source = groups,
				IsSourceGrouped = true
			}.View;

			return source;
		}

		public string[] VariableLengthItems => _variableLengthItems;

		private static string[] _variableLengthItems { get; } =
		{
			"Does the first item matter, or the non-databound template?",
			"Alas, poor Yorick!",
			"I knew him, Horatio: a fellow of infinite jest, of most excellent fancy:",
			"he hath borne me on his back a thousand times;",
			"and now, how abhorred in my imagination it is!",
			"my gorge rims at it.",
			"Here hung those lips that I have kissed I know not how oft.",
			"Where be your gibes now?",
			"your gambols?",
			"your songs?",
			"your flashes of merriment, that were wont to set the table on a roar?",
			"Not one now, to mock your own grinning?",
			"quite chap-fallen?",
			"Now get you to my lady's chamber, and tell her, let her paint an inch thick, to this favour she must come;",
			"make her laugh at that.",
			"Prithee, Horatio, tell me one thing.",
		};

		public string[] VariableLengthItemsLong { get; }
		public IEnumerable<string> VariableLengthItemsLongLazy { get; }
		private IEnumerable<string> CreateVariableLengthItemsLong()
		{
			var sb = new StringBuilder();
			const int items = 2000;
			for (int i = 0; i < items; i++)
			{
				sb.Clear();
				const int maxWords = 40;
				int wordCount = i % maxWords;
				if (wordCount > 0)
				{
					sb.Append(i + 1);
					sb.Append(". ");
				}
				for (int j = 0; j < wordCount; j++)
				{
					sb.Append(wordCount);
					sb.Append(" ");
				}
				yield return sb.ToString();
			}
		}

		public string[] EmptyItemsLong { get; }

		public Orientation[] Orientations { get; } =
		{
			Orientation.Horizontal,
			Orientation.Vertical
		};

		public int[] SampleItemsLong { get; } = Enumerable.Range(1, 2000).Select(i => i * 10000).ToArray();

		public double[] WidthChoices { get; } = Enumerable.Range(1, 5).Select(i => i * 100d).ToArray();

		public Color[] SampleColors { get; } = CreateColorSeries();

		private static Color[] CreateColorSeries()
		{
			const byte increments = 12;
			var colors = new List<Color>();
			var delta = byte.MaxValue / increments;
			for (byte b = 0; b < increments; b++)
			{
				for (byte g = 0; g < increments; g++)
				{
					for (byte r = 0; r < increments; r++)
					{
						var color = Color.FromArgb(byte.MaxValue, (byte)(r * delta), (byte)(g * delta), (byte)(b * delta));
						colors.Add(color);
					}
				}
			}
			return colors.ToArray();
		}

		private static NumberViewModel[] GetCompoundItems()
		{
			var random = new Random(2012);

			return Enumerable.Range(0, 30).Select(_ => new NumberViewModel(random.Next(1, 6))).ToArray();
		}

		private static IEnumerable<IGrouping<int, NumberViewModel>> GetGroupedCompoundItems()
		{
			var random = new Random(1778);
			int group = 0;
			return GetCompoundItems().GroupBy(
					_ => group = random.Next(4),
						nvm =>
						{
							nvm.Group = group;
							return nvm;
						}
					).ToArray();
		}

		public string LargeText1 { get; } = "When the child of morning rosy-fingered Dawn appeared, Ulysses put on his shirt and cloak, while the goddess wore a dress of a light gossamer fabric, very fine and graceful, with a beautiful golden girdle about her waist and a veil to cover her head. She at once set herself to think how she could speed Ulysses on his way. So she gave him a great bronze axe that suited his hands; it was sharpened on both sides, and had a beautiful olive-wood handle fitted firmly on to it. She also gave him a sharp adze, and then led the way to the far end of the island where the largest trees grew—alder, poplar and pine, that reached the sky—very dry and well seasoned, so as to sail light for him in the water. 53 Then, when she had shown him where the best trees grew, Calypso went home, leaving him to cut them, which he soon finished doing. He cut down twenty trees in all and adzed them smooth, squaring them by rule in good workmanlike fashion. Meanwhile Calypso came back with some augers, so he bored holes with them and fitted the timbers together with bolts and rivets. He made the raft as broad as a skilled shipwright makes the beam of a large vessel, and he fixed a deck on top of the ribs, and ran a gunwale all round it. He also made a mast with a yard arm, and a rudder to steer with. He fenced the raft all round with wicker hurdles as a protection against the waves, and then he threw on a quantity of wood. By and by Calypso brought him some linen to make the sails, and he made these too, excellently, making them fast with braces and sheets. Last of all, with the help of levers, he drew the raft down into the water.";
		public string LargeText2 { get; } = "In four days he had completed the whole work, and on the fifth Calypso sent him from the island after washing him and giving him some clean clothes. She gave him a goat skin full of black wine, and another larger one of water; she also gave him a wallet full of provisions, and found him in much good meat. Moreover, she made the wind fair and warm for him, and gladly did Ulysses spread his sail before it, while he sat and guided the raft skilfully by means of the rudder. He never closed his eyes, but kept them fixed on the Pleiads, on late-setting Bootes, and on the Bear—which men also call the wain, and which turns round and round where it is, facing Orion, and alone never dipping into the stream of Oceanus—for Calypso had told him to keep this to his left. Days seven and ten did he sail over the sea, and on the eighteenth the dim outlines of the mountains on the nearest part of the Phaeacian coast appeared, rising like a shield on the horizon.";

		public class NumberViewModel
		{
			public string Quote { get; private set; }
			public int[] Items { get; private set; }
			public int Group { get; set; }

			public NumberViewModel(int number)
			{
				Quote = GetNumberQuote(number);
				Items = Enumerable.Range(0, number).ToArray();
			}
		}

		private static string GetNumberQuote(int n)
		{
			switch (n)
			{
				case 1:
					return "It's very easy to be number one: find the guy who is number one, and score one point higher than he does.";
				case 2:
					return "No man can serve two masters.";
				case 3:
					return "In three words I can sum up everything I've learned about life: it goes on.";
				case 4:
					return "When angry, count to four; when very angry, swear.";
				case 5:
					return "It takes 20 years to build a reputation and five minutes to ruin it. If you think about that, you'll do things differently.";
			}

			return "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.";
		}
	}
}
