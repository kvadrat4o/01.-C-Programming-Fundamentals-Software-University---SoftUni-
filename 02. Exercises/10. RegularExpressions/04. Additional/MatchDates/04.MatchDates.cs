using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var input = Console.ReadLine();
            var match = Regex.Matches(input, regex);
            foreach (Match mat in match)
            {
                var day = mat.Groups["day"].Value;
                var month = mat.Groups["month"].Value;
                var year = mat.Groups["year"].Value;
                Console.Write("Day: {0}, Month: {1}, Year: {2}",day,month,year);
                Console.WriteLine();
            }
        }
    }
}
