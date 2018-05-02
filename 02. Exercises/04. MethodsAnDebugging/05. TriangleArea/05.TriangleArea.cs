/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/18
 * Time: 11:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TriangleArea
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			double a = double.Parse(Console.ReadLine());
			double ha = double.Parse(Console.ReadLine());
			double area = GeTriangleArea(a,ha);
			Console.WriteLine(area);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static double GeTriangleArea(double a,double ha)
		{
			return a*ha/2;
		}
	}
}