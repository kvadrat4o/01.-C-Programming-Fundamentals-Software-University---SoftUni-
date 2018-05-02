/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 11:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CountNums
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var count = 0;
            try
            {
                while (true)
                {
                    var n = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(count);
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}