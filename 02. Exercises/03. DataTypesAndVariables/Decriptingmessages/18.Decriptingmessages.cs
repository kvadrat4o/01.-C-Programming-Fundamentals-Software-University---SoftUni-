/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 1:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Decriptingmessages
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int key = int.Parse(Console.ReadLine());
			int n = int.Parse(Console.ReadLine());
			int b = 0;
			char c;
			string currString = null;
			for (int i = 0; i < n; i++) 
			{
				char a = char.Parse(Console.ReadLine());
				b = ((int)a+key);
				c = (char)b;
				currString += c;
			}
			Console.WriteLine(currString);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}