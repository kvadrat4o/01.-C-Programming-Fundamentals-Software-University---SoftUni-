/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/09
 * Time: 9:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Greeting
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter first name: ");
			string fName = Console.ReadLine();
			//Console.WriteLine("enter last name: ");
			string lName = Console.ReadLine();
			//Console.WriteLine("enter first name: ");
			int age = int.Parse(Console.ReadLine());
			Console.WriteLine("Hello, {0} {1}.\nYou are {2} years old.",fName,lName,age);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}