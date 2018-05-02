using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input.txt");
            var lines2 = File.ReadAllLines("input2.txt");
            File.AppendAllLines("output.txt",lines2);
            File.AppendAllLines("output.txt",lines);
        }
    }
}
