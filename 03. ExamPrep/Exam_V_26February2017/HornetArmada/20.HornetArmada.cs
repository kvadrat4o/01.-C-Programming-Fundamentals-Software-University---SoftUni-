using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> legionsByActivity = new SortedDictionary<string, int>();
            SortedDictionary<string,SortedDictionary<string,long>>legionsDetails = new SortedDictionary<string,SortedDictionary<string,long>>();
            var n = int.Parse(Console.ReadLine());
            //var regex = new Regex(@"(?<id>\d+)\s\=\s(?<legion>.+)\s\-\>\s(?<soldierType>.+)\:(?<soldierCount>\d+)");
            var regex = new Regex(@"^(?<id>\d+)\s=\s(?<legion>[^\=\-\>\:\s]+)\s\-\>\s(?<soldierType>[^\=\-\>\:\s]+):(?<soldierCount>\d+)$");
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                Match inputMatch = regex.Match(inputLine);
                var id = int.Parse(inputMatch.Groups["id"].Value);
                var name = inputMatch.Groups["legion"].Value;
                var soldierType = inputMatch.Groups["soldierType"].Value;
                var soldierCount = long.Parse(inputMatch.Groups["soldierCount"].Value);
                if (!legionsByActivity.ContainsKey(name))
                {
                    legionsByActivity.Add(name, id);
                    legionsDetails.Add(name, new SortedDictionary<string,long>());
                }
                if (id > legionsByActivity[name])
                {
                    legionsByActivity[name] = id;
                }
                if (!legionsDetails[name].ContainsKey(soldierType))
                {
                    legionsDetails[name].Add(soldierType,0);
                }
                legionsDetails[name][soldierType] += soldierCount;
            }
            List<string> query = Console.ReadLine().Split('\\').ToList();
            if (query.Count > 1)
            {
                var activity = int.Parse(query[0]);
                var soldiers = query[1];
                foreach (var legion in legionsDetails.Where(legion => legion.Value.ContainsKey(soldiers)).OrderByDescending(legion => legion.Value[soldiers]))
                {
                    if (legionsByActivity[legion.Key] < activity)
                    {
                        Console.WriteLine("{0} -> {1}", legion.Key, legionsDetails[legion.Key][soldiers]);
                    }
                }
            }
            else
            {
                string soldier = query[0];
                foreach (var legion in legionsByActivity.OrderByDescending(legion => legion.Value))
                {
                    if (legionsDetails[legion.Key].ContainsKey(soldier))
                    {
                        Console.WriteLine("{0} : {1}", legion.Value, legion.Key);
                    }
                }
            }
        }
    }
}
