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
namespace MaxEqual
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int[] numbers = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
			GetEqualSeq(numbers);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void GetEqualSeq(int[] numbers)
		{
        	int bestNum = 0,
            len = 1, 
            bestLen = 1;
	        bestNum = numbers[0];
	        for (int i = 1; i < numbers.Length; i++)
	        {
	            if (numbers[i - 1] == numbers[i])
	            {
	                len++;            
	                if (len > bestLen)
	                {
	                    bestLen = len; 
	                    bestNum = numbers[i]; 
	                }
	            }
	            else len = 1;       
	        }
	        for (int i = 0; i < bestLen; i++)
	        {
	        	Console.Write("{0} ",bestNum);
	        }
	        Console.WriteLine();
		}
	}
}