/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 8:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RestaurantDiscount
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int guests = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            GetReservation(guests, package);
            // TODO: Implement Functionality Here

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void GetReservation(int guests, string package)
        {
            string hall = null;
            double packPrice = 0.00;
            double hallPrice = 0.00;
            double totalPrice = 0.00;
            if (guests <= 50)
            {
                hall = "Small Hall";
                hallPrice = 2500;
                switch (package)
                {
                    case "Normal":
                        packPrice = 500;
                        totalPrice = (hallPrice + packPrice - (hallPrice + packPrice) * 0.05) / guests;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hall, totalPrice);
                        break;
                    case "Gold":
                        packPrice = 750;
                        totalPrice = (hallPrice + packPrice - (hallPrice + packPrice) * 0.10) / guests;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hall, totalPrice);
                        break;
                    case "Platinum":
                        packPrice = 1000;
                        totalPrice = (hallPrice + packPrice - (hallPrice + packPrice) * 0.15) / guests;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hall, totalPrice);
                        break;
                    default:
                        Console.WriteLine("We do not have an appropriate hall.");
                        break;
                }
            }
            else if (guests > 50 && guests <= 100)
            {
                hall = "Terrace";
                hallPrice = 5000;
                switch (package)
                {
                    case "Normal":
                        packPrice = 500;
                        totalPrice = (hallPrice + packPrice - (hallPrice + packPrice) * 0.05) / guests;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hall, totalPrice);
                        break;
                    case "Gold":
                        packPrice = 750;
                        totalPrice = (hallPrice + packPrice - (hallPrice + packPrice) * 0.10) / guests;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hall, totalPrice);
                        break;
                    case "Platinum":
                        packPrice = 1000;
                        totalPrice = (hallPrice + packPrice - (hallPrice + packPrice) * 0.15) / guests;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hall, totalPrice);
                        break;
                    default:
                        Console.WriteLine("We do not have an appropriate hall.");
                        break;
                }
            }
            else if (guests > 100 && guests <= 120)
            {
                hall = "Great Hall";
                hallPrice = 7500;
                switch (package)
                {
                    case "Normal":
                        packPrice = 500;
                        totalPrice = (hallPrice + packPrice - (hallPrice + packPrice) * 0.05) / guests;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hall, totalPrice);
                        break;
                    case "Gold":
                        packPrice = 750;
                        totalPrice = (hallPrice + packPrice - (hallPrice + packPrice) * 0.10) / guests;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hall, totalPrice);
                        break;
                    case "Platinum":
                        packPrice = 1000;
                        totalPrice = (hallPrice + packPrice - (hallPrice + packPrice) * 0.15) / guests;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hall, totalPrice);
                        break;
                    default:
                        Console.WriteLine("We do not have an appropriate hall.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}