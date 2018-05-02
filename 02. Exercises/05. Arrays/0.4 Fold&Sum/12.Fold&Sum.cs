/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/30
 * Time: 9:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Fold_Sum
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			string[] strings = Console.ReadLine().Split(' ');
			int[] numbers = new int[strings.Length];
			for (int i = 0; i < strings.Length; i++) {
				numbers[i] = int.Parse(strings[i]);
			}
			int[] left = new int[numbers.Length/4];
			int[] right = new int[numbers.Length/4];
			//int[] lowerSum = new int[numbers.Length/2];
			int[] sum = new int[numbers.Length/2];
			FoldAndSum(numbers,sum,left, right);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void FoldAndSum(int[] numbers, int[] sum, int[] left,int[] right)
		{
			//var last = input.Length - 1;
            for (var i = 0; i < numbers.Length/4; i ++ )
            {
            	left[i] = numbers[(numbers.Length / 4) - 1 - i];
            	right[i] = numbers[numbers.Length - 1 - i];
            }
            for (int i = 0; i < (numbers.Length / 4); i++)
	        {
	            sum[i] = left[i] + numbers[numbers.Length / 4 + i];
	            sum[numbers.Length / 4 + i] = right[i] + numbers[numbers.Length / 2 + i];
	        }
	 
	        Console.WriteLine(string.Join(" ", sum));
            
		}
	}
}