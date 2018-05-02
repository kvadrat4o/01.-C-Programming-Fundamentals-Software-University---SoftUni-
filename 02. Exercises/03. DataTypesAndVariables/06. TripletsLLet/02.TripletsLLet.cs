/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/09
 * Time: 9:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TripletsOfLiatinLetters
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter num: ");
			int num = int.Parse(Console.ReadLine());
			// TODO: Implement Functionality Here
			for (int i = 0; i < num; i++) {
				for (int j = 0; j < num; j++) {
					for (int k = 0; k < num; k++) {
						char letter1 = (char)('a'+i);
						char letter2 = (char)('a'+j);
						char letter3 = (char)('a'+k);
						Console.WriteLine("{0}{1}{2}",letter1,letter2,letter3);
					}
				}
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}