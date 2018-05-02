/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/26
 * Time: 3:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LCE
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			string[] arrayOne = Console.ReadLine().Split(' ');
			string[] arrayTwo = Console.ReadLine().Split(' ');
			int maxCountLeft = ScanFromLeft(arrayOne,arrayTwo);
			int maxCountRight = ScanFromRight(arrayOne,arrayTwo);
			Console.WriteLine(maxCountLeft);
			
			if (maxCountLeft==0&&maxCountRight==0) 
			{
				Console.WriteLine(0);
			}
			else if (maxCountLeft>maxCountRight) 
			{
				Console.WriteLine(maxCountLeft);
			}
			else 
			{
				Console.WriteLine(maxCountRight);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static int ScanFromRight(string[] arrayOne, string[] arrayTwo)
		{
			int counter = 0;
			int maxCount = 0;
			int longer = arrayOne.Length-1;
			if (arrayOne.Length>arrayTwo.Length) 
			{
				for (int i = arrayTwo.Length-1; i>=0; i--) 
				{
					if (arrayOne[longer] == arrayTwo[i]) 
					{
						counter++;
					}
					else 
					{
						if (maxCount<counter) 
						{
							maxCount=counter;
						}
					counter = 0;
					}
				}
				return maxCount;
			}
			else 
			{
				
				for (int i = arrayOne.Length-1; i>=0; i--) 
				{
					if (arrayTwo[longer] == arrayOne[i]) 
					{
						counter++;
					}
					else 
					{
						if (maxCount<counter) 
						{
							maxCount=counter;
						}
					counter = 0;
					}
				}
			}
			if (maxCount<counter) 
				{
					maxCount=counter;
				}
			return maxCount;
		}
		public static int ScanFromLeft(string[] arrayOne, string[] arrayTwo)
		{
			int shorter = Math.Min(arrayOne.Length,arrayTwo.Length);
			string[] result = new string[shorter];
			int counter = 0;
			int maxCount = 0;
			for (int i = 0; i < shorter; i++) 
			{
				if (arrayOne[i]==arrayTwo[i]) 
				{
					counter++;
					result[i] = arrayOne[i];
				}
				else
				{
					if (maxCount<counter) 
					{
						maxCount=counter;
					}
					counter = 0;
				}
			}
			Console.WriteLine(maxCount);
			if (maxCount<counter) 
				{
					maxCount=counter;
				}
			return maxCount;
		}
	}
}
