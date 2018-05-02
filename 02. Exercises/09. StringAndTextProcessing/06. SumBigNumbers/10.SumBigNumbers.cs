using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().TrimStart(new char[] { '0' });
            string second = Console.ReadLine().TrimStart(new char[] { '0' });

            if (first.Length > second.Length)
            {
                second = second.PadLeft(first.Length, '0');
            }
            else
            {
                first = first.PadLeft(second.Length, '0');
            }

            byte sum = 0;
            byte mind = 0;
            byte remainder = 0;
            StringBuilder results = new StringBuilder();

            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = (byte)(byte.Parse(first[i].ToString()) + byte.Parse(second[i].ToString()) + mind);
                mind = (byte)(sum / 10);
                remainder = (byte)(sum % 10);
                results.Append(remainder);
                if (i == 0 && mind != 0)
                {
                    results.Append(mind);
                }
            }

            char[] resultToChar = results.ToString().ToCharArray();
            Array.Reverse(resultToChar);
            Console.WriteLine(new string(resultToChar));
        }
    }
}
