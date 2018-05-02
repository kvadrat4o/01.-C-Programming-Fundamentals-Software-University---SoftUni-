/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/15
 * Time: 3:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SearchForANumber
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			List<int> results = new List<int>();
			List<int> input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
			int[] restrictions = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
			var takeSub = restrictions[0];
			var deleteSub = restrictions[1];
			var special = restrictions[2];
			results = input.Take(takeSub).ToList();
			for (int i = 0; i < deleteSub; i++) 
			{
				results.RemoveAt(i);
			}
			bool exists = false;
			foreach (var num in results) 
			{
				if (special == num) 
				{
					exists = true;
				}
				else 
				{
					exists = false;
				}
			}
			if (exists == true) 
			{
				Console.WriteLine("YES!");	
			}
			else
			{
				Console.WriteLine("NO!");
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}