/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/06
 * Time: 11:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace WaterOvertflow
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int n = int.Parse(Console.ReadLine());
			int total = 0;
			int diff = 0;
			int leter = 0;
			int capacity = 255;
			int capacityLeft = capacity;
			for (int i = 0; i < n; i++) 
			{
				leter = int.Parse(Console.ReadLine());
				total+=leter;
				if (capacityLeft-leter>=0) 
				{
					capacityLeft-=leter;
				}
				else 
				{
					Console.WriteLine("Insufficient capacity!");
				}
			}
			
			Console.WriteLine("{0}",capacity - capacityLeft);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}