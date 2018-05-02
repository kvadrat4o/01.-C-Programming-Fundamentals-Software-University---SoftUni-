/*
 * Created by SharpDevelop.
 * User: Dido
 * Date: 6/15/2017
 * Time: 9:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace ImmuneSystem
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int initialHealth = int.Parse(Console.ReadLine());
			var viruses = Console.ReadLine().Split('\n').ToList();
			var command = viruses[0];
			while (command != "end") 
			{
				var virus = viruses[0];
				var strength = virus.Sum() / 3;
				//var time = strength * virus.Length;
				var timeMinSec = (strength * virus.Length) / 60;
				var timeSec = (strength * virus.Length) % 60;
				инт дифф
				if (strength >initialHealth) 
				{
					
				}
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}