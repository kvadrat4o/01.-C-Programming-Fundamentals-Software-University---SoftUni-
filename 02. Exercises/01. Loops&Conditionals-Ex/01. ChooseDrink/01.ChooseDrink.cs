/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 8:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ChooseDrink
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // TODO: Implement Functionality Here
            string profession = Console.ReadLine().ToLower();
            GetDrink(profession);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void GetDrink(string profession)
        {
            string drink = null;
            switch (profession)
            {
                case "athlete":
                    drink = "Water";
                    Console.WriteLine(drink);
                    break;
                case "businessman":
                    drink = "Coffee";
                    Console.WriteLine(drink);
                    break;
                case "busineswoman":
                    drink = "Coffee";
                    Console.WriteLine(drink);
                    break;
                case "softuni student":
                    drink = "Beer";
                    Console.WriteLine(drink);
                    break;
                default:
                    drink = "Tea";
                    Console.WriteLine(drink);
                    break;
            }
        }
    }
}