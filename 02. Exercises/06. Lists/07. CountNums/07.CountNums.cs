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


namespace CountNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<int> input = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToList();
			
			int[] counts = new int[1001];
			foreach (var num in input) 
			{
				counts[num]++;
			}
			for (int i = 0; i < counts.Length; i++) 
			{
				if (counts[i]>0) 
				{
					Console.WriteLine("{0} -> {1}",i,counts[i]);	
				}
				
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}