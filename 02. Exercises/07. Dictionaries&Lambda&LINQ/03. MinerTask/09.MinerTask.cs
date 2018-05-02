/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/14
 * Time: 8:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace MinerTask
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			var resources = new Dictionary<string,decimal>();
			
			var line = Console.ReadLine();
			while (line != "stop") 
			{
				string resource = line;
				decimal quantity = decimal.Parse(Console.ReadLine());
				if (!resources.ContainsKey(resource)) 
				{
					resources[resource] = 0;
				}
				resources[resource] += quantity;
				line = Console.ReadLine();
			}
			foreach (var resource in resources) 
			{
				Console.WriteLine("{0} -> {1}",resource.Key,resource.Value);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}