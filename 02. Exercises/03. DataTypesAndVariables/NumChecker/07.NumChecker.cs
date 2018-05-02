/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/06
 * Time: 10:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NumChecker
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int input = 0;
			//double doubleInoput = 0.00;
			if (int.TryParse(Console.ReadLine(), out input))
			{
				Console.WriteLine("integer");
			}
			else
			{
				Console.WriteLine("floating-point");
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}