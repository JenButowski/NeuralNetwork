using System;

namespace NeuroDll
{
	public class Neuron
	{
		const int _maxSum = 10;

		public int[,] NeuronWeights { get; set; }

		public int[,] InputData { get; set; }

		public int WeightSum { get; set; }

		public Neuron(int[,] neuronWeights)
		{
			var width = neuronWeights.GetUpperBound(0) + 1;
			var hight = neuronWeights.GetUpperBound(1) + 1;

			NeuronWeights = neuronWeights;
			InputData = new int[width, hight];
		}

		public void Teach(bool result)
		{
			if (result == false)
			{
				for (var y = 0; y <= NeuronWeights.GetUpperBound(1); y++)
				{
					for (var x = 0; x <= NeuronWeights.GetUpperBound(0); x++)
					{
						NeuronWeights[x, y] += InputData[x, y];
					}
				}
			}
			else
			{
				for (var y = 0; y <= NeuronWeights.GetUpperBound(1); y++)
				{
					for (var x = 0; x <= NeuronWeights.GetUpperBound(0); x++)
					{
						NeuronWeights[x, y] -= InputData[x, y];
					}
				}
			}
		}

		private int [,] GetWeights()
		{
			var result = new int [InputData.GetUpperBound(0), InputData.GetUpperBound(1)];

			for (var y = 0; y <= InputData.GetUpperBound(1); y++)
			{
				for (var x = 0; x <= InputData.GetUpperBound(0); x++)
				{
					result[x, y] = InputData[x, y] * NeuronWeights[x, y];
				}
			}

			return result;
		}

		public bool GetResult()
		{
			var multipleWeights = GetWeights();
			var summ = default(int);

			foreach (var weight in multipleWeights)
			{
				summ += weight;
			}

			if (summ < _maxSum)
			{
				return false;
			}

			return true;
		}
	}
}
