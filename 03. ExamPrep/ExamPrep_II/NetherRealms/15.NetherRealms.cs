using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(new char[] {' ',','},StringSplitOptions.RemoveEmptyEntries).Select(Demon.Parse).OrderBy(a => a.Name).ToArray();
            foreach (var demon in demons)
            {
                Console.WriteLine("{0} - {1} health, {2:F2} damage",demon.Name,demon.Health,demon.Damage);
            }
        }
    }
    class Demon
    {
        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Damage { get; set; }


        internal static Demon Parse(string demonStr)
        {
            var damageRegex = new Regex (@"-?\d+(?:\.\d+)?");
            var healthRegex = new Regex (@"[^\d\-*\/\.]");
            var name = demonStr;
            var health = healthRegex.Matches(demonStr).Cast<Match>().Select(a => (int)Char.Parse(a.Value)).Sum();
            var damage = damageRegex.Matches(demonStr).Cast<Match>().Select(a =>decimal.Parse(a.Value)).ToList().Sum();
            var multiplyCount = demonStr.Count(a => a == '*');
            var devideCount = demonStr.Count(a => a == '/');
            damage *= (int)Math.Pow(2, multiplyCount);
            damage /= (int)Math.Pow(2, devideCount); ;
            var demon = new Demon
                {
                    Name = name,
                    Health = health,
                    Damage = damage
                };
            return demon;
        }
    }
}