/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/25
 * Time: 9:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ReverseArray
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter number");
			int n =int.Parse(Console.ReadLine());
			// TODO: Implement Functionality Here
			GetReverse(n);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void GetReverse(int n)
		{
			int [] numbers = new int [n];
			for (int i = 0; i < numbers.Length; i++) {
				numbers[i] = int.Parse(Console.ReadLine());
			}
			for (int i = n-1; i >=0; i--) {
				Console.Write(numbers[i]+" ");
			}
			//Console.WriteLine;
		}
	}
}