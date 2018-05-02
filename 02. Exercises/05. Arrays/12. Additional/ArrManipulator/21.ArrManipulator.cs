/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/14
 * Time: 8:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace ArrManipulator
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			string[] input  = Console.ReadLine().Split(' ').ToArray();
			int n = int.Parse(Console.ReadLine());
			string[] commands = Console.ReadLine().Split(' ');
			string command = commands[0];
			for (int i = 0; i < n; i++) 
			{
				if (n>=1&&n<=100) 
				{
					if (command == "Reverse") 
					{
						Array.Reverse(input);
					}
					else if (command == "Replace") 
					{
						int index = int.Parse(commands[1]);
						string replaced = commands[2];
						input[index] = replaced;
					}
					else if (command == "Distinct") 
					{
						input = input.Distinct().ToArray();
					}
				}	
			}
			Console.WriteLine(String.Join(", ", input));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}