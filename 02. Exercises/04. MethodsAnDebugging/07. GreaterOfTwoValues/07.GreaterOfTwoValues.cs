/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/18
 * Time: 1:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GreaterOfTwoValues
{
	class Program
	{
		public static void Main(string[] args)
		{
			var type = Console.ReadLine().ToLower();
			if (type == "int") {
				int a = int.Parse(Console.ReadLine());
				int b = int.Parse(Console.ReadLine());
				int max = GetMax(a,b);
				Console.WriteLine(max);
			}
			else if (type == "char") {
				char a = Convert.ToChar(Console.ReadLine());
				char b = Convert.ToChar(Console.ReadLine());
				char max = GetMax(a,b);
				Console.WriteLine(max);
			}
			else if (type == "string") {
				string a = Console.ReadLine().ToLower();
				string b = Console.ReadLine().ToLower();
				string max = GetMax(a,b);
				Console.WriteLine(max);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static int GetMax(int a,int b)
		{
			if (a>=b) {
				return a;
			}
			else {
				return b;
			}
		}
		static char GetMax(char a, char b)
		{
			if (a>=b) {
				return a;
			}
			else {
				return b;
			}
		}
		static string GetMax(string a, string b)
		{
			if ((a.CompareTo(b))>=0) {
				return a;
			}
			else {
				return b;
			}
		}
	}
}