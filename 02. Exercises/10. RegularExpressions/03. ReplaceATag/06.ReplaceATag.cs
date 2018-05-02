using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            //var regex = @"\<a\s*href=.*?>.*?(<\/a>)";
            var sampleRegex = @"< a(href =.*?) > (.*?) <\/ a >";
            var input = Console.ReadLine();
            //var match = "";
            StringBuilder initial = new StringBuilder();
            while (input != "end")
            {
                initial.Append(input);
                input = Console.ReadLine();
            }
            string edited = initial.ToString();
            input = Regex.Replace(edited,regex, m => "[URL " + m.Groups[1].Value + "]" + m.Groups[2].Value + "[/URL]");
            //Console.WriteLine(string.Join("",match));
            Console.WriteLine(input);
        }
    }
}
