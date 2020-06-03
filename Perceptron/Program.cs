using System;
using System.Collections.Generic;
using System.Linq;
using NeuroDll;

namespace Perceptron
{
	class Program
	{
		public static IEnumerable<Neuron> CreateNeurons(List<int[,]> neuronWeights)
		{
			var result = new List<Neuron>();
			neuronWeights.ForEach(wgh => result.Add(new Neuron(wgh)));

			return result;
		}

		public static void EnterWorkingFlow(Neuron neuron, int neuronNumber)
		{
			while (true)
			{
				Console.WriteLine();
				var bmp = new BMP(@"..\..\EnterData\Number.bmp").GetArray();
				BMP.DisplayArray(bmp);

				while (true)
				{
					Console.WriteLine("Result: " + neuron.GetResult(bmp));

					if (neuron.GetResult(bmp) == false)
					{
						Console.Write("Enter t/f to teach: ");

						if (Console.ReadKey().Key == ConsoleKey.F)
						{
							neuron.Teach(false);
							FileWorker.TrySavetoFile(neuron.NeuronWeights, $@"..\..\Weights\{neuronNumber}.txt");
						}
						else if (Console.ReadKey().Key == ConsoleKey.T)
						{
							continue;
						}
					}
					else
					{
						Console.Write("Enter t/f to teach: ");

						if (Console.ReadKey().Key == ConsoleKey.F)
						{
							neuron.Teach(true);
							FileWorker.TrySavetoFile(neuron.NeuronWeights, $@"..\..\Weights\{neuronNumber}.txt");
						}
						else if (Console.ReadKey().Key == ConsoleKey.T)
						{
							continue;
						}
					}
					Console.WriteLine();
					Console.Write("Quit: ");

					if (Console.ReadKey().Key == ConsoleKey.Q)
					{
						break;
					}
					Console.WriteLine();
				}
				Console.WriteLine();

				Console.Write($"Quit {neuronNumber} teach: ");
				var numberisquit = Console.ReadKey().Key;

				if (numberisquit == ConsoleKey.Q)
				{
					break;
				}
			}
		}

		public static List<int[,]> GetWeightsArray(string path)
		{
			var weightlist = new List<int[,]>();
			for (int i = 0; i < 10; i++)
			{
				var res = new int[15, 25];
				FileWorker.TryGetData($@"{path}\{i}.txt", ref res);
				weightlist.Add(res);
			}
			return weightlist;
		}

		static void Main(string[] args)
		{
			var neurons = new List<Neuron>();
			neurons = CreateNeurons(GetWeightsArray(@"..\..\Weights")).ToList();

			while (true)
			{
				Console.Write("Compare, Teach, Quit: ");
				var pressedkey = Console.ReadKey().Key;

				Console.WriteLine();

				if (pressedkey == ConsoleKey.T)
				{
					Console.Write("Select number: ");
					while (true)
					{
						switch (Console.ReadKey().Key)
						{
							case ConsoleKey.D0:
								EnterWorkingFlow(neurons[0], 0);
								break;

							case ConsoleKey.D1:
								EnterWorkingFlow(neurons[1], 1);
								break;

							case ConsoleKey.D2:
								EnterWorkingFlow(neurons[2], 2);
								break;

							case ConsoleKey.D3:
								EnterWorkingFlow(neurons[3], 3);
								break;

							case ConsoleKey.D4:
								EnterWorkingFlow(neurons[4], 4);
								break;

							case ConsoleKey.D5:
								EnterWorkingFlow(neurons[5], 5);
								break;

							case ConsoleKey.D6:
								EnterWorkingFlow(neurons[6], 6);
								break;

							case ConsoleKey.D7:
								EnterWorkingFlow(neurons[7], 7);
								break;

							case ConsoleKey.D8:
								EnterWorkingFlow(neurons[8], 8);
								break;

							case ConsoleKey.D9:
								EnterWorkingFlow(neurons[9], 9);
								break;
						}
						break;
					}
				}
				else if (pressedkey == ConsoleKey.C)
				{
					while (true)
					{
						var bmp = new BMP(@"..\..\EnterData\Number.bmp").GetArray();
						BMP.DisplayArray(bmp);
						var seleced = 0;
						var weightsum = neurons[0].GetWeightSum(bmp);

						for (int i = 1; i < 10; i++)
						{
							Console.WriteLine(neurons[i].GetWeightSum(bmp));

							if (neurons[i].GetWeightSum(bmp) > weightsum)
							{
								weightsum = neurons[i].GetWeightSum(bmp);
								seleced = i;
							}
						}
						Console.WriteLine("Answer: " + seleced);
						Console.Write("Quit test: ");

						if (Console.ReadKey().Key == ConsoleKey.Q)
						{
							break;
						}
						Console.WriteLine();
					}
					Console.WriteLine();
				}
				else if (pressedkey == ConsoleKey.Q)
				{
					break;
				}

				Console.WriteLine();
			}
		}
	}
}
