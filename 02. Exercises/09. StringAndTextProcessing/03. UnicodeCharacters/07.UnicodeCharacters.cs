using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<char> chars = new List<char>();
            var str = "";
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
                sb.AppendFormat("\\u{0:x4}", (int)c);
            str =  sb.ToString();
            Console.WriteLine(str);
        }
    }
}
