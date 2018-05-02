/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/30
 * Time: 9:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
namespace MaxIncreasing
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int[] numbers = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
			int length = numbers.Length;
			GetEqualSeq(numbers);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void GetEqualSeq(int[] numbers)
		{
        	int counterCurrSeq = 0;
            int startCurrSeq = 0;
            int counterMaxSeq = 0;
            int startMaxSeq = 0;
	        for (int i = 1; i < numbers.Length; i++)
	        {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    counterCurrSeq++;
                    startCurrSeq = i - counterCurrSeq;
 
                    if (counterCurrSeq > counterMaxSeq)
                    {
                        counterMaxSeq = counterCurrSeq;
                        startMaxSeq = startCurrSeq;
                    }
                }
                else
                {
                    counterCurrSeq = 0;
                }
	        }
	        for (int i = startMaxSeq; i <= (startMaxSeq + counterMaxSeq); i++)
            {
                Console.Write(numbers[i] + " ");
            }
	        Console.WriteLine();
		}
	}
}
