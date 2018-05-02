using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries).Select(a => long.Parse(a)).ToList();
            var hornets = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => long.Parse(a)).ToList();
            HornetVsBees(beehives, hornets);
            PrintWinner(beehives,hornets);
        }

        private static void PrintWinner(List<long> beehives, List<long> hornets)
        {
            Console.WriteLine(beehives.Any() ? string.Join(" ", beehives) : string.Join(" ", hornets));
        }
        private static void HornetVsBees(List<long> beehives, List<long> hornets)
        {
            for (int i = beehives.Count - 1; i >= 0; i--)
            {

                if (hornets.Sum() > beehives[beehives.Count - 1 - i])
                {
                    beehives.Remove(beehives[beehives.Count - 1 - i]);
                }
                else if (hornets.Sum() < beehives[beehives.Count - 1 - i])
                {
                    beehives[beehives.Count - 1 - i] -= hornets.Sum();
                    hornets.Remove(hornets[0]);
                    if (hornets.Count == 0)
                    {
                        break;
                    }
                }
                else if (hornets.Sum() == beehives[beehives.Count - 1 - i])
                {
                    beehives.Remove(beehives[beehives.Count - 1 - i]);
                    hornets.Remove(hornets[0]);
                    if (hornets.Count == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}
