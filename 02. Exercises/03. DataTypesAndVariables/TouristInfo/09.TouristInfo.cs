/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/07
 * Time: 9:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TouristInfo
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			string imperial = Console.ReadLine().ToLower();
			double value = double.Parse(Console.ReadLine());
			double result = 0.00;
			switch (imperial) 
			{
				case "miles":
					result = 1.60*value;
					Console.WriteLine("{0} {1} = {2:f2} kilometers",value,imperial,result);
					break;
				case "inches":
					result = 2.54*value;
					Console.WriteLine("{0} {1} = {2:f2} centimeters",value,imperial,result);
					break;
				case "feet":
					result = 30*value;
					Console.WriteLine("{0} {1} = {2:f2} centimeters",value,imperial,result);
					break;
				case "gallons":
					result = 3.80*value;
					Console.WriteLine("{0} {1} = {2:f2} liters",value,imperial,result);
					break;
				case "yards":
					result = 0.90*value;
					Console.WriteLine("{0} {1} = {2:f2} meters",value,imperial,result);
					break;
				default:
					Console.WriteLine("Default");
					break;
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}