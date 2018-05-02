/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/30
 * Time: 9:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace IndexOfLetter
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			string input = Console.ReadLine().ToLower();
			PrintIndex(input);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void PrintIndex(string input)
		{
			
			char[] chars = input.ToCharArray();
			for (int i = 0; i < chars.Length; i++) 
			{
				Console.WriteLine("{0} -> {1}",chars[i],(int)chars[i] % 32 - 1);
			}
			
		}
	}
}