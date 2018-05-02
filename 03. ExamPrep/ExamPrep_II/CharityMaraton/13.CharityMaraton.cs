using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMaraton
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonInDays = long.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var avgLapsPerRunner = long.Parse(Console.ReadLine());
            var lengthTrack = long.Parse(Console.ReadLine());
            var capacityTrack = long.Parse(Console.ReadLine());
            var moneyPerKM = decimal.Parse(Console.ReadLine());
            //var inputLine = Console.ReadLine().Split('\n').ToList();
            //var marathonInDays = int.Parse(inputLine[0]);
            //var runners = long.Parse(inputLine[1]);
            //var avgLapsPerRunner = int.Parse(inputLine[2]);
            //var lengthTrack = long.Parse(inputLine[3]);
            //var capacityTrakc = int.Parse(inputLine[4]);
            //var moneyPerKM = decimal.Parse(inputLine[5]);
            long totalCapacity = capacityTrack * marathonInDays;
            var totalrunners = capacityTrack * runners;
            if (totalCapacity < runners)
            {
               runners =  totalCapacity;
            }
            var totalKM = (runners * avgLapsPerRunner * lengthTrack) / 1000;
            var total = moneyPerKM * totalKM;
            Console.WriteLine("Money raised: {0:F2}",total);
        }
    }
}
