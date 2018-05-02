/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/09
 * Time: 2:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;


namespace SumReversedNum
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			string[] nums = Console.ReadLine().Split(' ');
			ReverseAndSum(nums);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void ReverseAndSum(string[] nums)
		{
			int sum = 0;
			for (int i = 0; i < nums.Length; i++) 
			{
				string currN = nums[i];
				string reversedN = String.Join("",currN.Reverse());
				int parsedRevN = int.Parse(reversedN);
				sum += parsedRevN;
			}
			Console.WriteLine(sum);
		}
	}
}