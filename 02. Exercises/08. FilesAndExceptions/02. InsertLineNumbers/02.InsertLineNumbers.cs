using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace InsertLineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("lines.txt");
            var numbers = lines.Select((line, index) => "{index + 1}.{line}");
            File.WriteAllLines("output.txt",numbers);
        }
    }
}
