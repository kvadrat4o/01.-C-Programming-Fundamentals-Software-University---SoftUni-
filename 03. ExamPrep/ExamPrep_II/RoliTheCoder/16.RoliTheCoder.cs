using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventsRegex = new Regex(@"(?<id>\d)\s+#(?<eventName>\w+)\s*(?<participants>(?:@[a-zA-Z0-9'-]+\s*)*)");
            var events = new Dictionary<int,Event>();
            while (true)
	        {
                var line = Console.ReadLine();
                if (line == "Time for Code")
	            {
		             break;
	            }
                var eventmatch = eventsRegex.Match(line);
                if (!eventmatch.Success)
	            {
		            continue;
	            }
                var id = int.Parse(eventmatch.Groups["id"].Value);
                var eventName = eventmatch.Groups["eventName"].Value;
                var participantsStr = eventmatch.Groups["participants"].Value;
                var participants = new  List<string>();
                if (participantsStr.Length > 0)
	            {
                    participants.AddRange(participantsStr.Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries));

	            }
                if (!events.ContainsKey(id))
	            {
                    var @event = new Event
                    {
                        Name = eventName,
                        Participants = participants
                    };
                    events[id] = @event;
	            }
                if (events[id].Name == eventName)
	            {
                    events[id].Participants.AddRange(participants);
	            }
	        }
            foreach (var @event in events)
            {
                @event.Value.Participants = @event.Value.Participants.Distinct().OrderBy(a => a).ToList();
            }
            var sortedEvents = events.OrderByDescending(pair => pair.Value.Participants.Count).ThenBy(a => a.Value.Name).Select(a => a.Value).ToList();
            foreach (var @event in sortedEvents)
            {
                Console.WriteLine("{0} - {1}", @event.Name, @event.Participants.Count);
                foreach (var participant in @event.Participants)
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
    public class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
}
