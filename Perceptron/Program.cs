using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using NeuroDll;

namespace Perceptron
{
	class Program
	{
		static IEnumerable<int> GetWeights(string physicalPath)
		{
			using (var reader = new StreamReader(physicalPath))
			{
				var weights = reader.ReadToEnd()?.Split(' ').Select(wgt => int.Parse(wgt, CultureInfo.InvariantCulture));

				if (weights != null)
				{
					return weights;
				}
				else
				{
					return new List<int>();
				}
			}
		}

		static void Main(string[] args)
		{
			int[,] inputData = new int[3, 5];
			inputData[0, 0] = 1;
			inputData[2, 0] = 1;

			inputData[0, 1] = 1;
			inputData[2, 1] = 1;

			inputData[0, 2] = 1;
			inputData[1, 2] = 1;
			inputData[2, 2] = 1;

			inputData[2, 3] = 1;

			inputData[2, 4] = 1;

			var neuron = new Neuron(inputData);
			var weights = GetWeights("").ToList();
			int counter = default;

			for (var y = 0; y <= neuron.NeuronWeights.GetUpperBound(1); y++)
			{
				for (var x = 0; x <= neuron.NeuronWeights.GetUpperBound(0); x++)
				{
					neuron.NeuronWeights[x, y] = weights[counter];
				}
			}

			while (true)
			{
				neuron.GetWeights();

				var result = neuron.GetResult();
				Console.WriteLine($"Simon says : {result}");
				Console.WriteLine("Check result");

				if (!bool.Parse(Console.ReadLine()))
				{
					Console.WriteLine("Check result one more time");
					var isTrue = bool.Parse(Console.ReadLine());
					neuron.Teach(isTrue);

					for (var y = 0; y <= neuron.NeuronWeights.GetUpperBound(1); y++)
					{
						for (var x = 0; x <= neuron.NeuronWeights.GetUpperBound(0); x++)
						{
							Console.Write($"{neuron.NeuronWeights[x, y]} ");
						}

						Console.WriteLine();
					}
				}
				else
				{
					continue;
				}
			}
		}
	}
}
