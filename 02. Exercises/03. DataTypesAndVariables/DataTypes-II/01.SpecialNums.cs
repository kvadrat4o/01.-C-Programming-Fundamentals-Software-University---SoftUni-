/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/09
 * Time: 9:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DataTypes_II
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter num: ");
			int n = int.Parse(Console.ReadLine());
			// TODO: Implement Functionality Here
			for (int i = 1; i <= n; i++)
        	{
	            int sum = 0;
	            int number = i;
	            while (number > 0)
		            {
		                sum += number % 10;
		                number = number / 10;
		            }
				bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
            	Console.WriteLine("{0} -> {1}",i,isSpecial);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}