/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/22
 * Time: 10:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PrimeChecker
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			double num = double.Parse(Console.ReadLine());
			Console.WriteLine(PrimeChecker(num));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static bool PrimeChecker(double num)
		{
			
			bool prime = false;
			if (num<2) {
				prime = false;
			}
			else {
				for (int i = 1; i <=Math.Sqrt(num); i++) {
					if (num%i==0)
					{
						prime=false;
					}
					else if (num%i!=0)
					{
						prime = true;
					}
				}
			}
			return prime;
		}
	}
}