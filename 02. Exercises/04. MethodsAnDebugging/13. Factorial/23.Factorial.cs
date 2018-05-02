/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/23
 * Time: 6:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Numerics;

namespace Factorial
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int n = int.Parse(Console.ReadLine());
			// TODO: Implement Functionality Here
			BigInteger fac = GetFactorial(n);
			Console.WriteLine(fac);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static BigInteger GetFactorial(int n)
		{
			BigInteger factorial = 1;
			for (int i = 1; i <=n; i++) {
				factorial *=i;
			}
			//Console.WriteLine(factorial);
			return factorial;
		}
	}
}