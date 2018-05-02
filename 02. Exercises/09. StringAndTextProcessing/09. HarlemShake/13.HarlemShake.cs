using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarlemShake
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var key = Console.ReadLine();
            while (true)
            {
                var firstIndex = input.IndexOf(key);
                var lastIndex = input.LastIndexOf(key);
                var leftIndexExist = firstIndex != -1;
                var rightIndexExist = lastIndex != -1;
                var leftandrightindexareequal = firstIndex == lastIndex;
                var keyIsEmpty = key == string.Empty;
                if (leftIndexExist && rightIndexExist && !leftandrightindexareequal && !keyIsEmpty)
                {
                    input = input.Remove(lastIndex, key.Length);
                    input = input.Remove(firstIndex, key.Length);
                    Console.WriteLine("Shaked it.");
                    key = key.Remove(key.Length / 2,1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
