/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/09
 * Time: 12:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace MaxSeqEqualElements
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<int> nums = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToList();
			GetMaxEqSeq(nums);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void GetMaxEqSeq(List<int> nums)
		{
			List<int> longestsubSec = new List<int>();
			List<int> currSubSec = new List<int>();
			currSubSec.Add(nums[0]);
			
			for (int i = 1; i < nums.Count; i++) 
			{
				if (nums[i] == currSubSec[0])
				{
					currSubSec.Add(nums[i]);
				}
				else
				{
					if (currSubSec.Count > longestsubSec.Count) 
					{
						longestsubSec = new List<int>();
						for (int j = 0; j < currSubSec.Count; j++) 
						{
							longestsubSec.Add(currSubSec[j]);
						}
					}
					currSubSec = new List<int>();
					currSubSec.Add(nums[i]);
				}
			}
			if (currSubSec.Count > longestsubSec.Count) 
				{
					longestsubSec = new List<int>();
					longestsubSec.AddRange(currSubSec);
				}
			Console.WriteLine(String.Join(" ",longestsubSec));
		}
	}
}