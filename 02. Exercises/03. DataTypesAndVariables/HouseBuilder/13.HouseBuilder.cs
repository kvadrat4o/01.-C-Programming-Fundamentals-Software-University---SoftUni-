/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 10:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HouseBuilder
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			long material1 = long.Parse(Console.ReadLine());
			long material2 = long.Parse(Console.ReadLine());
			Console.WriteLine(Math.Max(material1,material2)*10+Math.Min(material1,material2)*4);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}