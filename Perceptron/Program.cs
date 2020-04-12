using System;
using NeuroDll;

namespace Perceptron
{
	class Program
	{
		static void Main(string[] args)
		{
			var bitmap = new BMP(@"C:\Users\Timur\Desktop\Bitmap.bmp");//путь здесь
			var inputData = bitmap.GetArray();
			bitmap.DisplayArray(inputData); //вывод массива(можно убрать)
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
