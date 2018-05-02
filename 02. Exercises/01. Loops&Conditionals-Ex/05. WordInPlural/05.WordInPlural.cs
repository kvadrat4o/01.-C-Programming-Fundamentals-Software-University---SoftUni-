/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 10:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace WordInPlural
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string word = Console.ReadLine();
            Pluralize(word);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void Pluralize(string word)
        {
            string plural = null;
            if (word.EndsWith("y"))
            {
                plural = word.Remove(word.Length - 1).Insert(word.Length - 1, "ies");
                Console.WriteLine(plural);
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                plural = word.Insert(word.Length, "es");
                Console.WriteLine(plural);
            }
            else
            {
                plural = word.Insert(word.Length, "s");
                Console.WriteLine(plural);
            }
        }
    }
}