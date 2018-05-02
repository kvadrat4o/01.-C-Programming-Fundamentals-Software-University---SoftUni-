/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/09
 * Time: 2:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DataTypesAndVariables
{
	class Program
	{
		public static void Main(string[] args)
		{
			sbyte num1 = -100;
			byte num2 = 128;
			short num3 = -3540;
			int num4 = 64876;
			ulong num5 = 2147483648;
			long num6 = -1141583228;
			long num7 = -1223372036854775808;
			Console.WriteLine(num1);
			Console.WriteLine(num2);
			Console.WriteLine(num3);
			Console.WriteLine(num4);
			Console.WriteLine(num5);
			Console.WriteLine(num6);
			Console.WriteLine(num7);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}