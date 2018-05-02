/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/06
 * Time: 10:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TypeBoundaries
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			var input = Console.ReadLine().ToLower();
			switch (input) 
			{
				case "int":
					Console.WriteLine("{0}\n{1}",int.MaxValue,int.MinValue);
					break;
				case "byte":
					Console.WriteLine("{0}\n{1}",byte.MaxValue,byte.MinValue);
					break;
				case "uint":
					Console.WriteLine("{0}\n{1}",uint.MaxValue,uint.MinValue);
					break;
				case "sbyte":
					Console.WriteLine("{0}\n{1}",sbyte.MaxValue,sbyte.MinValue);
					break;
				case "long":
					Console.WriteLine("{0}\n{1}",long.MaxValue,long.MinValue);
					break;
				default:
					Console.WriteLine("Default");
					break;
			}
		}
	}
}