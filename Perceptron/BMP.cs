using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
	class BMP
	{
		public Bitmap image { get; set; }
		public BMP(string path)
		{
			image = new Bitmap(Image.FromFile(path));
		}
		public int[,] GetArray()
		{
			var array = new int[image.Width, image.Height];
			for (int j = 0; j < image.Height; j++)
			{
				for (int i = 0; i < image.Width; i++)
				{
					if (image.GetPixel(i, j).Name == "ff000000")
					{
						array[i, j] = 1;
					}
					else
					{
						array[i, j] = 0;
					}
				}
			}
			return array;
		}
		public void DisplayArray(int[,] array)
		{
			for (int j = 0; j < image.Height; j++)
			{
				for (int i = 0; i < image.Width; i++)
				{
					Console.Write(array[i, j]);
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
