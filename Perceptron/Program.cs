using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NeuroDll;

namespace Perceptron
{
	class Program
	{
		public List<Neuron> Neurons { get; set; }

		public IEnumerable<Neuron> CreateNeurons(List<int [,]> neuronWeights)
		{
			var result = new List<Neuron>();
			neuronWeights.ForEach(wgh => result.Add(new Neuron(wgh)));

			return result;
		}

		static void Main(string[] args)
		{
			
		}
	}
}
