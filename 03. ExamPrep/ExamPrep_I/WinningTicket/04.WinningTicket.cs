using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
 
            foreach (var ticket in input)
            {
                if (ticket.Count() != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
 
                else
                {
                    int count = ticket.Count();
                    var leftPart = ticket.Substring(0, count / 2);
                    var rightPart = ticket.Substring(count / 2);
 
                    Regex pattern = new Regex(@"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}");
                    Match leftMatch = pattern.Match(leftPart);
                    Match rightMatch = pattern.Match(rightPart);
                    int min = Math.Min(leftMatch.Length, rightMatch.Length);
 
 
                    if (leftMatch.ToString().Substring(0,min) == rightMatch.ToString().Substring(0,min))
                    {
                        if (leftMatch.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {min}{leftMatch.ToString().Substring(1, 1)} Jackpot!");
                        }
 
                        else if (leftMatch.Length >= 6 && leftMatch.Length < 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {min}{leftMatch.ToString().Substring(1, 1)}");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                   
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
        }
    }
}
    }
}
