using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SweetDesert
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            BigInteger guests = BigInteger.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double berryPricePerKg = double.Parse(Console.ReadLine());
            int sets = (int)(guests / 6);
            if (guests % 6 > 0)
            {
                sets += 1;
            }
            var price = sets * (2 * bananaPrice) + sets * (4 * eggPrice) + sets * (0.2 * berryPricePerKg);
            var difference = Math.Abs(cash - price);
            if (price <= cash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.",price);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.",difference);
            }
        }
    }
}
