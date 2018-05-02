using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split(" \t".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            var sum = 0d;
            foreach (var str in strings)
            {
                var first = str.First();
                var second = str.Last();
                var number = double.Parse(str.Substring(1,str.Length - 2));
                if (char.IsUpper(first))
                {
                    number /= first - ('A' - 1);
                }
                else
                {
                    number *= first - ('a' - 1);
                }
                if (char.IsUpper(second))
                {
                    number -= second - ('A' - 1);
                }
                else
                {
                    number += second - ('a' - 1);
                }
                sum += number;
            }
            Console.WriteLine("{0:f2}",sum);
        }
    }
}
