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

namespace MostFrequentElement
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var number = 0;
            var occurence = new int[65535];
            var minJ = 0;
            var arrNum = new List<int>();
            var occurencies = 0;
            for (int i = 0; i < input.Length; i++)
            {
                occurence[input[i]]++;
            }
 
            var max = occurence.Max();
            for (int i = 0; i < occurence.Length; i++)
            {
                if (max == occurence[i])
                {
                    number = i;
                    occurencies++;
                   
                }
            }
 
            if (occurencies > 1)
            {
                for (int j = 0; j < input.Length; j++)
                {
 
                    if (input[j] == number)
                    {
                        if (j < minJ)
                        {
                            minJ = j;
                        }
 
 
                    }
                }
                Console.WriteLine(input[minJ]);
            }
 
            else Console.WriteLine(number);
            Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
 
		}
	}
}