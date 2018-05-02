/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/30
 * Time: 9:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PairByDiff
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int match = 0;
 
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[i] - arr[j] == num || arr[j] - arr[i] == num)
                    {
                        match++;
                    }
                }
            }
            Console.WriteLine(match);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}