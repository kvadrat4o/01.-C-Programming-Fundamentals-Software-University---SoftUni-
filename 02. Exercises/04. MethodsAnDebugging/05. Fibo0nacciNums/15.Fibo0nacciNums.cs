/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/22
 * Time: 9:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Fibo0nacciNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine(Fib(num));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static int Fib(int num)
		{
			int sum = 0;
			int prevNum = 0;
			int nextNum = 1;
			if (num>1) 
			{
				for (int i = 1; i <=num+1; i++) 
				{
	                sum = prevNum + nextNum;
	                nextNum = prevNum;
	                prevNum = sum;
			    }
				//Console.WriteLine(sum);
			}
			else if (num<=1)
			{
				Console.WriteLine("1");
			}
			return sum;	
		}
	}
}
