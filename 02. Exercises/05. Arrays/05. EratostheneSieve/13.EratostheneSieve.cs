/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/30
 * Time: 9:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace EratostheneSieve
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
			Erathostene(n,primes);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void Erathostene(int n, bool[] primes)
		{
			for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = false; primes[1] = false;
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    for (int m = 2; (m * i) <= n; m++)            
                    {
                        primes[m * i] = false;
                    }
                }
            }
            for (int j = 2; j <= n; j++)
            {
                if (primes[j] == true)
                { 
                	Console.Write(j + " ");
                }
            }
            Console.WriteLine();
			
		}
	}
}
