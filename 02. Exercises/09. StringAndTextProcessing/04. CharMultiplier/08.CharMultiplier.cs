using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split();
            var sum = 0;
            var firstStr = strings[0];
            var secondStr = strings[1];
            var shorter = Math.Min(firstStr.Length, secondStr.Length);
            for (int i = 0; i < shorter; i++)
            {
                var firstLet = (int)firstStr[i];
                var secondLet = (int)secondStr[i];
                sum += firstLet * secondLet;
            }
            var longer = firstStr.Length > secondStr.Length ? firstStr : secondStr;
            for (int i = shorter; i < longer.Length; i++)
            {
                sum += longer[i];
            }
            Console.WriteLine(sum);
        }
    }
}
