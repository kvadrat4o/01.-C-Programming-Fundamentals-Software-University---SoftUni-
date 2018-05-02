/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/06
 * Time: 10:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNegativesAndReverse
{
	class Program
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var parsed = new List<int>();
 
            for (int i = input.Count - 1; i >= 0; i--)
            {
                if (input[i] > 0)
                {
                    parsed.Add(input[i]);
                }
                else
                {
                    parsed.Remove(input[i]);
                }
            }
            	if (parsed.Count<=0) 
            	{
            		Console.Write("empty");
            	}
            	else 
            	{
            		foreach (var items in parsed)
		            {
		            	Console.Write("{0} ", items);
		            }
            	}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}