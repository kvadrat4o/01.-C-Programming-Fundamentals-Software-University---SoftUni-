/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/22
 * Time: 1:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CenterPoint
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x1 = int.Parse(Console.ReadLine());
			int y1 = int.Parse(Console.ReadLine());
			int x2 = int.Parse(Console.ReadLine());
			int y2 = int.Parse(Console.ReadLine());
			
			PrintPoint(x1,y1,x2,y2);
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void PrintPoint (int x1, int y1, int x2, int y2)
		{
			if (x1<x2&&y1<y2) 
			{
				Console.WriteLine("({0},{1})",x1,y1);
			}
			else if (x2<x1&&y2<y1) 
			{
				Console.WriteLine("({0},{1})",x2,y2);
			}
			else 
			{
				Console.WriteLine("({0},{1})",x1,y1);	
			}
		}
	}
}