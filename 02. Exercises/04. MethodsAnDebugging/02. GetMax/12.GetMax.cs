/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/19
 * Time: 3:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GetMax
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			double one = double.Parse(Console.ReadLine());
			double two = double.Parse(Console.ReadLine());
			double three = double.Parse(Console.ReadLine());
			Console.WriteLine(Math.Max(GetMax(one,two),three));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static double GetMax(double a, double b)
		{
			
			return Math.Max(a,b); 
			
		}
	}
}