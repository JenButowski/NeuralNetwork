using System;
using NeuroDll;

namespace Perceptron
{
	class Program
	{
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
			var weights = neuron.NeuronWeights;
			FileWorker.TryGetData(@"C:\Users\Jen\Desktop\weights.txt", ref weights);
			neuron.NeuronWeights = weights;

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
					FileWorker.TrySavetoFile(neuron.NeuronWeights, @"C:\Users\Jen\Desktop\weights.txt");
				}
				else
				{
					continue;
				}
			}
		}
	}
}
