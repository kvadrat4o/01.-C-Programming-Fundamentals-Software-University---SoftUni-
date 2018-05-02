using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUWaterSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalWatere = int.Parse(Console.ReadLine());
            var totalWater = totalWatere;
            var bottles = Console.ReadLine().Split(' ').Select(a => double.Parse(a)).ToList();
            var bottleCapacity = int.Parse(Console.ReadLine());
            var counter = 0;
            var diff = 0.00;
            var difference = 0;
            var emptyBottles = new  List<double>();
            var emptyBottlesIndexes = new List<double>();
            if (totalWater % 2 ==0)
            {
                for (int i = 0; i < bottles.Count ; i++)
                {
                    if (bottleCapacity < bottles[i])
                    {
                        continue;
                    }
                    else if (bottleCapacity == bottles[i])
                    {
                        continue;
                    }
                    else if (bottleCapacity > bottles[i])
                    {
                        if (totalWater <= bottleCapacity)
                        {
                            bottles[i] = totalWater;
                            //emptyBottlesIndexes[i] = (double)i;
                            continue;
                        }
                        diff = bottleCapacity - bottles[i];
                        totalWater -= (int)diff;
                        bottles[i] = bottleCapacity;
                        counter++;
                    }
                }
                difference = bottles.Count - counter;
                emptyBottlesIndexes.Reverse();
                emptyBottles = bottles.Where(a => a < bottleCapacity).ToList();
                if ((bottles.Count * bottleCapacity) - totalWatere <= 0)
                {
                    Console.WriteLine("Enough water!\nWater left: {0}l.",totalWater);
                }
                else
                {
                    Console.WriteLine("We need more water!\nBottles left: {0}", emptyBottles.Count);
                    Console.Write("With indexes: ");
                    for (int i = 0; i < difference; i++)
                    {
                        Console.Write(string.Format("{0}, ", i));
                    }
                }
            }
            else
            {
                for (int i = bottles.Count - 1; i >=0; i--)
                {
                    if (bottleCapacity < bottles[i])
                    {
                        continue;
                    }
                    else if (bottleCapacity == bottles[i])
                    {
                        continue;
                    }
                    else if (bottleCapacity > bottles[i])
                    {
                        if (totalWater <= bottleCapacity)
                        {
                            bottles[i] = totalWater;
                            //emptyBottlesIndexes[i] = (double)i;
                            continue;
                        }
                        diff = bottleCapacity - bottles[i];
                        totalWater -= (int)diff;
                        bottles[i] = bottleCapacity;
                        counter++;
                    }

                }

                difference = bottles.Count - counter;
                emptyBottles = bottles.Where(a => a < bottleCapacity).ToList();
                //emptyBottlesCapacity = emptyBottles.Select(b => bottleCapacity - b).ToList();
                emptyBottlesIndexes.Reverse();
                if ((bottles.Count * bottleCapacity) - totalWatere <= 0)
                {
                    Console.WriteLine("Enough water!\nWater left: {0}l.", totalWater);
                }
                else
                {
                    Console.WriteLine("We need more water!\nBottles left: {0}", emptyBottles.Count);
                    Console.Write("With indexes: ");
                    for (int i = difference - 1; i >=0; i--)
                    {
                        Console.Write(string.Format("{0}, ", i));
                    }
                }
            }
            
        }
    }
}
