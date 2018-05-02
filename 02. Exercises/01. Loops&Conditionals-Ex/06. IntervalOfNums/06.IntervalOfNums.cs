/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 10:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace IntervalOfNums
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            PrintInterval(start, end);
            // TODO: Implement Functionality Here

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void PrintInterval(int start, int end)
        {

            for (int i = Math.Min(start, end); i <= Math.Max(start, end); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}