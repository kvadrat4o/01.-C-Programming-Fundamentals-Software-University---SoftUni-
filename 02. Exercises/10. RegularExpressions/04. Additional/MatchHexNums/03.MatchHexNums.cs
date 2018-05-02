using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace MatchHexNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?:0x)?[0-9A-F]+\b";
            var input = Console.ReadLine();
            var hex = Regex.Matches(input, regex).Cast<Match>().Select(a => a.Value).ToList();
            Console.WriteLine(string.Join(" ",hex));
        }
    }
}
