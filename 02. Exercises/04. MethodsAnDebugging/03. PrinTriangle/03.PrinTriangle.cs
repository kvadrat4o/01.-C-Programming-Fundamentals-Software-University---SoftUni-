/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/18
 * Time: 8:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PrinTriangle
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			int n = int.Parse(Console.ReadLine());
			PrintTriangle(n);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static void PrintLine(int start,int end)
		{
			for (int i = start; i <= end; i++) {
				Console.Write(i+ " ");
				
			}
			Console.WriteLine();
		}
		static void PrintTriangle(int n)
		{
			for (int line = 1; line <= n; line++) {
				PrintLine(1,line);
				
			}
			for (int line = n-1; line >= 1; line--) {
				PrintLine(1,line);
			}
		}
	}
}