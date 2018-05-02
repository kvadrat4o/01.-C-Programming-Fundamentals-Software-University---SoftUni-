/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/23
 * Time: 2:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MasterNumbers
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			 for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) == true && SumOfDigits(i) == true
                    && ContainsEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static bool IsPalindrome(int n)
		{
			string myNum = n.ToString();
            if (myNum.Length < 4 && myNum[0] == myNum[myNum.Length - 1])
            {
                return true;
            }
            else if (myNum.Length < 6 &&
                (myNum[0] == myNum[myNum.Length - 1] && myNum[1] == myNum[myNum.Length - 2]))
            {
                return true;
            }
            else if (myNum.Length < 8 &&
               (myNum[0] == myNum[myNum.Length - 1] && myNum[1] == myNum[myNum.Length - 2]
               && myNum[2] == myNum[myNum.Length-3]))
            {
                return true;
            }
            else
            {
                return false;
            }
		}
		public static bool SumOfDigits(int n)
		{
			string myNum = n.ToString();
            int sum = 0;
            for (int i = 0; i < myNum.Length; i++)
            {
                sum += int.Parse(myNum[i].ToString());
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
		}
		public static bool ContainsEvenDigit(int n)
		{
			string myNum = n.ToString();
            int evenCounter = 0;
            for (int i = 0; i < myNum.Length; i++)
            {
                int currentDigit = int.Parse(myNum[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    evenCounter++;
                }
            }
            if (evenCounter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
		}
	}
}
