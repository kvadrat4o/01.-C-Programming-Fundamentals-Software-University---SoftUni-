using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
              var pathdetails = new SortedDictionary<string, Dictionary<string, Dictionary<string, Dictionary<long, string>>>>();
            //directory -> filename -> fileend -> filesize
            var extSize = new Dictionary<string, long>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                List<string> info = inputLine.Split('\\',';').ToList();
                string root = info[0];
                long size = long.Parse(info[info.Count - 1]);
                string file = info[info.Count - 2];
                string pattern = @".([^.\\]+)$";
                string name = Regex.Replace(file, pattern, "");
                string fileend = file.Replace(name, "");
                string nfo = root + "\\" + name + fileend;
                pathdetails[nfo] = new Dictionary<string, Dictionary<string, Dictionary<long, string>>>();
                pathdetails[nfo][name] = new Dictionary<string, Dictionary<long, string>>();
                pathdetails[nfo][name][fileend] = new Dictionary<long, string>();
                pathdetails[nfo][name][fileend][size] = root;
            }
            string keyLine = Console.ReadLine();
            List<string> funcInfo = keyLine.Split(' ').ToList();
            string ende = funcInfo[0];
            string end = "." + ende;
            string dir = funcInfo[2];
            foreach (var path in pathdetails)
            {
                foreach (var pair in path.Value)
                {
                    foreach (var item in pair.Value.Where(w => w.Key == end))
                    {
                        foreach (var thing in item.Value.Where(x => x.Value == dir).OrderByDescending(y => y.Key))
                        {
                            string lastanme = pair.Key + item.Key;
                            extSize[lastanme] = thing.Key;
                        }
                    }
                }
            }
            if (extSize.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var pair in extSize.OrderByDescending(w => w.Value))
                {
                    Console.WriteLine($"{pair.Key} - {pair.Value} KB");
                }
            }
        }
    }
}