/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/11
 * Time: 2:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TeraBTtoBits
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter tera bytes amount: ");
			decimal tera = decimal.Parse(Console.ReadLine());
			
			decimal bits = 0;
			// TODO: Implement Functionality Here
        	Console.WriteLine("{0:f0}",bits);

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}