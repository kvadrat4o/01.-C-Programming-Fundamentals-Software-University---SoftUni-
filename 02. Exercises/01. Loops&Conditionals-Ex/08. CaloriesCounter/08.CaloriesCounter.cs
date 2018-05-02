/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 11:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CaloriesCounter
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int n = int.Parse(Console.ReadLine());
            // TODO: Implement Functionality Here
            GetCalories(n);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void GetCalories(int n)
        {
            int calories = 0;
            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:

                        break;
                }
            }
            Console.WriteLine("Total calories: {0}", calories);
        }
    }
}