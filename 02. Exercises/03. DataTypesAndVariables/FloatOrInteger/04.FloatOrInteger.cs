/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/11
 * Time: 12:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FloatOrInteger
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter num: ");
			double num = double.Parse(Console.ReadLine());
			// TODO: Implement Functionality Here
			Console.WriteLine(Math.Round(num));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}