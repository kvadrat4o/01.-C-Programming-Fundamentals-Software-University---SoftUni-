/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/07
 * Time: 9:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace WeatherForecast
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			string input = Console.ReadLine();
            try
            {
                sbyte.Parse(input);
                Console.WriteLine("Sunny");
            }
            catch (Exception)
            {
                try
                {
                    int.Parse(input);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {
                    try
                    {
                        long.Parse(input);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            decimal.Parse(input);
                            Console.WriteLine("Rainy");
                        }
                        catch(Exception)
                        {
                            
                        }
                    }
                }
            }
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}