/*
 * Created by SharpDevelop.
 * User: Dido
 * Date: 6/15/2017
 * Time: 8:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace SortTimes
{
	class SortTimes
		
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			var timeTable = Console.ReadLine().Split(' ').ToList();
			var sorted = timeTable.OrderBy(x => x);
			Console.WriteLine(String.Join(", ",sorted));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}