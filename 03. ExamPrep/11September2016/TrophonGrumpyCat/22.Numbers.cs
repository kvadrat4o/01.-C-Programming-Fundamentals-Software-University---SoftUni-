using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(a => int.Parse(a));
            var avg = input.Average();
            var results = input.Where(a => a > avg).OrderByDescending(a => a).ToList();
            if (results.Count < 5)
            {
                Console.WriteLine(string.Join(" ",results));
            }
            else if (results.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ",results.Take(5)));
            }
        }
    }
}
