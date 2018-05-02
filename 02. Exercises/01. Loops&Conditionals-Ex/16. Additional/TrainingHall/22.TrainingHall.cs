/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 6:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrainingHall
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            double budget = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double money_spent = 0;
            for (int i = 0; i < n; i++)
            {
                String s = Console.ReadLine();

                double price = double.Parse(Console.ReadLine());

                double quantity = double.Parse(Console.ReadLine());
                // int quantity = int.Parse(Console.ReadLine());

                money_spent += price * quantity;
                if (quantity <= 2)
                    Console.WriteLine($"Adding {quantity} {s}s to cart.");
                else Console.WriteLine($"Adding {quantity} {s}s to cart.");
            }

            if (money_spent <= budget)
            {
                Console.WriteLine($"Subtotal: ${money_spent:F2}");
                Console.WriteLine($"Money left: ${Math.Abs(budget - money_spent):F2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${Math.Abs(money_spent):F2}");
                Console.WriteLine($"Not enough. We need ${money_spent - budget:F2} more.");
            }

        }
    }
}