using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            var input = Console.ReadLine();
            var startIndex = 0;
            var endIndex = 0;
            while (input != "end")
            {
                var commandLine = input.Split(' ').ToList();
                var command = commandLine[0];
                switch (command)
                {
                    case "reverse" :
                        startIndex = int.Parse(commandLine[2]);
                        endIndex = int.Parse(commandLine[4]);
                        if (startIndex < 0 ||endIndex > arr.Length)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        else
                        {
                            arr = arr.Take(startIndex).Concat(arr.Skip(startIndex).Take(endIndex).Reverse()).Concat(arr.Skip(endIndex).Take(arr.Length - endIndex)).ToArray();
                            //arr = arr.Take(startIndex).Concat(arr.Skip(startIndex).Take(endIndex).Reverse()).Concat(arr.Skip(endIndex).Take(arr.Length - endIndex)).ToArray();
                            break;
                        }
                    case "sort":
                        startIndex = int.Parse(commandLine[2]);
                        endIndex = int.Parse(commandLine[4]);
                        if (startIndex < 0 || endIndex > arr.Length)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        else
                        {
                            arr = arr.Take(startIndex).Concat(arr.Skip(startIndex).Take(endIndex ).OrderBy(a => a)).Concat(arr.Skip(endIndex).Take(arr.Length - endIndex)).ToArray();
                            break;
                        }
                    case "rollLeft":
                        startIndex = int.Parse(commandLine[1]);
                        if (startIndex < 0 || startIndex > arr.Length)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < startIndex; i++)
                            {
                                var temp = arr[0];
                                //arr[0] = arr[arr.Length - 1];
                                //arr[(i + 1) % arr.Length] = arr[i];
                                arr = arr.Skip(1).Take(arr.Length - 1).Concat(arr.Take(1)).ToArray();
                            }
                            break;
                        }
                    case "rollRight":
                        startIndex = int.Parse(commandLine[1]);
                        if (startIndex < 0 || startIndex > arr.Length)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < startIndex; i++)
                            {
                                var temp = arr[0];
                                //arr[arr.Length - 1] = arr[0];
                                //arr[(i - 1) % arr.Length] = arr[i];
                                arr = arr.Skip(arr.Length - 1).Take(1).Concat(arr.Take(arr.Length - 1)).ToArray();
                            }
                            break;
                        }
                    default:
                        break;
                }
                input = Console.ReadLine();
                commandLine = input.Split(' ').ToList();
            }
            Console.WriteLine("[" + string.Join(", ",arr) + "]");
        }
    }
}
