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


namespace OddOccurences
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<string> input = Console.ReadLine().ToLower().Split(' ').ToList();
			GetOddOccurences(input);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void GetOddOccurences (List<string> input)
		{
			Dictionary<string,int> occurences = new Dictionary<string, int>();
			foreach (var inp in input) 
			{
				if (occurences.ContainsKey(inp))
				{
					occurences[inp]++;
				}
				else 
				{
					occurences[inp] = 1;
				}
			}
			List<string> results = new List<string>();
			foreach (var occur in occurences) 
			{
				if (occur.Value % 2 == 1) 
				{
					results.Add(occur.Key);
				}
			}
			Console.WriteLine(String.Join(", ",results));
		}
	}
}