/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/05
 * Time: 6:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;

namespace EqualSums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
		  int[] arr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
 
            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = SumLeft(arr, i);
                int rightSum = SumRight(arr, i);
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
 
            }
            Console.WriteLine("no");
            Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
        }
        private static int SumLeft(int[] arr, int position)
        {
            int leftSum = 0;
 
            for (int i = position; i > 0; i--)
            {
                int nextPosition = i - 1;
                if (i==0 )
                {
                    leftSum += 0;
                    break;
                }
                else
                {
                    leftSum += arr[nextPosition];
                   
                }
            }
            return leftSum;
 
        }
 
        private static int SumRight(int[] arr, int position)
        {
            int rightSum = 0;
           
            for (int i = position; i < arr.Length; i++)
            {
                int nextPosition = (i +1 )%arr.Length;
                if (arr.Length == 1 || nextPosition == 0)
                {
                    rightSum += 0;
                   
                    break;
                }
                else
                {
                    rightSum += arr[nextPosition];
                   
                }
            }
            return rightSum;
        }
	}
}