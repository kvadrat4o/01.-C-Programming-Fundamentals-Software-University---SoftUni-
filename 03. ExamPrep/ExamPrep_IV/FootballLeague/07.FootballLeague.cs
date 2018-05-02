using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();
            Dictionary<string, int> topTeams = new Dictionary<string, int>();
            Dictionary<string, int> goalsbyTeam = new Dictionary<string, int>();
            while (input != "final")
            {
                var command = input.Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries);
                var team1 = command[0];
                var team2 = command[1];
                var score = command[2].Split(':');
                var index1 = team1.IndexOf(key) + key.Length;
                var index1end = team1.LastIndexOf(key);
                var decripted1 = team1.Substring(index1, index1end).Reverse().ToString().ToUpper();
                var index2 = team2.IndexOf(key) + key.Length;
                var index2end = team2.LastIndexOf(key);
                var decripted2 = team2.Substring(index2, index2end).Reverse().ToString().ToUpper();
                int team1Goals = int.Parse(score[0]);
                int team2Goals = int.Parse(score[1]);
                if (team1Goals > team2Goals)
                {
                    ScoreAdd(topTeams, decripted1, 3);
                    ScoreAdd(topTeams, decripted2, 0);
                }
                else if (team1Goals < team2Goals)
                {
                    ScoreAdd(topTeams, decripted1, 0);
                    ScoreAdd(topTeams, decripted2, 3);
                }
                else
                {
                    ScoreAdd(topTeams, decripted1, 1);
                    ScoreAdd(topTeams, decripted2, 1);
                }

                ScoreAdd(goalsbyTeam, decripted1, team1Goals);
                ScoreAdd(goalsbyTeam, decripted2, team2Goals);



                command = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine("League standings:");
            var sorted = topTeams.OrderByDescending(a => a.Value).ThenBy(a => a.Key);
            int count = 1;
            foreach (var team in sorted)
            {
                Console.WriteLine($"{count}. {team.Key} {team.Value}");
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");
            var sortedGoals = goalsbyTeam.OrderByDescending(a => a.Value).ThenBy(a => a.Key).Take(3);
            foreach (var team in sortedGoals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
                count++;
            }
        }
        public static void ScoreAdd(Dictionary<string, int> topTeams, string decripted1, int team1Goals)
        {
            if (!topTeams.ContainsKey(decripted1))
            {
                topTeams.Add(decripted1, 0);
            }

            topTeams[decripted1] += team1Goals;
        }
    }
}
