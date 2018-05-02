/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/24
 * Time: 9:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Numerics;

namespace ZeroesFactorial
{
	class Program
	{
		public static void Main(string[] args)
		{
            //Console.WriteLine("Hello World!");
			int n = int.Parse(Console.ReadLine());
			// TODO: Implement Functionality Here
			BigInteger fac = GetFactorial(n);
			BigInteger zeroes = GetZeroes(fac);
			//Console.WriteLine(fac);
			Console.WriteLine(zeroes);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static BigInteger GetFactorial(int n)
		{
			BigInteger factorial = 1;
			for (int i = 1; i <=n; i++) {
				factorial *=i;
			}
			return factorial;
		}
		public static BigInteger GetZeroes(BigInteger n)
		{
			BigInteger zeroCount = 0;
            while (n % 10 == 0)
            {
                n = n / 10;
                zeroCount++;
            }
            return zeroCount;
		}
	}
}