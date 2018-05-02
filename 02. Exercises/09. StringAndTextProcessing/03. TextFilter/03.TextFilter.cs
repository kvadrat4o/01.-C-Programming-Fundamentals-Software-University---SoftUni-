using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var banned = Console.ReadLine().Split(new Char[] { ',',' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            var input = Console.ReadLine();
            foreach (var ban in banned)
            {
                if (input.Contains(ban))
                {
                    input = input.Replace(ban, new string('*', ban.Length));
                }
            }
            Console.WriteLine(input);
        }
    }
}
