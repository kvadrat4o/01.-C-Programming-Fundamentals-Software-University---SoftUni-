/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/22
 * Time: 6:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CubeProperties
{
	class Program
	{
		public static void Main(string[] args)
		{
			double side = double.Parse(Console.ReadLine());
			string prop = Console.ReadLine().ToLower();
			double result = CubeProps(side,prop);
			Console.WriteLine("{0:f2}",result);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static double CubeProps(double side,string prop)
		{
			double result = 0.00;
			switch (prop) {
				case"face":
					result = (Math.Sqrt(2.00)*side);
					return result;
				case"space":
					result = (Math.Sqrt(3.00)*side);
					return result;
				case"area":
					result = 6*side*side; 
					return result;
				case"volume":
					result = side*side*side;
					return result;
				default:
					Console.WriteLine("Default");
					return result;
			}
		}
	}
}