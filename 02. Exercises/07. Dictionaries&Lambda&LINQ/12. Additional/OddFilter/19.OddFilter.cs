/*
 * Created by SharpDevelop.
 * User: Dido
 * Date: 6/15/2017
 * Time: 9:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace OddFilter
{
	class OddFilter
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
			var removed = input.Where(x => x % 2 == 0).ToList();
			var avg = removed.Average();
			for (int i = 0; i < removed.Count; i++) 
			{
				if (removed[i] > avg) 
				{
					removed[i] += 1;
				}
				else if (removed[i] <= avg) 
				{
					removed[i] -= 1;
				}
			}
			Console.WriteLine(string.Join(" ",removed));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}