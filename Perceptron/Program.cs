using System;
using System.Collections;
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
			neurons = CreateNeurons(GetWeightsArray(@"D:\Code\Jen\WEIGHTS")).ToList();
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
								while (true)
								{
									Console.WriteLine();
									///
									var neuron = neurons[0];
									var bmp = new BMP(@"D:\Code\Jen\NUMBERS\TEST\test.bmp").GetArray();
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\0.txt");
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\0.txt");
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
									/// 
									Console.Write("Quit 0 teach: ");
									var numberisquit = Console.ReadKey().Key;
									if (numberisquit == ConsoleKey.Q)
									{
										break;
									}
								}
								break;

							case ConsoleKey.D1:
								while (true)
								{
									Console.WriteLine();
									///
									var neuron = neurons[1];
									var bmp = new BMP(@"D:\Code\Jen\NUMBERS\TEST\test.bmp").GetArray();
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\1.txt");
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\1.txt");
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
									/// 
									Console.Write("Quit 1 teach: ");
									var numberisquit = Console.ReadKey().Key;
									if (numberisquit == ConsoleKey.Q)
									{
										break;
									}
								}
								break;

							case ConsoleKey.D2:
								while (true)
								{
									Console.WriteLine();
									///
									var neuron = neurons[2];
									var bmp = new BMP(@"D:\Code\Jen\NUMBERS\TEST\test.bmp").GetArray();
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\2.txt");
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\2.txt");
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
									/// 
									Console.Write("Quit 2 teach: ");
									var numberisquit = Console.ReadKey().Key;
									if (numberisquit == ConsoleKey.Q)
									{
										break;
									}
								}
								break;

							case ConsoleKey.D3:
								while (true)
								{
									Console.WriteLine();
									///
									var neuron = neurons[3];
									var bmp = new BMP(@"D:\Code\Jen\NUMBERS\TEST\test.bmp").GetArray();
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\3.txt");
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\3.txt");
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
									/// 
									Console.Write("Quit 3 teach: ");
									var numberisquit = Console.ReadKey().Key;
									if (numberisquit == ConsoleKey.Q)
									{
										break;
									}
								}
								break;

							case ConsoleKey.D4:
								while (true)
								{
									Console.WriteLine();
									///
									var neuron = neurons[4];
									var bmp = new BMP(@"D:\Code\Jen\NUMBERS\TEST\test.bmp").GetArray();
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\4.txt");
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\4.txt");
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
									/// 
									Console.Write("Quit 4 teach: ");
									var numberisquit = Console.ReadKey().Key;
									if (numberisquit == ConsoleKey.Q)
									{
										break;
									}
								}
								break;

							case ConsoleKey.D5:
								while (true)
								{
									Console.WriteLine();
									///
									var neuron = neurons[5];
									var bmp = new BMP(@"D:\Code\Jen\NUMBERS\TEST\test.bmp").GetArray();
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\5.txt");
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\5.txt");
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
									/// 
									Console.Write("Quit 5 teach: ");
									var numberisquit = Console.ReadKey().Key;
									if (numberisquit == ConsoleKey.Q)
									{
										break;
									}
								}
								break;

							case ConsoleKey.D6:
								while (true)
								{
									Console.WriteLine();
									///
									var neuron = neurons[6];
									var bmp = new BMP(@"D:\Code\Jen\NUMBERS\TEST\test.bmp").GetArray();
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\6.txt");
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\6.txt");
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
									/// 
									Console.Write("Quit 6 teach: ");
									var numberisquit = Console.ReadKey().Key;
									if (numberisquit == ConsoleKey.Q)
									{
										break;
									}
								}
								break;

							case ConsoleKey.D7:
								while (true)
								{
									Console.WriteLine();
									///
									var neuron = neurons[7];
									var bmp = new BMP(@"D:\Code\Jen\NUMBERS\TEST\test.bmp").GetArray();
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\7.txt");
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\7.txt");
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
									/// 
									Console.Write("Quit 7 teach: ");
									var numberisquit = Console.ReadKey().Key;
									if (numberisquit == ConsoleKey.Q)
									{
										break;
									}
								}
								break;

							case ConsoleKey.D8:
								while (true)
								{
									Console.WriteLine();
									///
									var neuron = neurons[8];
									var bmp = new BMP(@"D:\Code\Jen\NUMBERS\TEST\test.bmp").GetArray();
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\8.txt");
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\8.txt");
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
									/// 
									Console.Write("Quit 8 teach: ");
									var numberisquit = Console.ReadKey().Key;
									if (numberisquit == ConsoleKey.Q)
									{
										break;
									}
								}
								break;

							case ConsoleKey.D9:
								while (true)
								{
									Console.WriteLine();
									///
									var neuron = neurons[9];
									var bmp = new BMP(@"D:\Code\Jen\NUMBERS\TEST\test.bmp").GetArray();
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\9.txt");
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
												FileWorker.TrySavetoFile(neuron.NeuronWeights, @"D:\Code\Jen\WEIGHTS\9.txt");
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
									/// 
									Console.Write("Quit 9 teach: ");
									var numberisquit = Console.ReadKey().Key;
									if (numberisquit == ConsoleKey.Q)
									{
										break;
									}
								}
								break;
						}
						break;
					}
				}
				else if (pressedkey == ConsoleKey.C)
				{
					while (true)
					{
						var bmp = new BMP(@"D:\Code\Jen\NUMBERS\TEST\test.bmp").GetArray();
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
