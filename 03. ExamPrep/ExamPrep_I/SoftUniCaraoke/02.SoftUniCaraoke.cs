using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCaraoke
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> participants = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            List<string> songs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            Dictionary<string, List<string>> winners = new Dictionary<string, List<string>>();
            //var Karaoke = new List<Participant>();
            var input = Console.ReadLine();
            while (input != "dawn")
            {
                List<string> singerNFO = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
 
                string participant = singerNFO[0];
                string song = singerNFO[1];
                string award = singerNFO[2];
 
                if (!participants.Any(s => s == participant) || !songs.Any(s => s == song))
                {
                    input = Console.ReadLine();
 
                    continue;
                };
                if (!winners.ContainsKey(participant))
                {
                    winners.Add(participant, new List<string>());
                }
 
                winners[participant].Add(award);
 
                input = Console.ReadLine();
            }
            if (winners.Count == 0)
            {
                Console.WriteLine("No awards");
 
                return;
            }
 
            foreach (KeyValuePair<string, List<string>> pair in winners.OrderByDescending(a => a.Value.Distinct().ToList().Count).ThenBy(n => n.Key))
            {
                List<string> awards = pair.Value.Distinct().ToList();
 
                Console.WriteLine($"{pair.Key}: {awards.Count} awards");
                foreach (string award in awards.OrderBy(n => n))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
