using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static Dictionary<CommandType, Regex> commands = new Dictionary<CommandType, Regex>()
            {
                { CommandType.End, new Regex("end") },
                { CommandType.Reverse, new Regex("reverse from (.*) count (.*)") },
                { CommandType.Sort, new Regex("sort from (.*) count (.*)") },
                { CommandType.RollLeft, new Regex("rollLeft (.*) times") },
                { CommandType.RollRight, new Regex("rollRight (.*) times") },

            };
        static void Main(string[] args)
        {

            // Regex regex = new Regex("<tag1>(.*)</tag1>"); 
            Command cmd = null;
            do
            {
                string consoleLine = Console.ReadLine();
                cmd = ParseCommand(consoleLine);
                if (cmd != null && cmd.CommandType != CommandType.End)
                {
                    consoleLine = Console.ReadLine().Trim(' ');
                    var elements = consoleLine.Split(',');
                    if (elements != null && elements.Length > 0)
                    {
                        int[] myInts = Array.ConvertAll(elements, s => int.Parse(s));
                        myInts = cmd.Execute(myInts);
                        Console.WriteLine(string.Join(" , ", myInts));
                    }
                    else
                        Console.WriteLine("Invalid input parameters.");
                }

            } while (cmd == null || cmd.CommandType != CommandType.End);
        }

        public static Command ParseCommand(string input)
        {
            
            foreach (CommandType cmdType in Enum.GetValues(typeof(CommandType)))
            {
                Regex cmdRegEx = commands[cmdType];
                var match = cmdRegEx.Match(input);
                if (match.Success)
                {
                    switch (cmdType)
                    {
                        case CommandType.End:
                            return new EndCommand();
                        case CommandType.Reverse:
                        case CommandType.Sort:
                            var startIndes = match.Groups[0];
                            var elementCount = match.Groups[1];
                            if (cmdType == CommandType.Sort)
                                return new SortCommand(int.Parse(startIndes.Value), int.Parse(elementCount.Value));
                            else
                                return new ReverseCommand(int.Parse(startIndes.Value), int.Parse(elementCount.Value));

                    }
                }
                
            }
            return null;
        }
    }

    public enum CommandType { Reverse, Sort, RollLeft, RollRight, End}
    public abstract class Command
    {
        public readonly CommandType CommandType;
        public Command(CommandType type)
        {
            CommandType = type;
        }

        public abstract int[] Execute(int[] arr);

    }

    public class ReverseCommand : Command
    {
        public readonly int Start;
        public readonly int Count;
        public ReverseCommand(int Start, int Count ) : base(CommandType.Reverse)
        {
            this.Start = Start;
            this.Count = Count;
        }

        public override int[] Execute(int[] arr)
        {
            int startIndex = Math.Min(Start, arr.Length - 1);
            int elementsCount = Math.Min(arr.Length - startIndex, Count);

            int[] reverseArr = new int[elementsCount];
            for (int i = startIndex + elementsCount ; i >= startIndex; i--)
            {
                reverseArr[startIndex + elementsCount - i] = arr[i];
            }

            for (int i = startIndex; i < startIndex + elementsCount; i++)
            {
                arr[i] = reverseArr[i - startIndex];
            }

            return arr;
        }
    }

    public class SortCommand : Command
    {
        public readonly int Start;
        public readonly int Count;
        public SortCommand(int Start, int Count) : base(CommandType.Sort)
        {
            this.Start = Start;
            this.Count = Count;
        }

        public override int[] Execute(int[] arr)
        {
            int startIndex = Math.Min(Start, arr.Length - 1);
            int elementsCount = Math.Min(arr.Length - startIndex, Count);

            int[] sortArray = new int[elementsCount];
            for (int i = startIndex; i < startIndex + elementsCount; i++)
            {
               sortArray[i - startIndex] = arr[i];
            }

            Array.Sort(sortArray);

            for (int i = startIndex; i < startIndex + elementsCount; i++)
            {
                arr[i] = sortArray[i - startIndex];
            }

            return arr;
        }
    }

    public class EndCommand : Command
    {
        public EndCommand() : base(CommandType.End)
        { }
        

        public override int[] Execute(int[] arr)
        {
            throw new NotImplementedException();
        }
    }
}
