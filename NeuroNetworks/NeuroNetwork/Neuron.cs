using System;
using System.Collections.Generic;
using System.Text;

namespace NeuroNetwork
{
	public class Neuron
	{
		public List<double> Weights { get; set; }
		public NeuronTypeEnum NeuronType { get;  }
		public double Output { get; private set; }

		public Neuron(int inputCount, NeuronTypeEnum neuronType = NeuronTypeEnum.Normal)
		{
			NeuronType = neuronType;

			Weights = new List<double>();

			for (int i = 0; i < inputCount; i++)
			{
				Weights.Add(1);
			}
		}

		public double FeedForward (List<double> inputs)
		{
			var sum = 0.0;
			for (int i = 0; i < inputs.Count; i++)
			{
				sum += inputs[i] * Weights[i];
			}

			Output = Sigmoid(sum);
			return Output;
		}

		private double Sigmoid (double x)
		{
			return 1.0 / (1.0 + Math.Pow(Math.E, -x));
		}

		public override string ToString()
		{
			return Output.ToString();
		}
	}
}
