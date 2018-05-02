/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/09
 * Time: 9:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RefractorPyramideVol
{
	class Program
	{
		public static void Main(string[] args)
		{
			//double dul, sh, V = 0;
			//Console.Write("Length: ");
			decimal length = decimal.Parse(Console.ReadLine());
			//Console.Write("Width: ");
			decimal width = decimal.Parse(Console.ReadLine());
			//Console.Write("Height: ");
			decimal height = decimal.Parse(Console.ReadLine());
          Console.WriteLine("Length: Width: Height: Pyramid Volume: {0:F2}",((length*width)*height) / 3);
		}
	}
}