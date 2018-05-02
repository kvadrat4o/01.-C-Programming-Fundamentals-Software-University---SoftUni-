/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 10:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SumOfChars
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			int n = int.Parse(Console.ReadLine());
			int sum = 0;
			for (int i = 0; i < n; i++) 
			{
				char input = char.Parse(Console.ReadLine());
				int intValue = (int)input;
				sum +=intValue;
			}
			Console.WriteLine("Tte sum equals: {0}",sum);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}