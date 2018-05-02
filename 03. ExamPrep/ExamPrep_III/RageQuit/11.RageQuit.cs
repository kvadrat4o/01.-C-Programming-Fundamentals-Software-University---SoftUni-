using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex(@".*?[0-9]+");
            MatchCollection matches = regex.Matches(input);
            foreach (var match in matches)
            {
                string matchOne = match.ToString();
                int count = int.Parse(Regex.Match(matchOne, "[0-9]+").ToString());
                matchOne = Regex.Replace(matchOne, @"[0-9]", "");
                for (int i = 0; i < count; i++)
                {
                    result.Append(matchOne);
                }
            }
            Console.WriteLine("Unique symbols used: {0}", Unique(input));
            Console.WriteLine(result);
        }
        public static int Unique(string input)
        {
            input = input.ToUpper();
            Regex rgx = new Regex(@"[0-9]");
            input = rgx.Replace(input, "");
            string unique = new String(input.Distinct().ToArray());
            return unique.Length;
        }
    }
}
