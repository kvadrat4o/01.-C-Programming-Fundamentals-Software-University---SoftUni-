/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/14
 * Time: 2:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace Grab_Go
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<int> prices = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}