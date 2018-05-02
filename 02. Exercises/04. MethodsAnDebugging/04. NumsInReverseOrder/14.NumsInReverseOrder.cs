/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/19
 * Time: 4:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace NumsInReverseOrder
{
	class Program
	{
		public static void Main(string[] args)
		{
			string number = Console.ReadLine();
			PrintReverse(number);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static string PrintReverse(string number)
		{
			Console.WriteLine(string.Join("",number.Reverse()));
            //Console.WriteLine(number);
            return number;
		}
	}
}