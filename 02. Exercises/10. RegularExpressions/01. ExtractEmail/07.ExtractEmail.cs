using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
            var matches = Regex.Matches(input,regex);
            foreach (Match match in matches)
            {
                Console.WriteLine("Email: {0}", match.Groups[1]);
            }
        }



        //string input = Console.ReadLine();
        //string pattern = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
        //Regex regex = new Regex(pattern);
        //MatchCollection matches = regex.Matches(input);
        //Console.WriteLine("Found {0} matches", matches.Count);
        //foreach (Match match in matches)
        //{
        //    Console.WriteLine("Email: {0}", match.Groups[1]);
        //}
}
}
