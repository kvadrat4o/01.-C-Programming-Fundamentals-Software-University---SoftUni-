using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("lines.txt");
            var oddlines = lines.Where((line, a) => a % 2 == 1);
            File.WriteAllLines("output.txt",oddlines);
        }
    }
}
