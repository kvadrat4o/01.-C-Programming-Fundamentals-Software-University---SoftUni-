/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/26
 * Time: 9:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TripleSum
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			GeTriplets();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void GeTriplets()
		{
			string[] stringArr = Console.ReadLine().Split(' ');
       
        	int[] arr = new int[stringArr.Length];
			for (int i = 0; i < stringArr.Length; i++) 
			{
				arr[i] = int.Parse(stringArr[i]);
			}
			bool triplets = false;
			for (int i = 0; i < arr.Length; i++)
			{
	          for (int j = i + 1; j < arr.Length; j++)
	          {
	            for (int k = 0; k < arr.Length; k++)
	            {
	              if (arr[i] + arr[j] == arr[k])
	              {
	                  Console.WriteLine("{0} + {1} == {2}", arr[i], arr[j], arr[k]);       
	                  triplets = true;
	                  break;
	              }
	            }
	          }
			}
     
        if (!triplets)
            Console.WriteLine("No");
		}
	}
}