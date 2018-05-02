using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Base10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> remainers = new List<int>();
            var result = new StringBuilder();
            var input = Console.ReadLine().Split(' ');
            var @base = int.Parse(input[0]);
            var num = BigInteger.Parse(input[1]);
            while (num > 0)
            {
                var remainer = num % @base;
                result.Append(remainer);
                num /= @base;
                
            }
            var reversed = new string(result.ToString().Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }
}
