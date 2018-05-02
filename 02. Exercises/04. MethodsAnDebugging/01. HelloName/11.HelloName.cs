/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/19
 * Time: 3:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HelloName
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			PrintGreeting(Console.ReadLine());
			
		}
		public static string PrintGreeting(string name)
		{
			Console.WriteLine("Hello, {0}!",name);
			return name;
		}
	}
}