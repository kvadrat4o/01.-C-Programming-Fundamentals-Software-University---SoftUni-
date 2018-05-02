using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new Char[] {' ',',','!','.','?'}).ToList();
            List<string> palindromes = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                var word = input[i];
                IsPalindrome(word);
                if (IsPalindrome(word) == true)
                {
                    palindromes.Add(word);
                }
                //input.RemoveAt(0);
                word = input[i];
            }
            palindromes.Sort((a, b) => a.CompareTo(b));
            var pals = string.Join(", ", palindromes).ToString().Trim(' ',',');
            Console.WriteLine(pals);
        }
        public static bool IsPalindrome(string word)
        {
            int rightIndex = word.Length - 1;
            int leftIndex = 0;
            while (rightIndex >= leftIndex)
            {
                if (word[rightIndex] != word[leftIndex])
                {
                    return false;
                }
                rightIndex--;
                leftIndex++;
            }
            return true;
        }
    }
}
