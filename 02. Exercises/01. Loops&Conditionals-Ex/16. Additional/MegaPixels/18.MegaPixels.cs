/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 4:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MegaPixels
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            GetMPx(height, width);
            // TODO: Implement Functionality Here

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void GetMPx(double height, double width)
        {
            double megaPx = Math.Round(((height * width) / 1000000), 1);
            Console.WriteLine("{0}x{1} => {2}MP", height, width, megaPx);
        }
    }
}