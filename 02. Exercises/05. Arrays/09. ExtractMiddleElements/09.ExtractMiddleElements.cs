/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/26
 * Time: 1:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ExtractMiddleElements
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			ExtractMiddle();
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void ExtractMiddle()
		{
			string[] initString = Console.ReadLine().Split(' ');
			int[] numbers = new int[initString.Length];
			for (int i = 0; i < numbers.Length; i++) {
				numbers[i] = int.Parse(initString[i]);
			}
			if (numbers.Length==1) {
				Console.WriteLine(numbers[0]);
			}
			else if (numbers.Length%2==0) {
				Console.WriteLine("{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}");
			}
			else if (numbers.Length%2==1) {
				Console.WriteLine("{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}, {numbers[numbers.Length / 2 + 1]}");
			}
		}
	}
}