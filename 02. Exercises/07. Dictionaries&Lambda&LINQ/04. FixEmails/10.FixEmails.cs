/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/15
 * Time: 8:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace FixEmails
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			var maiList = new Dictionary<string,string>();
			string command = Console.ReadLine();
			while (command != "stop") 
			{
				string name = command;
				string email = Console.ReadLine();
				maiList[name] = email;
				command = Console.ReadLine();
			}
			var fixedMails = maiList
				.Where(x => !x.Value.EndsWith("us", StringComparison.OrdinalIgnoreCase) && !x.Value.EndsWith("uk",StringComparison.OrdinalIgnoreCase)).ToDictionary(p => p.Key, p => p.Value);
			foreach (var pair in fixedMails) 
			{
				var nameKey = pair.Key;
				var emailaddress = pair.Value;
				Console.WriteLine("{0} -> {1}",nameKey,emailaddress);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}