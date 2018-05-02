using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var indeces = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).Where(a => a >= 0 && a < fieldSize).ToList();
            var ladyBugs = new int[fieldSize];
            foreach (var ladybuge in indeces)
            {
                ladyBugs[ladybuge] = 1;
            }
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                else
                {
                    var tokens = line.Split(' ');
                    var ladyBugIndex = int.Parse(tokens[0]);
                    var direction = tokens[1];
                    var count = int.Parse(tokens[2]);
                    var isInsideArr = ladyBugIndex >= 0 && ladyBugIndex < ladyBugs.Length;
                    if (!isInsideArr)
                    {
                        continue;
                    }
                    else
	                {
                        var ladyBugExist = ladyBugs[ladyBugIndex] == 1;
                        if (!ladyBugExist)
                        {
                            continue;
                        }
                        MoveLadyBug(ladyBugs,ladyBugIndex,direction,count);
	                }
                }
            }
            Console.WriteLine(string.Join(" ", ladyBugs));
        }

        private static void MoveLadyBug(int[] ladyBugs, int ladyBugIndex, string direction, int count)
        {
            if (direction == "left")
            {
                count = -count;
            }
            var nextIndece = ladyBugIndex + count;
            ladyBugs[ladyBugIndex] = 0;
            var hasLeftArrayOrFoundPlace = false;
            while (!hasLeftArrayOrFoundPlace)
            {
                if (nextIndece < 0 || nextIndece > ladyBugs.Length - 1)
                {
                    hasLeftArrayOrFoundPlace = true;
                    continue;
                }
                var ladyBugAlreadyExistOnIndex = ladyBugs[nextIndece] == 1;
                if (ladyBugAlreadyExistOnIndex)
                {
                    nextIndece += count;
                    continue;
                }
                ladyBugs[nextIndece] = 1;
                hasLeftArrayOrFoundPlace = true;
            }
        }
    }
}
