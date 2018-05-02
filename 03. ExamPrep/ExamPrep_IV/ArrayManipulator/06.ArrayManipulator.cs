using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Trim().Split().Select(a => int.Parse(a)).ToArray();

            var input = Console.ReadLine();
            while (input != "end")
            {
                var command = input.Split();
                switch (command[0])
                {
                    case "exchange":
                        int index = int.Parse(command[1]);
                        if (index < 0 || index >= arr.Length)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        arr = Exchange(arr, index + 1);
                        break;
                    case "max":
                    case "min":
                        Console.WriteLine(GetIndex(arr, command[0], command[1]));
                        break;
                    case "first":
                    case "last":
                        Console.WriteLine(GetSequence(arr, int.Parse(command[1]), command[0], command[2]));
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

        static int[] Exchange(int[] arr, int index)
        {
            return arr.Skip(index).Concat(arr.Take(index)).ToArray();
        }

        static string GetIndex(int[] arr, string type, string parity)
        {
            int remainder = parity == "odd" ? 1 : 0;
            int[] filtered = arr.Where(n => n % 2 == remainder).ToArray();

            if (!filtered.Any())
            {
                return "No matches";
            }

            return type == "min" ? Array.LastIndexOf(arr, filtered.Min()).ToString() : Array.LastIndexOf(arr, filtered.Max()).ToString();
        }

        static string GetSequence(int[] arr, int count, string type, string parity)
        {
            if (count > arr.Length)
            {
                return "Invalid count";
            }

            int remainder = parity == "odd" ? 1 : 0;
            int[] filtered = arr.Where(n => n % 2 == remainder).ToArray();

            return type == "first" ? "[" + string.Join(", ", filtered.Take(count)) + "]" : "[" + string.Join(", ", filtered.Reverse().Take(count).Reverse()) + "]"; 
        }
    }
}
