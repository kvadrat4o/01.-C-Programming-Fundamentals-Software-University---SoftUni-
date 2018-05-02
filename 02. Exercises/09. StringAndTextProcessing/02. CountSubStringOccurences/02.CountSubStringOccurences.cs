using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubStringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var substr = Console.ReadLine().ToLower();
            var count = 0;
            int strIndex = input.IndexOf(substr);
            while (strIndex != -1)
            {
                count++;
                strIndex = input.IndexOf(substr, strIndex + 1);
            }
            Console.WriteLine(count);
        }
    }
}
