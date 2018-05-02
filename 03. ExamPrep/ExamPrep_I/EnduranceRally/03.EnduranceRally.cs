using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] drivers = Console.ReadLine().Split(' ').ToArray();
            double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkPoints = Console.ReadLine().Split(' ').Select(int.Parse).Select(x => Math.Abs(x)).ToArray();
 
            foreach (var racer in drivers)
            {
                string message = "";
                double fuel = racer[0];
                int checkPointsCounter = 0;
 
                for (int i = 0; i < zones.Length; i++)
                {
                    bool isEqual = false;
 
                    for (int k = 0; k < checkPoints.Length; k++)
                    {
                        if (i == checkPoints[k])
                        {
                            isEqual = true;
                            break;
                        }
                    }
 
                    if (isEqual)
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }
 
                    if (fuel > 0)
                    {
                        checkPointsCounter++;
                    }
                    else
                    {
                        message = $"{racer} - reached {checkPointsCounter}";
                        Console.WriteLine(message);
                        break;
                    }
 
                }
 
                if (fuel > 0)
                {
                    message = $"{racer} - fuel left {fuel:f2}";
                    Console.WriteLine(message);
                }
 
            }
        }
    }
}
