/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/12
 * Time: 11:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace CountRealNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<double> input = Console.ReadLine().Split(' ').Select(x=>double.Parse(x)).ToList();
			CountNums(input);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void CountNums(List<double> input)
		{
			SortedDictionary<double,int> counts = new SortedDictionary<double, int>();
			foreach (var inp in input) 
			{
				if (counts.ContainsKey(inp))
				{
					counts[inp]++;
				}
				else 
				{
					counts[inp] = 1;
				}
			}
			foreach (var num in counts.Keys) 
			{
				Console.WriteLine("{0} -> {1} times",num, counts[num]);
			}
		}
	}
}