using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SUAirline
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //SortedDictionary<long,Dictionary<long,long>> flights = new SortedDictionary<long, Dictionary<long, long>>();
            Dictionary<long, double> flights = new Dictionary<long, double>();
            var adultPasCount = 0L;
            var adultTicketPrice = 0L;
            var youhtPasCount = 0L;
            var youthTicketPrice = 0L;
            var fuelPricePerHour = 0.00;
            var fuelConsuPerHour = 0.00;
            var flightDuration = 0;
            long tickets = 0;
            double expenses = 0.00;
            double total = 0.00;
            for (int i = 0; i < n; i++)
            {
                adultPasCount = long.Parse(Console.ReadLine());
                adultTicketPrice = long.Parse(Console.ReadLine());
                youhtPasCount = long.Parse(Console.ReadLine());
                youthTicketPrice = long.Parse(Console.ReadLine());
                fuelPricePerHour = double.Parse(Console.ReadLine());
                fuelConsuPerHour = double.Parse(Console.ReadLine());
                flightDuration = int.Parse(Console.ReadLine());
                tickets = (long)(adultPasCount * adultTicketPrice) + (youhtPasCount * youthTicketPrice);
                expenses = ((double)flightDuration * fuelConsuPerHour * fuelPricePerHour);
                total = tickets - expenses;
                //flights[tickets] = new Dictionary<long, long>();
                flights.Add(tickets,expenses);
            }
            foreach (var flight in flights)
            {
                if (flight.Key >= flight.Value)
                {
                    Console.WriteLine("You are ahead with {0:F3}$.", Math.Abs(flight.Key - flight.Value));
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:F3}$.", flight.Key - flight.Value);
                }
            }
            double  totalProfit = flights.Keys.Sum() - flights.Values.Sum();
            double avgProfit = totalProfit / n;
            Console.WriteLine("Overall profit -> {0:F3}$.\nAverage profit -> {1:F3}$.", totalProfit, avgProfit);
        }
    }
}
