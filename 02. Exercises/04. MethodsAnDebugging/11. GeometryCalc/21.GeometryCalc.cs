/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/22
 * Time: 7:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GeometryCalc
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			string shape = Console.ReadLine().ToLower();
			double side = double.Parse(Console.ReadLine());
			if (shape=="rectangle"||shape=="triangle") {
				double sideTwo = double.Parse(Console.ReadLine());
				Console.WriteLine("{0:f2}",GetArea(shape,side,sideTwo));
			}
			else if (shape=="square"||shape=="circle") {
				Console.WriteLine("{0:f2}",GetProp(shape,side));
			}
			// TODO: Implement Functionality Here
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static double GetProp(string shape, double side) 
		{
			double property = 0.00;
			switch (shape) 
			{
				case "square":
					property = side*side;
					return property;
				case "circle":
					property = Math.PI*side*side;
					return property;
				default:
					Console.WriteLine("Default");
					return property;
			}
		}
		public static double GetArea(string shape,double side, double sideTwo) 
		{
			double result = 0.00;
			switch (shape) 
			{
				case"triangle":
					result = (side*sideTwo)/2;
					return result;
				case"rectangle":
					result = side*sideTwo;
					return result;
				default:
					return result;
			}
		}
	}
}