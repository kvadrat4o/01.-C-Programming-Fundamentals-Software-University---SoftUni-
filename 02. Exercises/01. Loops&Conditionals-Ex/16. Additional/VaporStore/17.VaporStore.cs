/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 1:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VaporStore
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            double balance = double.Parse(Console.ReadLine());

            double totalSpent = 0;

            while (balance > 0)
            {
                string game = Console.ReadLine();

                if (game == "OutFall 4")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                }
                if (game == "CS: OG")
                {
                    if (balance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= 15.99;
                        totalSpent += 15.99;
                        Console.WriteLine("Bought CS: OG");
                    }

                }
                if (game == "Zplinter Zell")
                {
                    if (balance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= 19.99;
                        totalSpent += 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                }
                if (game == "Honored 2")
                {
                    if (balance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= 59.99;
                        totalSpent += 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }

                }
                if (game == "RoverWatch")
                {
                    if (balance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= 29.99;
                        totalSpent += 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                }
                if (game == "RoverWatch Origins Edition")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }

                }
                if (game == "Game Time")
                {
                    Console.WriteLine("Total spent: ${totalSpent:F2}. Remaining: ${balance:F2} ");
                    break;
                }
                else if (game != "OutFall 4" && game != "CS: OG" && game != "Zplinter Zell" && game != "Honored 2" && game != "RoverWatch" && game != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                }

            }

            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}