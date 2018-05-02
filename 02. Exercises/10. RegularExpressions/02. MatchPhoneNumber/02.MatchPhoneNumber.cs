using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleRegex = @"\+359([\s\-])2\1\d{3}\1\d{4}\b";
            var input = Console.ReadLine();
            MatchCollection matchesDash = Regex.Matches(input, sampleRegex);
            var result = Regex.Matches(input,sampleRegex).Cast<Match>().Select(a =>a.Value).ToList();
            Console.WriteLine(string.Join(", ",result));

        }
    }
}
