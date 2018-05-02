/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 8:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ChooseDrink2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // TODO: Implement Functionality Here
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            GetDrink(profession, quantity);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void GetDrink(string profession, int quantity)
        {
            string drink = null;
            double price = 0.00;
            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    price = quantity * 0.70;
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession, price);
                    break;
                case "Businessman":
                    drink = "Coffee";
                    price = quantity * 1.00;
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession, price);
                    break;
                case "Busineswoman":
                    drink = "Coffee";
                    price = quantity * 1.00;
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession, price);
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    price = quantity * 1.70;
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession, price);
                    break;
                default:
                    drink = "Tea";
                    price = quantity * 1.20;
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession, price);
                    break;
            }
        }
    }
}