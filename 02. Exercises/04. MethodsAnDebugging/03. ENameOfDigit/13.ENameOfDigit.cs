/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/19
 * Time: 4:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ENameOfDigit
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			string n = Console.ReadLine();
			Console.WriteLine(GetLastDigitName(n));
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static string  GetLastDigitName(string n)
		{
			
			long number  = Math.Abs(long.Parse(n));
			long symbol  = number%10;
			switch (symbol) {
				case 0: 
					return "zero";
                case 1: 
					return "one";
                case 2:
					return "two";
                case 3: 
					return "three";
                case 4: 
					return "four";
                case 5: 
					return "five";
                case 6: 
					return "six";
                case 7: 
					return "seven";
                case 8: 
					return "eight";
                case 9: 
					return "nine";
                default: 
					return "Wrong input";
			}
		}
	}
}


