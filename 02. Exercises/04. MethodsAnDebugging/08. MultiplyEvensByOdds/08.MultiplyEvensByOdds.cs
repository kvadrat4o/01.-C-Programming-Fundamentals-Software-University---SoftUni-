/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/18
 * Time: 2:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MultiplyEvensByOdds
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int n = int.Parse(Console.ReadLine());
			int result = GetProductOddAndEventArgs(n);
			Console.WriteLine(result);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static int GetProductOddAndEventArgs(int n)
		{
			int evenSum = GetEvenProduct(n);
        	int oddSum = GetOddProduct(n);
			return evenSum*oddSum;
			
		}
		static int GetOddProduct(int n)
		{
			int oddSum = 0;
			if (n<0) {
				n=Math.Abs(n);
			}
			while (n>0) {
				int lastDigit = n%10;
				if (lastDigit % 2 != 0) {
					oddSum+=lastDigit;
				}
				n/=10;
			}
			return oddSum;
		}
		static int GetEvenProduct(int n)
		{
			int evenSum = 0;
			if (n<0) {
				n=Math.Abs(n);
			}
			while (n>0) {
				int lastDigit = n%10;
				if (lastDigit % 2 == 0) {
					evenSum+=lastDigit;
				}
				n/=10;
			}
			return evenSum;
		}
	}
}