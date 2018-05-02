using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractByKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var regex = @"([A-Z][\w\W]*?\b"+key+"\b[\w\W]*?[.!?])";
            var input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input,regex);
            foreach (Match match in matches)
            {
                Console.WriteLine($"{match.Value}");
            }
        }
    }
}
