/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/26
 * Time: 4:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Rotate_Sum
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			string[] initString = Console.ReadLine().Split(' ');
			int[] numbersInit = new int[initString.Length];
			for (int i = 0; i < numbersInit.Length; i++) 
			{
				numbersInit[i] = int.Parse(initString[i]);
			}
			int k = int.Parse(Console.ReadLine());
			int[] sum = new int[numbersInit.Length];
			for (int i = 0; i < k; i++)
            {
                RotateAndSum(numbersInit, sum);
            }
			// TODO: Implement Functionality Here
			Console.WriteLine(string.Join(" ", sum));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void RotateAndSum(int[] input, int[] sum)
		{
			var last = input.Length - 1;
            for (var i = 0; i < input.Length - 1; i ++ )
            {
                input[i] ^= input[last];
                input[last] ^= input[i];
                input[i] ^= input[last];
            }
            for (int i = 0; i < input.Length; i++)
            {
                sum[i] += input[i];
            }
		}
		
	}
}