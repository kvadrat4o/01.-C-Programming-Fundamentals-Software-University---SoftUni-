/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/12
 * Time: 6:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace ShortWordSorted
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			string [] input = Console.ReadLine().ToLower().Split(new char[] {'.',',',':',';','(',')','[',']','"','\'','\\','/','!','?',' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
			PrintLowerAlpha(input);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void PrintLowerAlpha(string[] input)
		{
			List<string> results = input.Where(w => w != "").Where(w => w.Length<5).OrderBy(w => w).Distinct().ToList();
			Console.WriteLine(String.Join(", ", results));
		}
	}
}