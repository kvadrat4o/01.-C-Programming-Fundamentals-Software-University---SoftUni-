/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/26
 * Time: 9:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RoundingNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			RoundArray();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void RoundArray()
		{
			string[] rounders = Console.ReadLine().Split(' ');
			double[] toBeRounded = new double[rounders.Length];
			for (int i = 0; i < toBeRounded.Length; i++) {
				toBeRounded[i] = double.Parse(rounders[i]);
			}
			for (int i = 0; i < toBeRounded.Length; i++) {
				Console.WriteLine("{0}\n{1}",toBeRounded[i],Math.Round(toBeRounded[i], 0, MidpointRounding.AwayFromZero));
			}
		}
	}
}