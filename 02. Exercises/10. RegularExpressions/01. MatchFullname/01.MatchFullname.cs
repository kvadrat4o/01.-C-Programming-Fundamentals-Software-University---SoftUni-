using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var input = Console.ReadLine();
            MatchCollection trues = Regex.Matches(input,regex);
            foreach (Match tru in trues)
            {
                Console.Write("{0} ",tru.Value);
            }
            Console.WriteLine();
        }
    }
}
