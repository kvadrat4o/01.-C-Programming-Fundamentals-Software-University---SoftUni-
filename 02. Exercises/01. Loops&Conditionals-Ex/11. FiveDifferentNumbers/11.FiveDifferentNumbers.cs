/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 11:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FiveDifferentNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            // TODO: Implement Functionality Here
            PrintNums(n, m);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void PrintNums(int n, int m)
        {
            var check = false;
            for (int a = n; a <= m; a++)
            {
                for (int b = n; b <= m; b++)
                {
                    for (int c = n; c <= m; c++)
                    {
                        for (int d = n; d <= m; d++)
                        {
                            for (int e = n; e <= m; e++)
                            {
                                if (n <= a && a < b && b < c && c < d && d < e && e <= m)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4}", a, b, c, d, e);
                                    check = true;
                                }
                            }
                        }
                    }
                }
            }
            if (check == false)
                Console.WriteLine("No");

        }
    }
}