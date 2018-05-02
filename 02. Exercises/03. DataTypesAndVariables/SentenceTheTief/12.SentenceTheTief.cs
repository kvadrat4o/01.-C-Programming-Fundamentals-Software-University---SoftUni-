/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 10:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SentenceTheTief
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
			// TODO: Implement Functionality Here
			if (id > 0)
            {
                long sentence = (long) Math.Ceiling((decimal)id / sbyte.MaxValue);
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2} ",id,sentence,(sentence > 1 ? "years" : "year"));
            }
            else
            {
                long sentence = (long)Math.Ceiling((decimal)id / sbyte.MinValue);
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2} ",id,sentence,(sentence > 1 ?"years" : "year"));
            }
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}