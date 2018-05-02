/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/18
 * Time: 9:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FilledSquare
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			int n = int.Parse(Console.ReadLine());
			PrintRows(n);
			PrintMiddleRows(n);
			PrintRows(n);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static void PrintRows(int n)
		{
			Console.WriteLine(new string('-',2*n));
		}
		static void PrintMiddleRows(int n)
		{
			for (int i = 0; i < n-2; i++) {
				Console.Write('-');
				for (int j = 0; j < n-1; j++) {
					Console.Write("\\/");
				}
				Console.WriteLine('-');
			}
		}
	}
}