/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/12
 * Time: 6:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace SumMinMaxAvg
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int n = int.Parse(Console.ReadLine());
			ListStats(n);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void ListStats(int n)
		{
			int[] input = new int[n];
			for (int i = 0; i < n; i++) 
			{
				input[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Sum = {0}\nMin = {1}\nMax = {2}\nAverage = {3}",input.Sum(),input.Min(),input.Max(),input.Average());
		}
	}
}