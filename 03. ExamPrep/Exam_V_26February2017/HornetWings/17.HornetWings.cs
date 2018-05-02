using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());
            var distance = (n / 1000) * m;
            var secsFlaps = n / 100;
            var resttime = (n / endurance) * 5;
            var totalSecs = secsFlaps + resttime;
            Console.WriteLine("{0:f2} m.\n{1} s.", distance, totalSecs);
        }
    }
}
