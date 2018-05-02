/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/09
 * Time: 2:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace BombNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<int> inputNums = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToList();
			BombIt(inputNums);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void BombIt(List<int> inputNums)
		{
			string[] input = Console.ReadLine().Split();
	        int number = int.Parse(input[0]);
	        int power = int.Parse(input[1]);
	 
	        for (int i = 0; i < inputNums.Count; i++)
	        {
	            if (inputNums[i] == number)
	            {
	                int left = Math.Max(i - power, 0);
	 
	                int right = Math.Min(i + power, inputNums.Count - 1);
	 
	                int lenght = right - left + 1;
	                inputNums.RemoveRange(left, lenght);
	                i = 0;
	            }
        }
        Console.WriteLine(inputNums.Sum());
		}
	}
}

 
        