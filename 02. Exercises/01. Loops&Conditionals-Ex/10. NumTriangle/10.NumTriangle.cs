/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 11:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NumTriangle
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int n = int.Parse(Console.ReadLine());
            // TODO: Implement Functionality Here
            PrinTriangle(n);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void PrinTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
    }
}