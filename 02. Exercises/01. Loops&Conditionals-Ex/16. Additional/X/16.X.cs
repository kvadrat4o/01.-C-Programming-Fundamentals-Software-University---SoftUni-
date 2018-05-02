/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 1:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace X
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int n = int.Parse(Console.ReadLine());
            PrintX(n);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void PrintX(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{2}", new string(' ', i), new string(' ', n - 2 - 2 * i), new string(' ', i));
            }
            Console.WriteLine("{0}x{1}", new string(' ', n / 2), new string(' ', n / 2));
            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.WriteLine("{0}x{1}x{2}", new string(' ', n / 2 - 1 - i), new string(' ', 1 + 2 * i), new string(' ', n / 2 - 1 - i));
            }
        }
    }
}