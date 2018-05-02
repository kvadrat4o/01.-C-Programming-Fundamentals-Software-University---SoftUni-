/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 5:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace SortNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<double> input = Console.ReadLine().Split(' ').Select(x=>double.Parse(x)).ToList();
			input.Sort();
			Console.WriteLine(String.Join(" <= ",input));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}