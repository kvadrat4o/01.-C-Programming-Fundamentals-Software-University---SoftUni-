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

namespace FoldAndSum
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int k = input.Length / 4;
			int[] row1Left = input.Take(k).Reverse().ToArray();
			int[] row1Right = input.Reverse().Take(k).ToArray();
			int[] rowOne = row1Left.Concat(row1Right).ToArray();
			int[] rowTwo = input.Skip(k).Take(2 * k).ToArray();
			var results =
			  rowOne.Select((x, index) => x + rowTwo[index]);
			Console.WriteLine(string.Join(" ", results));

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}