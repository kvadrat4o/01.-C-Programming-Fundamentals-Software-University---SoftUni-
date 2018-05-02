/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/22
 * Time: 2:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LongerLine
{
	class Program
	{
		public static void Main(string[] args)
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());
			double x3 = double.Parse(Console.ReadLine());
			double y3 = double.Parse(Console.ReadLine());
			double x4 = double.Parse(Console.ReadLine());
			double y4 = double.Parse(Console.ReadLine());
			CompareLines(x1,y1,x2,y2,x3,y3,x4,y4);
			//PrdoublePodouble(x1,y1,x2,y2);
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static bool PrintPoint (double x1, double y1, double x2, double y2)
		{
			bool isFirst = false;
			if (x1<x2&&y1<y2) 
			{
				Console.WriteLine("({0},{1})",x1,y1);
				isFirst=true;
				return isFirst;
				
			}
			else if (x2<x1&&y2<y1) 
			{
				Console.WriteLine("({0},{1})",x2,y2);
				isFirst=false;
				return isFirst;
			}
			else 
			{
				Console.WriteLine("({0},{1})",x1,y1);
				isFirst=true;
				return isFirst;
			}
		}
		public static void CompareLines (double x1, double y1, double x2, double y2,double x3, double y3, double x4, double y4)
		{
			if (Math.Sqrt((x2-x1)*(x2-x1)+ (y2-y1)*(y2-y1)) > Math.Sqrt(x4-x3)*(x4-x3)+ (y4-y3)*(y4-y3))
			{
				Console.WriteLine("({0}, {1}) ({2}, {3})",x2,y2,x1,y1);
			}
			else  if (Math.Sqrt((x2-x1)*(x2-x1)+ (y2-y1)*(y2-y1)) < Math.Sqrt((x4-x3)*(x4-x3)+ (y4-y3)*(y4-y3))) 
			{
			     Console.WriteLine("({0}, {1}) ({2}, {3})",x4,y4,x3,y3);
			}
			else 
			{	
				PrintPoint(x1,y1,x3,y3);
			}
		}
	}
}