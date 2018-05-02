/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/22
 * Time: 10:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInRange
{
	class Program
	{
		public static void Main(string[] args)
		{
			int start = int.Parse(Console.ReadLine());
			int end = int.Parse(Console.ReadLine());
			int counter = 0;
			GetPrimes(start,end,counter);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void GetPrimes(int start, int end,int counter)
		{
				List<int> primes = new List<int>();
				if (start < 0 || end < 0)
	            {
	                start = 2;
	            }
	            if (start == 0 || start == 1)
	            {
	                start = 2;
	            }
	            if (start > end)
	            {
	                Console.WriteLine("empty list");
	            }
					for (int i = start; i <=end; i++) 
					{
						for (int j = 1; j <= i; j++) 
						{
							 if (i % j == 0)
		                    {
		                        counter++;
		                    }
		                    if (counter > 2)
		                    {
		                        break;
		                    }
						}
						if (counter <= 2)
		                {
		                    primes.Add(i);
		                }
		                counter = 0;
					}
				Console.WriteLine(string.Join(", ", primes));
		}
	}
}
