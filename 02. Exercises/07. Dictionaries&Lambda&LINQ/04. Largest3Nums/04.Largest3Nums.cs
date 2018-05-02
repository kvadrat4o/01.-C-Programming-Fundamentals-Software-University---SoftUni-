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


namespace largest3Nums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<int>input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
			GetLargest3(input);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void GetLargest3(List<int> input)
		{
			List<int> results = new List<int>();
			results = input.OrderByDescending(x => x).Take(3).ToList();
			Console.WriteLine(String.Join(", ",results));
			
		}
	}
}