using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("input.txt").ToLower().Split(new char[] { '\n', '\r', ' ', ',', '.', '\'', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var count = new Dictionary<string, int>();
            var output = new SortedDictionary<string,string>();
            foreach (string word in words)
            {
                count[word] = 0;
            }
            foreach (string word in text)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
            }
            
        }
    }
}
