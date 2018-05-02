/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/25
 * Time: 10:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LastKSums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int n = int.Parse(Console.ReadLine());
			int k  = int.Parse(Console.ReadLine());
			// TODO: Implement Functionality Here
			Console.WriteLine(GetSum(n,k));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static long [] GetSum(int n, int k)
		{
			long[] seq = new long[n];
			seq[0] = 1;
			long sum = 0L;
			for (int i = 1; i < n; i++) 
			{
				var start = Math.Max(0, i - k);
                var end = i - 1;
				for (int j = 1; j < n; j++) 
				{
					sum +=seq[j];
				}
				 seq[i] = sum;
			}
			Console.WriteLine(string.Join(" ", seq));
			return seq;
		}
	}
}