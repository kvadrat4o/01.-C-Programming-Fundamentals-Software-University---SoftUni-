/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/18
 * Time: 11:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MathPowers
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			double n = double.Parse(Console.ReadLine());
			double power = double.Parse(Console.ReadLine());
			double result = GetPower(n,power);
			Console.WriteLine(result);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static double GetPower(double n,double power)
		{
			return Math.Pow(n,power);
		}
	}
}