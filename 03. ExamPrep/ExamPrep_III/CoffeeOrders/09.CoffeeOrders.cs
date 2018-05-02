using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;


namespace CoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<BigInteger, decimal> orders = new SortedDictionary<BigInteger, decimal>();
            int[] months = new int [] {31,28,31,30,31,30,31,31,30,31,30,31};
            var count = long.Parse(Console.ReadLine());
            var pricePerCapcule = 0.00M;
            var priceTotal = 0.00M;
            var orderDate = DateTime.Now;
            long capsulesCount = 0;
            for (int i = 0; i < count; i++)
            {
                pricePerCapcule = decimal.Parse(Console.ReadLine());
                orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var temp = long.Parse(orderDate.Month.ToString());
                long month = months[temp - 1];
                capsulesCount = long.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                priceTotal = ((daysInMonth * capsulesCount) * pricePerCapcule);
                if (!orders.ContainsKey(i))
                {
                    orders.Add(i,priceTotal);
                }
            }
            foreach (var order in orders)
            {
                Console.WriteLine("The price for the coffee is: ${0:F2}",order.Value);
            }
            Console.WriteLine("Total: ${0:f2}", orders.Sum(a => a.Value));
        }
    }
}
