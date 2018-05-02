/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 1:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BalancedBrackets
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			int n = int.Parse(Console.ReadLine());
			bool locked = false;
            int openinBracketsC = 0;
            int closeBracketsC = 0;

            for (int i = 0; i < n; i++)
            {
                string currString = Console.ReadLine();
                if (currString.Length == 1)
                {
                    char currentChar = char.Parse(currString);
                    openinBracketsC += currentChar == '(' ? (int)1 : (int)0;
                    closeBracketsC += currentChar == ')' ? (int)1 : (int)0;
                    if (!(openinBracketsC == closeBracketsC ||
                        openinBracketsC == closeBracketsC + 1))
                    {
                        locked = true;
                    }
                }

            }

            bool isBalances = openinBracketsC == closeBracketsC;
            Console.WriteLine(isBalances && !locked ? "BALANCED" : "UNBALANCED");
		}
	}
}