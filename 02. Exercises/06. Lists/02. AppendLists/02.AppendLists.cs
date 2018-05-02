/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 4:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendLists
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<string> input  = Console.ReadLine().Split('|').ToList();
			input.Reverse();
			List <string> result = new List<string>();
			foreach (var inp in input) 
			{
				List<string> nums = inp.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).ToList();
				result.AddRange(nums);
			}
			Console.WriteLine(string.Join(" ",result));
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}