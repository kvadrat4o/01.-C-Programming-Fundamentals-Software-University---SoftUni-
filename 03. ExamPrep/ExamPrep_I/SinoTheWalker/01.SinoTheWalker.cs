using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            double steps = double.Parse(Console.ReadLine()) % 86400;
            double secondsPerStep = double.Parse(Console.ReadLine()) % 86400;
            var timeWalked = secondsPerStep * steps;
            DateTime ArrivalTime = time.AddSeconds(timeWalked);
            Console.WriteLine("Time Arrival: {0}", ArrivalTime.ToString("HH:mm:ss"));
        }
    }
}
