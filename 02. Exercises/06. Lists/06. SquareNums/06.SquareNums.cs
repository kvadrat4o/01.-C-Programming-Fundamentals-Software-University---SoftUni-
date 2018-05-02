/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 5:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace SquareNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<int> input = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToList();
			List<int> squares = new List<int>();
			
			foreach (var square in input) 
			{
				if (Math.Sqrt(square) ==(int)Math.Sqrt(square)) 
				{
					squares.Add(square);
				}
			}
			squares.Sort((a,b) => b.CompareTo(a));
			Console.WriteLine(String.Join(" ",squares));
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}