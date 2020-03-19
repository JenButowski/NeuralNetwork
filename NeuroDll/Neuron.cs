namespace NeuroDll
{
	public class Neuron
	{
		const int _maxSumm = 10;

		public int[,] NeuronWeights { get; set; }

		public int[,] MultiplyWeights { get; set; }

		public int[,] InputData { get; set; }

		public int WightsSumm { get; set; }

		public Neuron(int[,] imputData)
		{
			var width = imputData.GetUpperBound(0) + 1;
			var hight = imputData.GetUpperBound(1) + 1;

			NeuronWeights = new int[width, hight];

			MultiplyWeights = new int[width, hight];

			InputData = imputData;
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

		public void GetWeights()
		{
			for (var y = 0; y <= InputData.GetUpperBound(1); y++)
			{
				for (var x = 0; x <= InputData.GetUpperBound(0); x++)
				{
					MultiplyWeights[x, y] = InputData[x, y] * NeuronWeights[x, y];
				}
			}
		}

		public bool GetResult()
		{
			foreach (var weight in MultiplyWeights)
			{
				WightsSumm += weight;
			}

			if (WightsSumm >= _maxSumm)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
