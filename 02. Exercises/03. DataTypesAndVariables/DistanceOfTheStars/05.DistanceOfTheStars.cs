/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/11
 * Time: 12:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DistanceOfTheStars
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			decimal nearStar = 4.22M*9450000000000M;
			decimal milkCenter = 26000M*9450000000000M;
			decimal milkDiameter = 100000M*9450000000000M;
			decimal earthEnd = 46500000000M*9450000000000M;
			Console.WriteLine("{0:e2}\n{1:e2}\n{2:e2}\n{3:e2}",Math.Round(nearStar,2),Math.Round(milkCenter,2),Math.Round(milkDiameter,2),Math.Round(earthEnd,2));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}