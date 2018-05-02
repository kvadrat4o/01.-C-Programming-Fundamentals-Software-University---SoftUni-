using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> privates = new List<string>();
            List<string> broadcasts = new List<string>();
            var privatesRegex = new Regex(@"(\d+) \<\-\> ([a-zA-Z0-9]+)$");
            var broadcastsRegex = new Regex(@"(^\D+) \<\-\> ([a-zA-Z0-9]+)$");
            var code = "";
            var freq = "";
            var line = Console.ReadLine();
            while (line != "Hornet is Green")
            {
                if (privatesRegex.IsMatch(line))
                {
                    Match privateMatch = privatesRegex.Match(line);
                    code = string.Join("",privateMatch.Groups[1].Value.Reverse());
                    var prvtMessage = privateMatch.Groups[2];
                    privates.Add(code + " -> " + prvtMessage);
                }
                if (broadcastsRegex.IsMatch(line))
                {
                    Match broadcastMatch = broadcastsRegex.Match(line);
                    freq = ExchangeLetters(broadcastMatch.Groups[2].Value);
                    var brdcMessage = broadcastMatch.Groups[1].Value;
                    broadcasts.Add(freq + " -> " + brdcMessage);
                }
                line = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                Console.WriteLine(string.Join("\n", broadcasts));
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (privates.Count > 0)
            {
                Console.WriteLine(string.Join("\n", privates));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
        private static string ExchangeLetters(string p)
        {
            
            string decrypted = "";
            foreach (char currChar in p)
            {
                if (currChar >= 65 && currChar <= 90)
                {
                    decrypted += (char)(currChar + 32);
                }
                else if (currChar >= 97 && currChar <= 122)
                {
                    decrypted += (char)(currChar - 32);
                }
                else
                {
                    decrypted += currChar;
                }
            }
            return decrypted;
        }
    }
}
