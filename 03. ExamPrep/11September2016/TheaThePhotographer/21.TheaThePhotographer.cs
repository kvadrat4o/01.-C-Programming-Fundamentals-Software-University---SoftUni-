using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var picsTaken = long.Parse(Console.ReadLine());
            var ft = long.Parse(Console.ReadLine());
            var ff = long.Parse(Console.ReadLine());
            var ut = long.Parse(Console.ReadLine());
            var filteredPics = Math.Ceiling(picsTaken * (ff / 100.00));

            var time1 = picsTaken * ft;

            var time2 = filteredPics * ut;

            var time = time1 + time2;

            TimeSpan secs = TimeSpan.FromSeconds(time);
            string result = secs.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(result);
        }
    }
}
