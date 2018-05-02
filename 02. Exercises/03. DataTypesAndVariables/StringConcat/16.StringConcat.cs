/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 10:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace StringConcat
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			char delimiter = char.Parse(Console.ReadLine());
			int remainder = Console.ReadLine() == "even" ? (int)0 : (int)1;
			int n = int.Parse(Console.ReadLine());
			string currString = null;
			for (int i = 1; i <= n; i++) 
			{
				if (i%2==remainder) 
				{
						currString += Console.ReadLine() + delimiter;
				}
				else 
				{
					Console.ReadLine();
				}
						
			}
			Console.WriteLine(currString.Remove(currString.Length-1));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}