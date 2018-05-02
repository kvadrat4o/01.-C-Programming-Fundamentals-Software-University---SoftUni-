/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 11:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CakeIngredients
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BakeCake();
            // TODO: Implement Functionality Here

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void BakeCake()
        {
            int counter = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", counter);
                    break;
                }
                counter++;
                Console.WriteLine("Adding ingredient {0}.", ingredient);
            }
        }
    }
}