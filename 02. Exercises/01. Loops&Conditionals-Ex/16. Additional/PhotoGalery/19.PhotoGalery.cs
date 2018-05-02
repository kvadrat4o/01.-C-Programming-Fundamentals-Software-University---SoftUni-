/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 4:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PhotoGalery
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string number = Console.ReadLine();
            string day = Console.ReadLine();
            string month = Console.ReadLine();
            string year = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            long size = long.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            // TODO: Implement Functionality Here
            PrintDetails(number, day, month, year, hours, minutes, size, width, height);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void PrintDetails(string number, string day, string month, string year, int hours, int minutes, long size, int width, int height)
        {
            string orientation = null;
            if (width == height)
            {
                orientation = "square";
            }
            else if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }

            Console.WriteLine("Name: DSC_{0:d4}.jpg\nDate Taken: {1:d2}/{2:d2}/{3} {4}:{5:d2}", number, day, month, year, hours, minutes);
            if (size < 1000)
            {
                Console.WriteLine("Size: {0}B", size);
            }
            else if (size < 1000000)
            {
                size /= 1000;
                Console.WriteLine("Size: {0}KB", size);
            }
            else
            {
                size /= 1000000;
                Console.WriteLine("Size: {0}MB", size);
            }
            Console.WriteLine("Resolution: {0}x{1} ({2})", width, height, orientation);
        }
    }
}