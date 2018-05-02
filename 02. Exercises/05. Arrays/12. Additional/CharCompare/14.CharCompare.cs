/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/30
 * Time: 9:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
namespace CharCompare
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			char[] arr1 = Console.ReadLine().Split(' ').Select(x=>char.Parse(x)).ToArray();
			char[] arr2 = Console.ReadLine().Split(' ').Select(x=>char.Parse(x)).ToArray();
			CompareChars(arr1,arr2);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void CompareChars(char[] arr1,char[] arr2)
		{
			int shorter = Math.Min(arr1.Length,arr2.Length);
			for (int i = 0; i < shorter; i++) 
			{
				if (arr1.Length == arr2.Length && arr1[i] == arr2[i]) 
				{
					Console.WriteLine(arr1);
                	break;
				}
				else if (arr1.Length != arr2.Length && arr1[i] == arr2[i]) 
				{
					Console.WriteLine(arr1.Length > arr2.Length ? arr2 : arr1);
                	Console.WriteLine(arr1.Length < arr2.Length ? arr2 : arr1);
                	break;
				}
				else if (arr1[i]>arr2[i]) 
				{
					Console.WriteLine(arr2);
					Console.WriteLine(arr1);
					break;
				}
				else if (arr1[i]<arr2[i]) 
				{
					Console.WriteLine(arr1);
					Console.WriteLine(arr2);
					break;
				}
			}
		}
	}
}