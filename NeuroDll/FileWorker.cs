using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;

namespace NeuroDll
{
	public class FileWorker
	{
		public static bool TrySavetoFile<T>(T [,] data, string path) where T: struct
		{
			try
			{
				using (var writer = new StreamWriter(path))
				{
					for (var y = 0; y <= data.GetUpperBound(1); y++)
					{
						for (var x = 0; x <= data.GetUpperBound(0); x++)
						{
							if(x == data.GetUpperBound(0))
							{
								writer.Write($"{data[x, y]}");

								continue;
							}

							writer.Write($"{data[x, y]} ");
						}

						writer.WriteLine();
					}
				}

				return true;
			}
			catch
			{
				return false;
			}
		}

		public static bool TryGetData<T>(string path, ref T [,] inputData) where T: struct
		{
			try
			{
				string line = default;
				int counter = default;

				using (var reader = new StreamReader(path))
				{
					while(!string.IsNullOrEmpty(line = reader.ReadLine()))
					{
						var dataLine = line.Split(' ').Select(elm => (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(elm)).ToArray();

						for(int i = default; i < dataLine.Count(); i++)
						{
							inputData[counter, i] = dataLine[i];
						}

						counter++;
					}
				}

				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
