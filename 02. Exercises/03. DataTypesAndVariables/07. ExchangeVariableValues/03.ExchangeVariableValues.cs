/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/09
 * Time: 4:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ExchangeVariableValues
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			//Console.WriteLine("{0}\n{1}",a,b);
			a ^= b;
			b ^= a;
			a ^= b;
			Console.WriteLine("{0}\n{1}",a,b);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}