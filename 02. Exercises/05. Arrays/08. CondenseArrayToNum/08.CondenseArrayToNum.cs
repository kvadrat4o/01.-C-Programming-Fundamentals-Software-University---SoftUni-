/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/26
 * Time: 1:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CondenseArrayToNum
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			CondenseToNum();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void CondenseToNum()
		{
			string[] stringNums = Console.ReadLine().Split(' ');
			int[] numbers = new int[stringNums.Length];
			int sum = 0;
			for (int i = 0; i < numbers.Length; i++) 
			{
				numbers[i] = int.Parse(stringNums[i]);
			}
			int[] condensed = new int[numbers.Length-1];
			if (numbers.Length == 1)
		        {
		            Console.WriteLine(numbers[0]);
		            return;
		        }
			for (int i = 0; i < numbers.Length; i++) {
				for (int j = 0; j < condensed.Length-i; j++) 
					{
						sum = condensed[j] = numbers[j]+numbers[j+1];
					}
				numbers = condensed;
			}
			Console.WriteLine(condensed[0]);
		}
	}
}
