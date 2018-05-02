/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/11
 * Time: 1:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace IncrementVariable
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			byte num = 0;
			int encrement = int.Parse(Console.ReadLine());
			int counter = 0;
			for (int i = 0; i < encrement; i++) {
				num++;	
			}
			counter = byte.MaxValue/255;
			num = (byte.MaxValue+1)%255;
			
			Console.WriteLine("{0}\nOverflowed {1} times",num-counter*255,counter);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}

 