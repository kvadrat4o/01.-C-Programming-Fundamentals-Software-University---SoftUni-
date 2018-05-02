using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().TrimStart(new char[] { '0' });
            byte second = byte.Parse(Console.ReadLine());

            if (first == "0" || second == 0 || first == "")
            {
                Console.WriteLine(0);
                return;
            }

            byte product = 0;
            byte mind = 0;
            byte remainder = 0;
            StringBuilder result = new StringBuilder();

            for (int i = first.Length - 1; i >= 0; i--)
            {
                product = (byte)(byte.Parse(first[i].ToString()) * second + mind);
                mind = (byte)(product / 10);
                remainder = (byte)(product % 10);
                result.Append(remainder);
                if (i == 0 && mind != 0)
                {
                    result.Append(mind);
                }

            }

            char[] resultCharArr = result.ToString().ToCharArray();
            Array.Reverse(resultCharArr);
            Console.WriteLine(new string(resultCharArr));
        }
    }
}
