/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/26
 * Time: 10:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ReverseString
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			ReverseString();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void ReverseString()
		{
			string[] initString = Console.ReadLine().Split(' ');
			for (int i = 0; i < initString.Length/2; i++) 
			{
				string temp = initString[i];
				initString[i] = initString[initString.Length-1-i];
				initString[initString.Length-1-i] = temp;
			}
			Console.WriteLine(string.Join(" ",initString));
		}
	}
}