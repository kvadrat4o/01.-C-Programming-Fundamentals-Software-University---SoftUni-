/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/17
 * Time: 3:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SignOfInt
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			PrintSign(n);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		private static void PrintSign(int n)
		{
			if (n<0) {
				Console.WriteLine("The number {0} is negative",n);
			}
			else if (n==0) {
				Console.WriteLine("The number {0} is zero",n);
			}
			else if (n>0) {
				Console.WriteLine("The number {0} is positive",n);
			}
		}
	}
}