/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 5:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace SumEqualNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<double> nums = Console.ReadLine().Split(' ').Select(x=>double.Parse(x)).ToList();
			for (int i = 1; i < nums.Count; i++) 
			{
				if (nums[i-1]==nums[i]) 
				{
					nums[i-1]+=nums[i];
					nums.RemoveAt(i);
					i = i-2;
					if (i<0) 
					{
						i=0;
					}
				}	
			}
			Console.WriteLine(String.Join(" ",nums));
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}