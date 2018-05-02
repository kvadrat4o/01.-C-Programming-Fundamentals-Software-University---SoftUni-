/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/07
 * Time: 9:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CatchTheTief
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			string input = Console.ReadLine().ToLower();
			int n = int.Parse(Console.ReadLine());
			long id = long.MinValue;
			while (n>0)
			{
				string currentID = Console.ReadLine();
                if (input == "sbyte")
                {
                    try
                    {
                        long currID = sbyte.Parse(currentID);
                        id = Math.Max(currID, id);
                    }
                    catch(Exception)
                    {

                    }
                }
                if (input == "int")
                {
                    try
                    {
                        long currID = int.Parse(currentID);
                        id = Math.Max(currID, id);
                    }
                    catch (Exception)
                    {

                    }
                }
                if (input == "long")
                {
                    try
                    {
                        long currID = long.Parse(currentID);
                        id = Math.Max(currID, id);
                    }
                    catch (Exception)
                    {

                    }
                }

                n--;
			}
            Console.WriteLine(id);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}