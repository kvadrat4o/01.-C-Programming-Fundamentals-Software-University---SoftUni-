/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/26
 * Time: 11:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SumArrays
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			SumArray();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void SumArray()
		{
			string[] arOne = Console.ReadLine().Split(' ');
			int[] arrayOne = new int[arOne.Length];
			for (int i = 0; i < arOne.Length; i++) 
			{
				arrayOne[i] = int.Parse(arOne[i]);
			}
			string[] arTwo = Console.ReadLine().Split(' ');
			int[] arrayTwo = new int[arTwo.Length];
			for (int i = 0; i < arTwo.Length; i++) 
			{
				arrayTwo[i] = int.Parse(arTwo[i]);
			}
			int[] sumArray =new int [Math.Max(arrayOne.Length,arrayTwo.Length)];
			for (int i = 0; i < sumArray.Length; i++) {
				sumArray[i] = arrayOne[i % arrayOne.Length]+arrayTwo[i % arrayTwo.Length];
				
			}
			Console.WriteLine(string.Join(" ", sumArray));
			
		}
	}
}