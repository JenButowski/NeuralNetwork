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
					var pixelcolor = image.GetPixel(i, j).Name;
					if (pixelcolor == "ff000000" || pixelcolor == "fe000000" || pixelcolor == "fd000000" || pixelcolor == "fc000000" || pixelcolor == "fb000000" || pixelcolor == "fa000000")
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
		public static void DisplayArray(int[,] array)
		{
			for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
			{
				for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
				{
					Console.Write(array[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
