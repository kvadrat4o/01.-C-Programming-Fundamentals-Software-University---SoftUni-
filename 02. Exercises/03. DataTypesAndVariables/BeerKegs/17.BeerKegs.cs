/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 11:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BeerKegs
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int n = int.Parse(Console.ReadLine());
			double maxVolume = 0.00;
			string currModel = null;
			float pi = (float)Math.PI;
			for (int i = 0; i < n; i++) 
			{
				string model = Console.ReadLine();
				double radius = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());
				double volume = pi*radius*radius*height;
				if (volume>maxVolume) 
				{
					maxVolume = volume;
					currModel = model;
				}
			}
			Console.WriteLine(currModel);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}