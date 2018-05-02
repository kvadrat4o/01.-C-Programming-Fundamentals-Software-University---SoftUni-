using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?(\d+)(\.?\d+)?($|(?=\s))";
            var input = Console.ReadLine();
            MatchCollection matched = Regex.Matches(input, regex);
            foreach (Match match in matched)
            {
                Console.WriteLine($"{match.Value} ");
            }
        }
    }
}
