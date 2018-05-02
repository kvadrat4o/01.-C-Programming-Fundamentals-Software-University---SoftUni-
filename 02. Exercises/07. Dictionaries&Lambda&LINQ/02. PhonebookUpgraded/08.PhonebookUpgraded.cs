/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/14
 * Time: 8:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace PhonebookUpgraded
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			SortedDictionary<string, string> phoneDetails = new SortedDictionary<string, string>();
 
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            string token = commands[0];
 
            while (token != "END")
            {
                switch (token)
                {
                    case "A":
                        string index = commands[1];
                        string entry = commands[2];
                        phoneDetails[index] = entry;
                        break;
                    case "S":
                        string searched = commands[1];
                        string result = null;
                        if (phoneDetails.TryGetValue(searched, out result))
                        {
                            Console.WriteLine("{0} -> {1}", searched, result);
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", searched);
                        }
                        break;
                    case "ListAll":
                        foreach (var phone in phoneDetails)
						{
						   Console.WriteLine("{0} -> {1}", phone.Key, phone.Value);
						}
                        break;
                        default:;
                        break;
                	}
                	commands = Console.ReadLine().Split(' ').ToList();
                	token = commands[0];
                }
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}